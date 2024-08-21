using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trang_52
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhSach.SelectedItems.Count-1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = lbDanhSachChon.SelectedItems.Count-1;
            while (i >= 0)
            {
                lbDanhSachChon.Items.RemoveAt(lbDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }

        private void lbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
