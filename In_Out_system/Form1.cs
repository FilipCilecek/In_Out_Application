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
using System.Runtime.InteropServices;

namespace In_Out_system
{
    public partial class In_Out_form : Form
    {

        public In_Out_form()
        {
            InitializeComponent();

            lbl_currentdate.Text = DateTime.Now.ToShortDateString();

            var timenow = DateTime.Now;
            var time_month = timenow.Month;
            var time_day = timenow.Day;
            var time_hour = timenow.Hour;
            var time_minute = timenow.Minute;


            string provider = ConfigurationManager.AppSettings["providerName"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if(connection == null)
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

                connection.Close();
            }
        }

        private void In_Out_form_Load(object sender, EventArgs e)
        {
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            bool alreadyopen = false;

            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Příchod")
                {
                    alreadyopen = true;
                    f.BringToFront();
                    return;
                }
            }
            if(alreadyopen == false)
            {
                Form formin = new Form_in();
                formin.Show();
            }
            
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            bool alreadyopen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Odchod")
                {
                    alreadyopen = true;
                    f.BringToFront();
                    return;
                }
            }
            if (alreadyopen == false)
            {
                Form formout = new Form_out();
                formout.Show();
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            bool alreadyopen = false;

            foreach (Form f in Application.OpenForms)
            {
                if ((f.Text == "Admin Login") || (f.Text == "In Out - Admin"))
                {
                    alreadyopen = true;
                    f.BringToFront();
                    return;
                }
            }
            if (alreadyopen == false)
            {
                Form formadmin = new Form_admin_login();
                formadmin.Show();
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_form_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void timeTimer_Tick(object sender, EventArgs e)
        {
            lbl_currenttime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
