using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public dnp3types.eServerConnectionStatus peSat= dnp3types.eServerConnectionStatus.SERVER_NOTCONNECTED;
        public Form1 f1;
        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData(string table)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "select * from ";
                sql = sql + table;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddData()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string Protocol = textBox3.Text;
                    int Id;

                    if (int.TryParse(textBox2.Text, out Id))
                    {
                        // Id is successfully parsed to an integer
                        string query = "INSERT INTO rtu (Name, Protocol, Id) VALUES (@Name, @Protocol, @Id)";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Protocol", Protocol);
                        command.Parameters.AddWithValue("@Id", Id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully!");
                            LoadData("rtu");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer value for Id.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void DeleteData()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string Protocol = textBox3.Text;
                    int ID;

                    if (int.TryParse(textBox2.Text, out ID))
                    {
                        // Id is successfully parsed to an integer
                        string query = "DELETE FROM rtu where Name=@Name AND Protocol=@Protocol AND Id=@ID";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Protocol", Protocol);
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                            LoadData("rtu");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer value for Id.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void UpgradeData()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string NewProtocol = textBox3.Text;
                    int ID;

                    if (int.TryParse(textBox2.Text, out ID))
                    {
                        // Id is successfully parsed to an integer
                        string query = "UPDATE rtu SET Protocol = @NewProtocol WHERE Name = @Name AND Id = @ID";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@NewProtocol", NewProtocol);
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            LoadData("rtu");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer value for Id.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData("rtu");
        }

        private void AddRTU_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DelRTU_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void UpgradeRTU_Click(object sender, EventArgs e)
        {
            UpgradeData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start_Communication_Click(object sender, EventArgs e)
        {
            try
            {
                // Loading data
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = "select * from dnp3_protocol";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;

                // Connection
                peSat = f1.conn();
                if (peSat == dnp3types.eServerConnectionStatus.SERVER_CONNECTED)
                    MessageBox.Show("Server Connected");
                else
                    MessageBox.Show("Server not Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
