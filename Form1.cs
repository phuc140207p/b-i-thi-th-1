using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_thi_thử1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            String hovaten = "nguyễn văn A";
            String mssv = "5164495456";
            String monthi = "lập trình windows 2 - C#";

            lblInfo.Text = "họ và tên: " + hovaten;
            lblInfo.Text += "\nMSSV: " + mssv;
            lblInfo.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\nMôn thi: " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chương trình tiện ích", "thông tin");
        }

        private void giảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaiphuongtrinhbat2 gpt = new Giaiphuongtrinhbat2();
            gpt.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinhdang dinhdang = new Dinhdang();
            dinhdang.Show();
        }
    }
}
