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
using System.Data.SqlClient;

namespace In_Out_system
{
    public partial class Form_admin_login : Form
    {
        public Form_admin_login()
        {
            InitializeComponent();

        }

        private void Form_admin_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            string provider = ConfigurationManager.AppSettings["providerName"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                if (connection == null)
                {
                    MessageBox.Show("Connection ERROR :(");
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    MessageBox.Show("Command ERROR :(");
                    return;
                }
                command.Connection = connection;

                SqlDataAdapter data = new SqlDataAdapter("Select Count(*) From Login where Login='" + txtBox_login.Text + "' and Password ='" + txtBox_password.Text + "' AND Rank='Admin';", connection);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    this.Close();
                    MessageBox.Show("Přihlášení bylo úspěšné !");
                    Form adminform = new Admin_logged_main();
                    adminform.Show();
                }
                else
                {
                    MessageBox.Show("Špatně zadané údaje !");
                }

                connection.Close();
            }
        }

        private void btn_form_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
