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
using System.Text.RegularExpressions;

namespace In_Out_system
{
    public partial class Admin_logged_main : Form
    {

        string provider = ConfigurationManager.AppSettings["providerName"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public Admin_logged_main()
        {
            InitializeComponent();

            FillCombo();
        }

        public void FillCombo()
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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
                // vybrat do comboboxu veci z databaze
                combo_hodnost.Items.Clear();
                combo_deleteRank.Items.Clear(); // Vyčistím comboboxy ( např. pro funkci addPerson, aby nebylo duplikováno )
                command.CommandText = "Select RTRIM(rank) FROM Rank";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string comboboxdata = reader.GetString(0);
                        combo_hodnost.Items.Add(comboboxdata);
                        combo_deleteRank.Items.Add(comboboxdata);
                    }
                }

                combo_deletePerson.Items.Clear(); // Combo na smazani člena
                combo_changePassword.Items.Clear(); // Combo na změnu hesla

                command.CommandText = "Select RTRIM(login) FROM Login";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string comboboxdata = reader.GetString(0);
                        combo_deletePerson.Items.Add(comboboxdata);
                        combo_changePassword.Items.Add(comboboxdata);
                    }
                }

                combo_deletePerson.SelectedIndex = 0;
                combo_changePassword.SelectedIndex = 0;
                combo_hodnost.SelectedIndex = 0;
                combo_deleteRank.SelectedIndex = 0;

                connection.Close();
            }
        }

        private void Admin_logged_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_addPerson_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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

                if (Regex.IsMatch(txtBox_createID.Text, @"(!|@|#)") || !txtBox_createID.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Špatně vyplněno 'Přihlášení'");
                    return;
                }

                // ID + heslo + combobox hodit do databaze
                command.CommandText = "INSERT INTO Login (Login,Password,Rank) VALUES ('"+this.txtBox_createID.Text+"','"+this.txtBox_createPassword.Text+"','"+this.combo_hodnost.Text+"') ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
                MessageBox.Show("Nový člen přidán!");

                // Zjistí ID_login vytvořeného persona
                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.txtBox_createID.Text + "' ;";
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }

                // Přidání loginu do 'Total', aby se 'work_minutes_total' mohl započítávat k němu
                command.CommandText = "INSERT INTO Total (ID_login) VALUES ('" + id_login + "') ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }

                txtBox_createID.Text = "";
                txtBox_createPassword.Text = "";
                combo_hodnost.Text = "";

                connection.Close();
            }
            FillCombo();
        }

        private void btn_showPersons_Click(object sender, EventArgs e) // Vypíše všechny členy
        {
            string txtresult="          Login \t Rank \n";

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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
                command.CommandText = "SELECT RTRIM(Login) AS Login, RTRIM(Rank) AS Rank FROM Login ;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                        txtresult = txtresult + count + ".       " + reader["Login"] + " \t " + reader["Rank"] + "\n";
                    }
                }
                connection.Close();
            }
            MessageBox.Show(txtresult);
        }

        private void btn_addRank_Click(object sender, EventArgs e) // Přidat hodnost
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection()) // connection
            {
                if (connection == null)
                {
                    MessageBox.Show("Connection ERROR :(");
                    return;
                }

                connection.ConnectionString = connectionString;

                if (Regex.IsMatch(txtBox_addRank.Text, @"(!|@|#)") || !txtBox_addRank.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Špatně vyplněn název nové hodnosti !");
                    return;
                }

                connection.Open();

                DbCommand command = factory.CreateCommand(); // command

                if (command == null)
                {
                    MessageBox.Show("Command ERROR :(");
                    return;
                }
                command.Connection = connection;
                // Rank (hodnost) hodit do databaze
                command.CommandText = "INSERT INTO Rank (Rank) VALUES ('" + this.txtBox_addRank.Text + "') ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                    MessageBox.Show("Nová hodnost přidána!");
                }

                txtBox_addRank.Text = "";

                FillCombo(); // Přidání nového Ranku do ostatních comboboxů

                connection.Close();
            }
        }

        private void btn_deleteRank_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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

                if (combo_deleteRank.Text == "Admin" || combo_deleteRank.Text == "New")
                {
                    MessageBox.Show("Tuto hodnost nelze smazat !");
                    return;
                }

                // Smazat Rank (hodnost) z databaze
                command.CommandText = "DELETE FROM Rank WHERE rank='" + this.combo_deleteRank.Text + "' ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
                // Změnit všechny hodnosti u aktivních členů (kteří mají hodnost, co se má smazat) na 'New'
                command.CommandText = "UPDATE Login SET Rank = 'New' WHERE rank='" + this.combo_deleteRank.Text + "' ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
                MessageBox.Show("Hodnost odebrána! \n Aktivním členům přiřazena hodnost 'New'!");

                txtBox_addRank.Text = "";

                FillCombo(); // Přidání nového Ranku do ostatních comboboxů

                connection.Close();
            }
        }

        private void btn_deletePerson_Click(object sender, EventArgs e)
        {
            DialogResult areyousure = MessageBox.Show("Určitě chcete smazat člena na trvalo?","Upozornění",MessageBoxButtons.YesNo);
            if (areyousure == DialogResult.Yes)
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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

                    // Zjistí ID_login persona, kterého chceme smazat
                    command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.combo_deletePerson.Text + "' ;";
                    int id_login = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_login = reader.GetInt32(0);
                        }
                    }
                    // Zjistí login persona, kterého chceme smazat
                    command.CommandText = "SELECT RTRIM(login) FROM Login WHERE login='" + this.combo_deletePerson.Text + "' ;";
                    string login = "";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            login = reader.GetString(0);
                        }
                    }
                    if (login == "Admin")
                    {
                        MessageBox.Show("Tohoto administrátora nelze smazat !");
                        return;
                    }

                    // Smaže údaje v Total (work_minutes_total)
                    command.CommandText = "DELETE FROM Total WHERE ID_login='" + id_login + "' ;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }

                    // Smaže údaje v Time
                    command.CommandText = "DELETE FROM Time WHERE ID_login='" + id_login + "' ;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }

                    // Smazat člena (Login) z databaze
                    command.CommandText = "DELETE FROM Login WHERE login='" + this.combo_deletePerson.Text + "' ;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                    MessageBox.Show("Člen smazán !");

                    FillCombo();

                    connection.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_form_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_changeinout_Click(object sender, EventArgs e)
        {
            bool alreadyopen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Admin - Změna času IN/OUT")
                {
                    alreadyopen = true;
                    f.BringToFront();
                    return;
                }
            }
            if (alreadyopen == false)
            {
                Form formchangeinout = new Form_changeINOUT();
                formchangeinout.Show();
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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

                // Update hesla
                command.CommandText = "UPDATE Login SET Password = '" + this.txtBox_newPassword.Text + "' FROM Login WHERE login='" + this.combo_changePassword.Text + "' ;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    }
                }

                MessageBox.Show("Heslo bylo úspěšně změněno !");

                connection.Close();
            }

        }
    }
}
