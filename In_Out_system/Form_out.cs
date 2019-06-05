using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Common;
using System.Configuration;

namespace In_Out_system
{
    public partial class Form_out : Form
    {
        string provider = ConfigurationManager.AppSettings["providerName"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public Form_out()
        {
            InitializeComponent();
        }

        private void btn_form_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            var timenow = DateTime.Now;
            var time_year = timenow.Year;
            var time_month = timenow.Month;
            var time_day = timenow.Day;
            var time_hour = timenow.Hour;
            var time_minute = timenow.Minute;

            using (DbConnection connection = factory.CreateConnection()) // connection
            {
                if (connection == null)
                {
                    MessageBox.Show("Connection ERROR :(");
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand(); // command

                if (command == null)
                {
                    MessageBox.Show("Command ERROR :(");
                    return;
                }
                command.Connection = connection;
                // Zjisti ID_login
                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.txtBox_out_login.Text + "' ;";
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }
                if (id_login > 0) // Login správný
                {
                    command.CommandText = "SELECT TOP 1 time_out FROM Time WHERE ID_login =('" + id_login + "') ORDER BY ID_t DESC;";
                    // Vypíše time_out ( jestli je NULL nebo je zadáno - zjistí, zda je person odhlášen )
                    bool time_out = false;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            time_out = reader.IsDBNull(0);
                        }
                    }
                    if (time_out == false) // Pokud time_out byl zadán u minulého přihlášení, povolí se znovu přihlásit a začít další čas ( time_out != NULL )
                    {
                        MessageBox.Show("Nejste přihlášeni, není tedy možno odhlášení !");
                    }
                    else // time_out == NULL
                    {
                        command.CommandText = "SELECT TOP 1 ID_t FROM Time WHERE ID_login =('" + id_login + "') ORDER BY ID_t DESC;";
                        // Zjistím ID_t, abych mohl u konkrétních uživatelů měnit time_out
                        int ID_t = 0;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ID_t = reader.GetInt32(0);
                            }
                        }

                        // Vloží time_out k Id_l, ktere ma time_out==NULL
                        command.CommandText = "UPDATE Time SET time_out=GETDATE() WHERE ID_t=('" + ID_t + "') AND ID_login=('" + id_login + "')  ;"; 
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            }
                        }
                        MessageBox.Show("Úspěšně odhlášeno !");

                        // Spočítá 'work_minutes' do dbo.Time - jen z current session
                        command.CommandText = "UPDATE Time SET work_minutes=DATEDIFF(MINUTE,time_in,time_out);";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            }
                        }

                        // Spočítá 'work_minutes_total' do dbo.Total pro ID_login, ktere se zrovna odhlasilo
                        command.CommandText = "UPDATE Total SET work_minutes_total=i.calculated FROM (SELECT SUM(work_minutes) AS calculated FROM Time WHERE ID_login='" + id_login + "') i WHERE ID_login='" + id_login + "';";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            }
                        }

                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Přihlašovací jméno neexistuje !");
                }

                connection.Close();
            }
        }

        private void Form_out_Load(object sender, EventArgs e)
        {

        }
    }
}
