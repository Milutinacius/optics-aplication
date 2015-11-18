namespace Optika_No_1
{
    partial class ConnectionDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDefinition));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPutanja = new System.Windows.Forms.TextBox();
            this.btPotvrdi = new System.Windows.Forms.Button();
            this.btLokacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite putanju";
            // 
            // tbPutanja
            // 
            this.tbPutanja.Location = new System.Drawing.Point(17, 33);
            this.tbPutanja.Name = "tbPutanja";
            this.tbPutanja.Size = new System.Drawing.Size(406, 26);
            this.tbPutanja.TabIndex = 1;
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(17, 76);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(100, 32);
            this.btPotvrdi.TabIndex = 2;
            this.btPotvrdi.Text = "Potvrdi";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // btLokacija
            // 
            this.btLokacija.Location = new System.Drawing.Point(433, 33);
            this.btLokacija.Name = "btLokacija";
            this.btLokacija.Size = new System.Drawing.Size(36, 29);
            this.btLokacija.TabIndex = 3;
            this.btLokacija.Text = ". . .";
            this.btLokacija.UseVisualStyleBackColor = true;
            this.btLokacija.Click += new System.EventHandler(this.btLokacija_Click);
            // 
            // ConnectionDefinition
            // 
            this.AcceptButton = this.btPotvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 116);
            this.Controls.Add(this.btLokacija);
            this.Controls.Add(this.btPotvrdi);
            this.Controls.Add(this.tbPutanja);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConnectionDefinition";
            this.Text = "Optika Vanja - Nova lokacija baze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionDefinition_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPutanja;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.Button btLokacija;
    }
}