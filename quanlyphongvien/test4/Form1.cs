using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test4
{

    public partial class Form1 : Form
    {
        phongvienEntities db = new phongvienEntities();
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            listView1.Items.Clear();
            var dl = from c in db.x
                     select new
                     {
                         MANV = c.Manv,
                         HOTEN = c.Hoten,
                         GIOITINH = c.Gioitinh,
                         DIENTHOAI = c.Dienthoai,
                         NVL = c.Ngayvaolam,
                         PHUCAP = c.phongvienthuongtru.Phucap,
                         SGLT = c.phongvientaitoasoan.Sogiolamthem,
                     };
            foreach (var c in dl)
            {
                ListViewItem lv = new ListViewItem(c.MANV);
                lv.SubItems.Add(c.HOTEN);
                lv.SubItems.Add(c.GIOITINH);
                lv.SubItems.Add(c.DIENTHOAI);
                lv.SubItems.Add(c.NVL.Value.ToShortTimeString());
                TimeSpan d = DateTime.Now - c.NVL.Value;
                if(d.TotalDays > 5 *365)
                {
                    lv.BackColor = Color.Yellow;
                }    
                lv.SubItems.Add(c.SGLT.ToString());
                lv.SubItems.Add(c.PHUCAP.ToString());
                
                listView1.Items.Add(lv);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("có chắc muốn thoát", "xác nhận thoát ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rbtts_CheckedChanged(object sender, EventArgs e)
        {
            lbsglt.Visible = true;
            txtsglt.Visible = true;
            lbpc.Visible = false;
            txtpc.Visible = false;
        }

        private void rbtt_CheckedChanged(object sender, EventArgs e)
        {
            lbsglt.Visible = false;
            txtsglt.Visible = false;
            lbpc.Visible = true;
            txtpc.Visible = true;
        }
        void reset()
        {
            txtmanv.Clear();
            txtdienthoai.Clear();
            txthoten.Clear();
            txtpc.Clear();
            txtsglt.Clear();
            datenvl.Value = DateTime.Now;
            rbnam.Checked = true;
            rbtt.Checked = true;
            txtmanv.Focus();
        }
        private void them_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void luu_Click(object sender, EventArgs e)


        {
            if (string.IsNullOrEmpty(txthoten.Text)|| string.IsNullOrEmpty(txtdienthoai.Text)|| string.IsNullOrEmpty(txtmanv.Text)) 
            {
                MessageBox.Show("nhập thông tin đầy đủ");
                return;
            
            }
            if (datenvl.Value > DateTime.Now)
            {
                MessageBox.Show("ngày vào làm không được lớn hơn ngày hiện tại");
                return;
            }
            if (rbtt.Checked) 
            {
                if(string.IsNullOrEmpty(txtpc.Text))
                {
                    MessageBox.Show("dữ liệu không được bỏ trống");
                    return;
                }
            }
            if (rbtts.Checked)
            {
                if (string.IsNullOrEmpty(txtsglt.Text))
                {
                    MessageBox.Show("dữ liệu không được bỏ trống");
                    return;
                }
            }

            x pv = new x
            {
                Manv = txtmanv.Text,
                Dienthoai = txtdienthoai.Text,
                Hoten = txthoten.Text,
                Gioitinh = rbnam.Checked ? "nam" : "nư",
                Ngayvaolam = datenvl.Value,

            };
            db.x.Add(pv);
            if (rbtt.Checked)
            {
                phongvienthuongtru pvtt = new phongvienthuongtru
                {
                    Manv = pv.Manv,
                    Phucap = double.Parse(txtpc.Text),
                };
                db.phongvienthuongtrus.Add(pvtt);

            }
            if (rbtts.Checked)
            {
                phongvientaitoasoan pvtts = new phongvientaitoasoan
                {
                    Manv = pv.Manv,
                    Sogiolamthem = int.Parse(txtsglt.Text),
                };
                db.phongvientaitoasoans.Add(pvtts);

            }
            int ktr = db.SaveChanges();
            loaddata();

        }
        

        private void xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("bạn có chắc chắn muốn xóa ", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Manv = listView1.SelectedItems[0].SubItems[0].Text;
                    x pv = db.x.FirstOrDefault(c=>c.Manv == Manv);
                    if (pv != null)
                    {
                        db.x.Remove(pv);
                        phongvientaitoasoan pvtts = db.phongvientaitoasoans.FirstOrDefault(c=>c.Manv == Manv);
                        if(pvtts != null)
                        {
                            db.phongvientaitoasoans.Remove(pvtts);
                        }
                        phongvienthuongtru pvtt = db.phongvienthuongtrus.FirstOrDefault(c => c.Manv == Manv);
                        if (pvtt != null)
                        {
                            db.phongvienthuongtrus.Remove(pvtt);
                        }
                        db.SaveChanges();
                        loaddata();
                    }
                    
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];
                txtmanv.Text = lv.SubItems[0].Text;
                txthoten.Text = lv.SubItems[1].Text;
                if (lv.SubItems[2].Text=="nam")
                {
                    rbnam.Checked = true;
                }    
                else if (lv.SubItems[2].Text == "nữ")
                {
                    rbnu.Checked = true;
                }    
                txtdienthoai.Text = lv.SubItems[3].Text;
                DateTime d;
                if (DateTime.TryParseExact(lv.SubItems[4].Text,"M/d/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out d))
                {
                    datenvl.Value = d;
                }
                if (string.IsNullOrEmpty(lv.SubItems[5].Text))
                {
                    rbtt.Checked = true;
                    txtpc.Text = lv.SubItems[6].Text;
                }
                if (string.IsNullOrEmpty(lv.SubItems[6].Text))
                {
                    rbtts.Checked = true;
                    txtsglt.Text = lv.SubItems[5].Text;
                }
            }    
        }

        private void sapxep_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var dl = from c in db.x
                     orderby c.Ngayvaolam descending, c.Hoten ascending
                     select new
                     {
                         MANV = c.Manv,
                         HOTEN = c.Hoten,
                         GIOITINH = c.Gioitinh,
                         DIENTHOAI = c.Dienthoai,
                         NVL = c.Ngayvaolam.Value,
                         SGLT = c.phongvientaitoasoan.Sogiolamthem,
                         PHUCAP = c.phongvienthuongtru.Phucap
                     };
            foreach ( var c in dl )
            {
                ListViewItem lv = new ListViewItem(c.MANV);
                lv.SubItems.Add(c.HOTEN);
                lv.SubItems.Add(c.GIOITINH);
                lv.SubItems.Add(c.DIENTHOAI);
                lv.SubItems.Add(c.NVL.ToShortTimeString());
                lv.SubItems.Add(c.SGLT.ToString());
                lv.SubItems.Add(c.PHUCAP.ToString());
                listView1.Items.Add(lv);



            }

        }
    }
}
