using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trang_48
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.cboNgoaiNgu.DataSource = datas;
        }
        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
        }
    }
}
