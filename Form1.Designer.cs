namespace AplikasiLatihanTiga3
{
    partial class FrmTiga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.txtPsn1 = new System.Windows.Forms.TextBox();
            this.txtPsn2 = new System.Windows.Forms.TextBox();
            this.CmbPndk = new System.Windows.Forms.ComboBox();
            this.List = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPsn3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pekerjaan";
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(128, 51);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(303, 22);
            this.TxtNama.TabIndex = 3;
            // 
            // txtPsn1
            // 
            this.txtPsn1.Location = new System.Drawing.Point(31, 370);
            this.txtPsn1.Name = "txtPsn1";
            this.txtPsn1.Size = new System.Drawing.Size(400, 22);
            this.txtPsn1.TabIndex = 4;
            // 
            // txtPsn2
            // 
            this.txtPsn2.Location = new System.Drawing.Point(31, 409);
            this.txtPsn2.Name = "txtPsn2";
            this.txtPsn2.Size = new System.Drawing.Size(400, 22);
            this.txtPsn2.TabIndex = 5;
            // 
            // CmbPndk
            // 
            this.CmbPndk.FormattingEnabled = true;
            this.CmbPndk.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.CmbPndk.Location = new System.Drawing.Point(128, 106);
            this.CmbPndk.Name = "CmbPndk";
            this.CmbPndk.Size = new System.Drawing.Size(303, 24);
            this.CmbPndk.TabIndex = 6;
            // 
            // List
            // 
            this.List.ItemHeight = 16;
            this.List.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.List.Location = new System.Drawing.Point(128, 163);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(303, 164);
            this.List.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(31, 492);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(400, 37);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPsn3
            // 
            this.txtPsn3.Location = new System.Drawing.Point(31, 450);
            this.txtPsn3.Name = "txtPsn3";
            this.txtPsn3.Size = new System.Drawing.Size(400, 22);
            this.txtPsn3.TabIndex = 8;
            // 
            // FrmTiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 564);
            this.Controls.Add(this.txtPsn3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.List);
            this.Controls.Add(this.CmbPndk);
            this.Controls.Add(this.txtPsn2);
            this.Controls.Add(this.txtPsn1);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan 3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox txtPsn1;
        private System.Windows.Forms.TextBox txtPsn2;
        private System.Windows.Forms.ComboBox CmbPndk;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPsn3;
    }
}

