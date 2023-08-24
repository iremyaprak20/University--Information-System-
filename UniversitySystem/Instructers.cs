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
    public partial class Instructers : Form
    {
        public Instructers()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();

        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from instructers", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
                                                          
        }
        void getdept()
        {
            SqlCommand command = new SqlCommand("Select * from departments", bgl.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbdept.Properties.Items.Add(dr[1]);
            }
            bgl.connection().Close();
        }

         private void Instructers_Load(object sender, EventArgs e)
        {
            list();
            getdept();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into instructers (instructer_name, instructer_surname, instructer_tc, instructer_phone, instructer_mail, instructer_dept) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.connection());
            command.Parameters.AddWithValue("@p1", textname.Text);
            command.Parameters.AddWithValue("@p2", textsurname.Text);
            command.Parameters.AddWithValue("@p3", msktc.Text);
            command.Parameters.AddWithValue("@p4", msknumber.Text);
            command.Parameters.AddWithValue("@p5", textmail.Text);
            command.Parameters.AddWithValue("@p6", cmbdept.Text);
            bgl.connection().Close();
            MessageBox.Show("Instructer Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!= null)
            {
                txtid.Text = dr["instructer_id"].ToString();
                textname.Text = dr["instructer_name"].ToString();
                textsurname.Text = dr["instructer_surname"].ToString();
                textmail.Text = dr["instructer_mail"].ToString();
                msknumber.Text = dr["instructer_phone"].ToString();
                msktc.Text = dr["instructer_tc"].ToString();
                cmbdept.Text = dr["instructer_name"].ToString();
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update instructers set instructer_name= @p1, instructer_surname= @p2, instructer_tc= @p3, instructer_phone= @p4, instructer_mail= @p5, instructer_dept= @p6 where instructer_id=@p7", bgl.connection());
            command.Parameters.AddWithValue("@p1", textname.Text);
            command.Parameters.AddWithValue("@p2", textsurname.Text);
            command.Parameters.AddWithValue("@p3", msktc.Text);
            command.Parameters.AddWithValue("@p4", msknumber.Text);
            command.Parameters.AddWithValue("@p5", textmail.Text);
            command.Parameters.AddWithValue("@p6", cmbdept.Text);
            command.Parameters.AddWithValue("@p7", txtid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Instructer Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
    }
}
