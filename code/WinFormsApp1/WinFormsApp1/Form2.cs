using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
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
                string sql = "select * from dnp3_protocol";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadMaster_Click(object sender, EventArgs e)
        {
            LoadData("dnp3_protocol");
        }

        private void AddMaster_Click(object sender, EventArgs e) //uncomplete
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string Protocol = textBox2.Text;
                    int Id;

                    if (int.TryParse(textBox3.Text, out Id))
                    {
                        // Id is successfully parsed to an integer
                        string query = "INSERT INTO dnp3_protocol (PointName, PointType, PointId) VALUES (@Name, @Protocol, @Id)";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Protocol", Protocol);
                        command.Parameters.AddWithValue("@Id", Id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully!");
                            LoadData("dnp3_protocol");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMaster_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string NewProtocol = textBox2.Text;
                    int ID;

                    if (int.TryParse(textBox3.Text, out ID))
                    {
                        // Id is successfully parsed to an integer
                        string query = "UPDATE dnp3_protocol SET PointType = @NewProtocol WHERE PointName = @Name AND PointId = @ID";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@NewProtocol", NewProtocol);
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            LoadData("dnp3_protocol");
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

        private void DeleteMaster_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Tvd@2020;database=data_table";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();

                    string Name = textBox1.Text;
                    string Protocol = textBox2.Text;
                    int ID;

                    if (int.TryParse(textBox3.Text, out ID))
                    {
                        // Id is successfully parsed to an integer
                        string query = "DELETE FROM dnp3_protocol where PointName=@Name AND PointType=@Protocol AND PointId=@ID";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Protocol", Protocol);
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                            LoadData("dnp3_protocol");
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
    }
}
