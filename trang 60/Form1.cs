using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trang_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
                if (this.clbMonHoc.GetItemChecked(i) == true)
                    s += this.clbMonHoc.Items[i].ToString() + ",";
            MessageBox.Show("Danh sach mon hoc: " + s);
        }
    }
}
