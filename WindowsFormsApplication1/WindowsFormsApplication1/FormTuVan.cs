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
    public partial class FormTuVan : Form
    {
        public FormTuVan()
        {
            InitializeComponent();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuVan_Load(object sender, EventArgs e)
        {
            comboBoxTuVan.SelectedIndex = 0;
        }
    }
}
