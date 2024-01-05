using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyrapphim
{
    public partial class Form1 : Form

    {
        quanlyrapphimEntities2 db = new quanlyrapphimEntities2();
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            listView1.Items.Clear();
            var dl = from c in db.quanlyphims
                     select new
                     {
                         MADON = c.Madon,
                         TENPHIM = c.Tenphim,
                         QUOCGIA = c.Quocgia,
                         THELOAI = c.Theloai,
                         NCC = c.Ngaycongchieu,
                         DTQD = c.Dotuoiquidinh,
                         PTGD = c.phim2d.Phuthughedoi,
                         PTSCDB = c.phim3d.Phuthusuatchieudacbiet,
                     };
            foreach (var phim in dl)
            {
                ListViewItem lv = new ListViewItem(phim.MADON);
                lv.SubItems.Add(phim.TENPHIM);
                lv.SubItems.Add(phim.QUOCGIA);
                lv.SubItems.Add(phim.THELOAI);
                lv.SubItems.Add(phim.NCC.Value.ToShortDateString());
                lv.SubItems.Add(phim.DTQD.ToString());
                lv.SubItems.Add(phim.PTGD.ToString());
                lv.SubItems.Add(phim.PTSCDB.ToString());
                listView1.Items.Add(lv);



            }


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn thoát ", "xác nhận thoát ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rb2d_CheckedChanged(object sender, EventArgs e)
        {
            txtptgd.Visible = true;
            lbptgd.Visible = true;
            txtptscdb.Visible = false;
            lbptscdb.Visible = false;


        }

        private void rb3d_CheckedChanged(object sender, EventArgs e)
        {

            txtptgd.Visible = false;
            lbptgd.Visible = false;
            txtptscdb.Visible = true;
            lbptscdb.Visible = true;
        }

        void reset()
        {
            txtmadon.Clear();
            txttenphim.Clear();
            txtquocgia.Clear();
            rbtc.Checked = true;
            datenvl.Value = DateTime.Now;
            rb2d.Checked = true;
            txtdtqd.Clear();
            txtptgd.Clear();
            txtptscdb.Clear();
            txtmadon.Focus();
        }
        private void them_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmadon.Text) || string.IsNullOrEmpty(txtquocgia.Text) || string.IsNullOrEmpty(txttenphim.Text) || string.IsNullOrEmpty(txtdtqd.Text))
            {
                MessageBox.Show("nhập đầy đủ thông tin");
                return;
            }
            if (rb2d.Checked)
            {
                if (string.IsNullOrEmpty(txtdtqd.Text))
                {
                    MessageBox.Show("nhập đầy đủ thông tin");
                    return;
                }
            }
            if (rb3d.Checked)
            {
                if (string.IsNullOrEmpty(txtptscdb.Text))
                {
                    MessageBox.Show("nhập đầy đủ thông tin");
                    return;
                }
            }
            quanlyphim phim = new quanlyphim
            {
                Madon = txtmadon.Text,
                Theloai = rbtc.Checked ? "tình cảm" : "hành động",
                Tenphim = txttenphim.Text,
                Quocgia = txtquocgia.Text,
                Ngaycongchieu = datenvl.Value
            };
            db.quanlyphims.Add(phim);
            if (string.IsNullOrEmpty(DTQD.Text))
            {
                MessageBox.Show("Vui lòng nhập độ tuổi quy định.");
                return;
            }

            int dotuoiquidinh;
            if (int.TryParse(DTQD.Text, out dotuoiquidinh))
            {
                phim.Dotuoiquidinh = dotuoiquidinh;
            }

            db.quanlyphims.Add(phim);
            if (rb2d.Checked)
            {
                phim2d phim2D = new phim2d
                {
                    Madon = phim.Madon,
                    Phuthughedoi = double.Parse(txtptgd.Text)

                };
                db.phim2d.Add(phim2D);

            }
            if (rb3d.Checked)
            {
                phim3d phim3D = new phim3d
                {
                    Madon = phim.Madon,
                    Phuthusuatchieudacbiet = double.Parse(txtptscdb.Text)

                };
                db.phim3d.Add(phim3D);

            }
            db.SaveChanges();

            loaddata();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("bạn có chắc chắn muốn xóa ", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Madon = listView1.SelectedItems[0].SubItems[0].Text;
                    quanlyphim phim = db.quanlyphims.FirstOrDefault(c => c.Madon == Madon);
                    if (phim != null)
                    {
                        db.quanlyphims.Remove(phim);
                        phim2d phim2D = db.phim2d.FirstOrDefault(c => c.Madon == Madon);
                        if (phim2D != null)
                        {
                            db.phim2d.Remove(phim2D);
                        }
                        phim3d phim3D = db.phim3d.FirstOrDefault(c => c.Madon == Madon);
                        if (phim3D != null)
                        {
                            db.phim3d.Remove(phim3D);
                        }
                        db.SaveChanges();
                        loaddata();
                    }
                };
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];
                txtmadon.Text = lv.SubItems[0].Text;
                txttenphim.Text = lv.SubItems[1].Text;
                txtquocgia.Text = lv.SubItems[2].Text;
                if (lv.SubItems[3].Text == "tình cảm")
                {
                    rbtc.Checked = true;
                }
                else if (lv.SubItems[3].Text == "hành động")
                {
                    rbhd.Checked = true;
                }
                DateTime d;
                if (DateTime.TryParseExact(lv.SubItems[4].Text, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
                {
                    datenvl.Value = d;
                }
                txtdtqd.Text = lv.SubItems[5].Text;
                if (string.IsNullOrEmpty(lv.SubItems[6].Text))
                {
                    rb3d.Checked = true;
                    txtptscdb.Text = lv.SubItems[7].Text;
                }
                if (string.IsNullOrEmpty(lv.SubItems[7].Text))
                {
                    rb2d.Checked = true;
                    txtptgd.Text = lv.SubItems[6].Text;
                }

            }
        }

        private void sapxep_Click(object sender, EventArgs e)
        {

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kiểm tra số lượng phần tử trong SubItems
                if (selectedItem.SubItems.Count >= 6)
                {
                    // Cập nhật thông tin trong ListViewItem
                    selectedItem.SubItems[0].Text = txtmadon.Text;
                    selectedItem.SubItems[1].Text = txttenphim.Text;
                    selectedItem.SubItems[2].Text = txtquocgia.Text;
                    selectedItem.SubItems[3].Text = rbtc.Checked ? "tình cảm" : "hành động";
                    selectedItem.SubItems[4].Text = datenvl.Value.ToString("M/d/yyyy");
                    selectedItem.SubItems[5].Text = txtdtqd.Text;


                }


                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                }
            }


            //ncc tăng độ tuổi qui định giảm dần
        }
    }
}