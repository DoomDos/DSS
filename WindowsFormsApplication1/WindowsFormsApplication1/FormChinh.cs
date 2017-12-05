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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTruong_Click(object sender, EventArgs e)
        {
            var formTruong = new FormTruong();
            formTruong.ShowDialog();
         
        }

        private void buttonTroGiup_Click(object sender, EventArgs e)
        {
            var formTuVan = new FormTuVan();
            formTuVan.ShowDialog();

        }
    }
}
