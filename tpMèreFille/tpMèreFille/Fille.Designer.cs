namespace tpMèreFille
{
    partial class Fille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChangeNom = new System.Windows.Forms.Label();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.tbChangeNom = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeNom
            // 
            this.lblChangeNom.AutoSize = true;
            this.lblChangeNom.Location = new System.Drawing.Point(10, 51);
            this.lblChangeNom.Name = "lblChangeNom";
            this.lblChangeNom.Size = new System.Drawing.Size(101, 13);
            this.lblChangeNom.TabIndex = 0;
            this.lblChangeNom.Text = "je change de nom : ";
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(159, 130);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 1;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // tbChangeNom
            // 
            this.tbChangeNom.Location = new System.Drawing.Point(117, 48);
            this.tbChangeNom.Name = "tbChangeNom";
            this.tbChangeNom.Size = new System.Drawing.Size(164, 20);
            this.tbChangeNom.TabIndex = 2;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(313, 51);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 3;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // Fille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.tbChangeNom);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.lblChangeNom);
            this.Name = "Fille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeNom;
        private System.Windows.Forms.Button btnMaMere;
        private System.Windows.Forms.TextBox tbChangeNom;
        private System.Windows.Forms.Button btnChanger;
    }
}