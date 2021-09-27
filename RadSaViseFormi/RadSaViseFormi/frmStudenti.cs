using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaViseFormi
{
    public partial class FrmStudenti : Form
    {
        public FrmStudenti()
        {
            InitializeComponent();
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            frmUnosNovogStudenta myForm = new frmUnosNovogStudenta();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
