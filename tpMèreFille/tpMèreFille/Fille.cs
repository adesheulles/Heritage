using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tpMèreFille
{
    public partial class Fille : Form
    {
        private string monNom;
        private Mere maMere;

        public Fille(Mere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            btnMaMere.Click += new EventHandler(btnMaMere_Click);
            this.FormClosing += new FormClosingEventHandler(Fille_FormClosing);
            this.Load += new EventHandler(Fille_Load);
            btnChanger.Click += new EventHandler(btnChanger_Click);
            tbChangeNom.TextChanged += new EventHandler(btnChanger_Click);
        }

        void btnChanger_Click(object sender, EventArgs e)
        {
            this.monNom = tbChangeNom.Text;
            maMere.MaFilleChangeDeNom(this, this.monNom);
            this.Text = tbChangeNom.Text;
        }

        void Fille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur" + this.monNom);
        }

        void Fille_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.maMere.GetNomMere);
        }
    }
}
