using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class EUL : Form
    {
        public EUL()
        {
            InitializeComponent();
        }

        private void EUL_Load(object sender, EventArgs e)
        {

        }

        Instructers inst;


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (inst == null || inst.IsDisposed) { 
            inst = new Instructers();
            inst.MdiParent = this;
            inst.Show();
            }
        }

        Students std;

        private void btnsdt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (std == null || std.IsDisposed)
            {
               std = new Students();
               std.MdiParent = this;
               std.Show();
            }
        }
    }
}
