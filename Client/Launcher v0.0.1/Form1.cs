using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Launcher_v0._0._1
{
    public partial class Form1 : Form
    {

        Font MyFont;
        public Form1()
        {
            InitializeComponent();
           
            background.Focus();
        }

        
        private void background_Click(object sender, EventArgs e)
        {
            background.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=***;user=***;database=***;port=***;password=***";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string nick = textBox1.Text;
                string pass = textBox2.Text;

                string sql = "SELECT * FROM `***` WHERE `nickname` = '"+nick+"' AND `pass` = '"+pass+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Nice");


                }
                else
                {
                    MessageBox.Show("�������� ����� ��� ������", "������!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        // ��� ����� ���� �� �������� � �� ������ ����� ���� �� ������ ����
     


        private void Registration_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://yukkamc.ru");
            }
            catch
            {
                MessageBox.Show("��������, � ���� ��������� ���-�� �� ���.\n��������� ����� ��� ��������� �� ������ �������\nhttps://yukkamc.ru", "������!");
               
            }
        }
    }
}