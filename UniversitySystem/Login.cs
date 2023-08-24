using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversitySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        sqlconnection bgl = new sqlconnection();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select instructer_tc, instructer_password from Settings inner join instructers on Setting.Settings_id= instructers.instructer_id where instructer_tc=@p1 and instructer_password=@p2 ", bgl.connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MainMenu frm1 = new MainMenu();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User or Password");
                maskedTextBox1.Text = "";
                maskedTextBox1.Text = "";

            }
            bgl.connection().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select instructer_tc, instructer_password from Settings inner join instructers on Setting.Settings_id= instructers.instructer_id where instructer_tc=@p1 and instructer_password=@p2 ", bgl.connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MainMenu frm1 = new MainMenu();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User or Password");
                maskedTextBox1.Text = "";
                maskedTextBox1.Text = "";

            }
            bgl.connection().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            private void button2_Click(object sender, EventArgs e)
            {
                SqlCommand command = new SqlCommand("Select instructer_tc, instructer_password from Settings inner join instructers on Setting.Settings_id= instructers.instructer_id where instructer_tc=@p1 and instructer_password=@p2 ", bgl.connection());
                command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MainMenu frm1 = new MainMenu();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong User or Password");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Text = "";

                }
                bgl.connection().Close();
            }
    }
}
