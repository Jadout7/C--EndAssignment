using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EndAssignment
{
    public partial class Main : Form
    {
        Championship championship = new Championship();

        public Main()
        {
            Thread t = new Thread(new ThreadStart(Splashsc));
            t.Start();
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1; 
            Thread.Sleep(5000);
            t.Abort();
        }

        public void Splashsc()
        {
            Application.Run(new Splash());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = "C# End Assignment";
            dateTimePicker1.CustomFormat = "mm:ss:hh";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true; 
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            String output = "";
            output += "Player Number: " + textBox1.Text + "\x0A";
            output += "Player Name: " + Pname.Text + "\xA";
            output += "Age: " + textBox2.Text + "\n";
            output += "Nationality: " + textBox3.Text + "\n";

            MessageBox.Show(output);
            
            string server = "localhost";
            string database = "Skater";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database
                + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);

            conn.Open();

            string query = "INSERT INTO player (Number, Name, Age, Nationality) VALUES (@Number, @Name, @Age, @Nationality)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("Number", textBox1.Text); 
            cmd.Parameters.AddWithValue("Name", Pname.Text);
            cmd.Parameters.AddWithValue("Age", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("Nationality", textBox3.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            comboBox2.Items.Add(Pname.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String output = "";
            output += "Player Name: " + comboBox2.Text + "\x0A";
            output += "Distance: " + comboBox1.Text + "\xA";
            output += "Time: " + dateTimePicker1.Text + "\n";

            MessageBox.Show(output);

            string server = "localhost";
            string database = "Skater";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database
                + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);

            conn.Open();

            string query = "INSERT INTO race (Name, Distance, Time) VALUES (@Name, @Distance, @Time)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("Name", comboBox2.Text);
            cmd.Parameters.AddWithValue("Distance", comboBox1.Text);
            cmd.Parameters.AddWithValue("Time", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonWinner_Click(object sender, EventArgs e)
        {
            label3.Text = "The player who wins the Skating Championship is: \n" + championship.getWinner();
        }

        private void buttonPoints_Click(object sender, EventArgs e)
        {
            label4.Text = "The winner of the championship has \n" + championship.getWinnerPoints() + " points in total.";
        }
    }
}
