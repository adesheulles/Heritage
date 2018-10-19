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
    public partial class Mere : Form
    {
        private List<Fille> lesFilles;
        private int nombreFille;
        private string nomMere;
        public Mere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles=new List<Fille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click +=new EventHandler(btnNew_Click_Message);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            
        }
        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("une fenêtre fille a été instanciée");
        }
        void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
                this.lesFilles.RemoveAt(lbLesFilles.SelectedIndex);   
                this.lbLesFilles.Items.RemoveAt(lbLesFilles.SelectedIndex);
                             
            }
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            Fille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new Fille(this,nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }
        
        public string GetNomMere{get{return this.nomMere;}}
        public void MaFilleChangeDeNom(Fille fille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(fille);
            if (position != -1)
            {
                lesFilles[position] = fille;
                lbLesFilles.Items[position] = nouveauNom;
            }
        }

    }
}
