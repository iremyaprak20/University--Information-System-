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
using System.IO;

namespace UniversitySystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();

        void list()
        {
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from students ", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            list();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into students (student_id, student_name, student_surname, student_dept, year) values(@p1,@p2,@p3,@p4,@p5)", bgl.connection());
            command.Parameters.AddWithValue("@p1", textid.Text);
            command.Parameters.AddWithValue("@p2", textEdit4.Text);
            command.Parameters.AddWithValue("@p3", textEdit3.Text);
            command.Parameters.AddWithValue("@p4", textEdit1.Text);
            command.Parameters.AddWithValue("@p5", textEdit2.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Student Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
    }
}
