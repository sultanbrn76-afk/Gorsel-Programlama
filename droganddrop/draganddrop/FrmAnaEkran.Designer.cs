namespace draganddrop
{
    partial class FrmAnaEkran
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
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstİllerA = new System.Windows.Forms.ListBox();
            this.btnsecilenigoster = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnAktarAb = new System.Windows.Forms.Button();
            this.btnaktarba = new System.Windows.Forms.Button();
            this.lstİllerB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(75, 71);
            this.txtGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(120, 22);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.Click += new System.EventHandler(this.txtGiris_Click);
            this.txtGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiris_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(204, 70);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 28);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEkle_KeyDown);
            // 
            // lstİllerA
            // 
            this.lstİllerA.AllowDrop = true;
            this.lstİllerA.FormattingEnabled = true;
            this.lstİllerA.ItemHeight = 16;
            this.lstİllerA.Items.AddRange(new object[] {
            "izmir",
            "ığdır",
            "istanbul",
            "sinop",
            "artvin",
            "rizee"});
            this.lstİllerA.Location = new System.Drawing.Point(75, 107);
            this.lstİllerA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstİllerA.Name = "lstİllerA";
            this.lstİllerA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstİllerA.Size = new System.Drawing.Size(228, 116);
            this.lstİllerA.TabIndex = 2;
            this.lstİllerA.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstİllerA_DragDrop);
            this.lstİllerA.DragOver += new System.Windows.Forms.DragEventHandler(this.lstİllerA_DragOver);
            this.lstİllerA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstİllerA_MouseDown);
            // 
            // btnsecilenigoster
            // 
            this.btnsecilenigoster.Location = new System.Drawing.Point(75, 239);
            this.btnsecilenigoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsecilenigoster.Name = "btnsecilenigoster";
            this.btnsecilenigoster.Size = new System.Drawing.Size(112, 58);
            this.btnsecilenigoster.TabIndex = 3;
            this.btnsecilenigoster.Text = "Seçileni Göster";
            this.btnsecilenigoster.UseVisualStyleBackColor = true;
            this.btnsecilenigoster.Click += new System.EventHandler(this.btnsecilenigoster_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(195, 239);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 58);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnAktarAb
            // 
            this.btnAktarAb.Location = new System.Drawing.Point(332, 118);
            this.btnAktarAb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAktarAb.Name = "btnAktarAb";
            this.btnAktarAb.Size = new System.Drawing.Size(100, 28);
            this.btnAktarAb.TabIndex = 5;
            this.btnAktarAb.Text = ">>";
            this.btnAktarAb.UseVisualStyleBackColor = true;
            this.btnAktarAb.Click += new System.EventHandler(this.btnAktarAb_Click);
            // 
            // btnaktarba
            // 
            this.btnaktarba.Location = new System.Drawing.Point(332, 171);
            this.btnaktarba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaktarba.Name = "btnaktarba";
            this.btnaktarba.Size = new System.Drawing.Size(100, 28);
            this.btnaktarba.TabIndex = 6;
            this.btnaktarba.Text = "<<";
            this.btnaktarba.UseVisualStyleBackColor = true;
            this.btnaktarba.Click += new System.EventHandler(this.btnaktarba_Click);
            // 
            // lstİllerB
            // 
            this.lstİllerB.AllowDrop = true;
            this.lstİllerB.FormattingEnabled = true;
            this.lstİllerB.ItemHeight = 16;
            this.lstİllerB.Location = new System.Drawing.Point(477, 107);
            this.lstİllerB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstİllerB.Name = "lstİllerB";
            this.lstİllerB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstİllerB.Size = new System.Drawing.Size(211, 116);
            this.lstİllerB.TabIndex = 7;
            this.lstİllerB.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstİllerB_DragDrop);
            this.lstİllerB.DragOver += new System.Windows.Forms.DragEventHandler(this.lstİllerB_DragOver);
            this.lstİllerB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstİllerB_MouseDown);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstİllerB);
            this.Controls.Add(this.btnaktarba);
            this.Controls.Add(this.btnAktarAb);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnsecilenigoster);
            this.Controls.Add(this.lstİllerA);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGiris);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAnaEkran";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstİllerA;
        private System.Windows.Forms.Button btnsecilenigoster;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnAktarAb;
        private System.Windows.Forms.Button btnaktarba;
        private System.Windows.Forms.ListBox lstİllerB;
    }
}

