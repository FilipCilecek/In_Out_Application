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
    public partial class Form_changeINOUT : Form
    {
        string provider = ConfigurationManager.AppSettings["providerName"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        string celldata0Begin = "";
        string celldata1Begin = "";
        string celldata0End = "";
        string celldata1End = "";
        string inorout = "";
        int id_time = 0;
        int id_login = 0;

        public Form_changeINOUT()
        {
            InitializeComponent();

            FillCombo();

        }

        private void Form_changeINOUT_Load(object sender, EventArgs e)
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

                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.combo_changeINOUT.Text + "' ;"; // Musim zjistit id_login vybraného člena
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }

                command.CommandText = "Select time_in, time_out FROM Time WHERE ID_login='" + id_login + "' ;"; // Vyplním GRID datama od vybraného ID_login
                DataTable gridData = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select time_in, time_out FROM Time WHERE ID_login='" + id_login + "' ;", sqlConnection);
                    sqlDA.Fill(gridData);
                    dataGrid_INOUT.DataSource = gridData;
                }

                connection.Close();
            }

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
                combo_changeINOUT.Items.Clear(); // Combo na zmenu casu
                command.CommandText = "Select login FROM Login";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string comboboxdata = reader.GetString(0);
                        combo_changeINOUT.Items.Add(comboboxdata);
                    }
                }

                combo_changeINOUT.SelectedIndex = 0;
                connection.Close();
            }
        }

        private void combo_changeINOUT_SelectedIndexChanged(object sender, EventArgs e)
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

                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.combo_changeINOUT.Text + "' ;"; // Musim zjistit id_login vybraného člena
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }

                DataTable gridData = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select time_in, time_out FROM Time WHERE ID_login='" + id_login + "' ;", sqlConnection);
                    // Vyplním GRID datama od vybraného ID_login
                    sqlDA.Fill(gridData);
                    dataGrid_INOUT.DataSource = gridData;
                }

                connection.Close();
            }
        }

        private void btn_saveGrid_Click(object sender, EventArgs e)
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

                command.CommandText = "SELECT Id_l FROM Login WHERE login='" + this.combo_changeINOUT.Text + "' ;"; // Musim zjistit id_login vybraného člena
                int id_login = 0;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_login = reader.GetInt32(0);
                    }
                }

                connection.Close();
            }
        }

        private void dataGrid_INOUT_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            int columnIndex = dataGrid_INOUT.CurrentCell.ColumnIndex;
            string columnName = dataGrid_INOUT.Columns[columnIndex].Name;
            
            // Uložím obojí datum před editací ( před uložením do DB je nutné ještě zkonvertovat formát )
            celldata0Begin = dataGrid_INOUT.Rows[e.RowIndex].Cells[0].Value.ToString();
            celldata1Begin = dataGrid_INOUT.Rows[e.RowIndex].Cells[1].Value.ToString();

            DateTime celldataDate;
            DateTime celldatavpravoDate;

            if (celldata1Begin == "") // Pokud je 'time_in' datum a 'time_out' je NULL
            {
                if(celldata0Begin == "")
                {
                    MessageBox.Show("Zde není co editovat !");
                    e.Cancel = true;
                    dataGrid_INOUT.EndEdit();
                    return;
                }
                //DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

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

                    celldataDate = DateTime.Parse(celldata0Begin);
                    celldata0Begin = celldataDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Musim zjistit ID_t vybraného záznamu
                    command.CommandText = "SELECT ID_t FROM Time WHERE time_in='" + celldata0Begin + "' AND time_out IS NULL ;";
                    id_time = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_time = reader.GetInt32(0);
                        }
                    }

                    connection.Close();
                }
            }


            // Uložím, jaký řádek je editován (time_in / time_out) + zkontroluji, zda má v sobě cell datum + zkonvertuji na přijatelný formát
            if (columnName == "time_in")
            {
                inorout = "time_in";

                if (celldata0Begin == "")
                {
                    MessageBox.Show("Zde není co editovat !");
                    e.Cancel = true;
                    dataGrid_INOUT.EndEdit();
                    return;
                }

                celldataDate = DateTime.Parse(celldata0Begin);
                celldata0Begin = celldataDate.ToString("yyyy-MM-dd HH:mm:ss");
                celldata0End = celldata0Begin;
            }
            else if (columnName == "time_out")
            {
                inorout = "time_out";

                if (celldata1Begin == "")
                {
                    MessageBox.Show("Zde není co editovat !");
                    e.Cancel = true;
                    dataGrid_INOUT.EndEdit();
                    return;
                }

                celldatavpravoDate = DateTime.Parse(celldata1Begin);
                celldata1Begin = celldatavpravoDate.ToString("yyyy-MM-dd HH:mm:ss");
                celldata1End = celldata1Begin;
            }

            if (celldata1Begin != "")
            {
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

                    celldataDate = DateTime.Parse(celldata0Begin);
                    celldata0Begin = celldataDate.ToString("yyyy-MM-dd HH:mm:ss");
                    celldata0End = celldata0Begin;
                    celldatavpravoDate = DateTime.Parse(celldata1Begin);
                    celldata1Begin = celldatavpravoDate.ToString("yyyy-MM-dd HH:mm:ss");
                    celldata1End = celldata1Begin;

                    // Musim zjistit ID_t vybraného záznamu
                    command.CommandText = "SELECT ID_t FROM Time WHERE time_in='" + celldata0Begin + "' AND time_out = '" + celldata1Begin + "' ;";
                    id_time = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_time = reader.GetInt32(0);
                        }
                    }

                    // Musim zjistit ID_login vybraného člověka pro v metodě CellEndEdit 'work_minutes_total'
                    command.CommandText = "SELECT ID_login FROM Time WHERE time_in='" + celldata0Begin + "' AND time_out = '" + celldata1Begin + "' ;";
                    id_login = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_login = reader.GetInt32(0);
                        }
                    }

                    connection.Close();
                }
            }

        }

        private void dataGrid_INOUT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                // Potřebuji zjistit zeditovanou hodnotu a nahradit starou -
                // Pošlu nové datum na UPDATE, podle toho, jaký je to sloupec
                if( inorout == "time_in")
                {
                    // Uložím zeditovaný cell ( 0 = time_in, 1 = time_out ) + konvertuji do správného formátu
                    celldata0End = dataGrid_INOUT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DateTime celldataDate = DateTime.Parse(celldata0End);
                    celldata0End = celldataDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Vložím nové 'time_in', pokud se shoduje 'time_out' (1) a 'id_time'
                    command.CommandText = "UPDATE Time SET time_in = '" + celldata0End + "' WHERE ID_t='" + id_time + "' ;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        }
                    }
                    MessageBox.Show("Čas úspěšně změněn!\nPřed : " + celldata0Begin + " | " + celldata1Begin + "\nPoté : " + celldata0End + " | " + celldata1End );
                }
                else if (inorout == "time_out")
                {
                    // Uložím zeditovaný cell ( 0 = time_in, 1 = time_out ) + konvertuji do správného formátu
                    celldata1End = dataGrid_INOUT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DateTime celldataDate = DateTime.Parse(celldata1End);
                    celldata1End = celldataDate.ToString("yyyy-MM-dd HH:mm:ss");

                    // Vložím nové 'time_out', pokud se shoduje 'time_in' (1) a 'id_time' s starými
                    command.CommandText = "UPDATE Time SET time_out = '" + celldata1End + "' WHERE ID_t='" + id_time + "' ;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        }
                    }
                    MessageBox.Show("Čas úspěšně změněn!\nPřed : " + celldata0Begin + " | " + celldata1Begin + "\nPoté : " + celldata0End + " | " + celldata1End);
                }

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

                connection.Close();

            }

        }

        
    }
}

