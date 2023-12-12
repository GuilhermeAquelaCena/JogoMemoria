using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void Facil_Click(object sender, EventArgs e)
        {            
            FormFacil frf = new FormFacil();
            frf.ShowDialog();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            FormNormal frn = new FormNormal();
            frn.ShowDialog();
        }

        private void Troll_Click(object sender, EventArgs e)
        {
            FormTroll frt = new FormTroll();
            frt.ShowDialog();
        }
    }
}
