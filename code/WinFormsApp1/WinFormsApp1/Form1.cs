using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI.Relational;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            button2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.f1 = this;
            // f3.ShowDialog();
            f3.Show();
            button3.Enabled = false;

        }
    }
}