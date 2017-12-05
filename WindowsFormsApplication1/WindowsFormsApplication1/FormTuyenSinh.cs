using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTuyenSinh : Form
    {
        public FormTuyenSinh()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            var formTuyenSinhThem = new FormTuyenSinhThem();
            formTuyenSinhThem.ShowDialog();
        }
    }
}
