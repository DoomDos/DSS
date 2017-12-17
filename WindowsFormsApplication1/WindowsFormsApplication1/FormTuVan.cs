using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTuVan : Form
    {
        public FormTuVan()
        {
            InitializeComponent();
        }
        string id;
        string nam;
        int temp;
        private string ketnoicsdl(string id, string nam)
        {
            // Lấy dữ liệu trường theo mã trường
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id + "' AND Truong.MaTruong='" + id + "' AND TuyenSinh.Nam = '" + nam + "'";
            DataTable thamchieu = ExcuteSql.connectDB(sql);
            if (thamchieu.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return thamchieu.Rows[0][4].ToString();
            }
        }
        private DataTable ketnoicsdlMa(string id)
        {
            string sql = "select TuyenSinh.* from TuyenSinh where TuyenSinh.MaTruong='" + id + "'";
            DataTable check = ExcuteSql.connectDB(sql);
            if (check.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return check;
            }
        }
        private DataTable ketnoicsdlTen(string id)
        {
            string sql = "select MaTruong from Truong where TenTruong = N'" + id + "'";
            return ExcuteSql.connectDB(sql);
        }
        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuVan_Load(object sender, EventArgs e)
        {
            comboBoxTuVan.SelectedIndex = 0;
        }

        private void textBoxTruong_TextChanged(object sender, EventArgs e)
        {
            /*String sql;
            if (comboBoxTuVan.SelectedIndex == 0)
            {

                sql = "select * from Truong where MaTruong like '%" + textBoxTruong.Text + "%'";  // lay het du lieu trong bang truong                
            }
            else
            {
                sql = "select * from Truong where TenTruong like N'%" + textBoxTruong.Text + "%'";  // lay het du lieu trong bang truong 
            }

            SqlDataReader dr = ExcuteSql.excuteSqlReader(sql);

            AutoCompleteStringCollection autoCom = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                if (comboBoxTuVan.SelectedIndex == 0)
                    autoCom.Add(dr.GetString(0));
                else
                    autoCom.Add(dr.GetString(1));
            }
            
            textBoxTruong.AutoCompleteCustomSource = autoCom;

            dr.Close();
            */

        }
        private string ketqua(string id, string nam)
        {
            if (string.IsNullOrEmpty(id))
                MessageBox.Show("Chưa nhập mã trường hoặc tên trường");
            else if (string.IsNullOrEmpty(nam))
                MessageBox.Show("Chưa nhập năm dự báo");
            else if(ketnoicsdlMa(id) == null || !(Regex.IsMatch(nam, @"^\d+$")) || !(int.Parse(textBoxNam.Text) >= 2013) )
                MessageBox.Show("Kiểm tra lại thông tin đã nhập");
            else
            {
                if (ketnoicsdl(id, nam) == null)
                {
                    DataTable tb = ketnoicsdlMa(id);
                    int n = tb.Rows.Count;
                    double sl, a = 0, dudoanM = int.Parse(tb.Rows[0][3].ToString()), dudoanC = int.Parse(tb.Rows[0][3].ToString());
                    for (int i = 2; i <= n; i++)
                    {
                        sl = int.Parse(tb.Rows[i - 1][3].ToString());
                        dudoanM += (sl - dudoanC);
                        if (sl - dudoanC != 0)
                            a += (dudoanM - dudoanC) / (sl - dudoanC);
                        else
                            a += 0;
                        dudoanC = dudoanM;
                    }
                    a = a / n;
                    if (a != 0)
                    {
                        dudoanC = int.Parse(tb.Rows[0][3].ToString());
                        sl = int.Parse(tb.Rows[1][3].ToString());
                        for (int i = 2; i <= (int.Parse(nam) - 2013 + 1); i++)
                        {
                            dudoanM = dudoanC + a * (sl - dudoanC);
                            dudoanC = dudoanM;
                            try
                            {
                                sl = int.Parse(tb.Rows[i - 1][3].ToString());
                            }
                            catch
                            {
                                sl += (dudoanM - dudoanC);
                            }

                        }
                    }
                    return dudoanM.ToString();
                }
                else
                {
                    return ketnoicsdl(id, nam);
                }
            }
            return null;
        }

        private void buttonTuVan_Click(object sender, EventArgs e)
        {
            nam = textBoxNam.Text;
            if (comboBoxTuVan.SelectedIndex == 0)
            {
                id = textBoxTruong.Text;
            }
            else
            {
                string id1 = textBoxTruong.Text;
                DataTable tb = ketnoicsdlTen(id1);
                id = tb.Rows[0][0].ToString();
            }
            labelKetQua.Text = ketqua(id, nam);
        }

    }
}
