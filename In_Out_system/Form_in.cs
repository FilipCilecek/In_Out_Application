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
    public partial class Form_in : Form
    {
        string provider = ConfigurationManager.AppSettings["providerName"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public Form_in()
        {
            InitializeComponent();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            var timenow = DateTime.Now;
            var time_year = timenow.Year;
            var time_month = timenow.Month;
            var time_day = timenow.Day;
            var time_hour = timenow.Hour;
            var time_minute = timenow.Minute;

            string time_minute_converted = ""; // Aby se čas přihlášení nezobrazoval '19.4.2019 17:5' ale '19.4.2019 17:05'
            if (time_minute < 10)
            {
                time_minute_converted = "0" + time_minute;
            }
            else
            {
                time_minute_converted = "" + time_minute;
            }


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
                // Je login spravny ?
                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.txtBox_in_login.Text + "' ;";
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }
                if(id_login > 0)
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
                    if (time_out == false) // Pokud time_out byl zadán u minulého přihlášení, povolí se znovu přihlásit a začít další čas
                    {
                        command.CommandText = "INSERT INTO Time (time_in,ID_login) VALUES (GETDATE(), '" + id_login + "')  ;"; // Vloží time_in a ID_login do Time
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            }
                        }

                        MessageBox.Show("Úspěšné přihlášení, čas : \n" + time_day + "." + time_month + "." + time_year + " - " + time_hour + ":" + time_minute_converted + " ! ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Přihlášení již jste a čas stále běží !");
                    }

                }
                else
                {
                    MessageBox.Show("Přihlašovací jméno neexistuje !");
                }

                connection.Close();
            }
        }

        private void btn_form_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_in_Load(object sender, EventArgs e)
        {

        }
    }
}