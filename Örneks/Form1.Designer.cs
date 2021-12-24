
namespace Örneks
{
    partial class Form1
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(113, 55);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(323, 30);
            this.dtpTarih.TabIndex = 0;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(168, 19);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(200, 33);
            this.lblDogumTarihi.TabIndex = 1;
            this.lblDogumTarihi.Text = "Doğum Tarihiniz";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(173, 114);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(137, 46);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(107, 215);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(124, 31);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaşınız : ";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.Location = new System.Drawing.Point(51, 259);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(233, 31);
            this.lblGun.TabIndex = 5;
            this.lblGun.Text = "Yaşadığınız Gün : ";
            // 
            // lblBurc
            // 
            this.lblBurc.AutoSize = true;
            this.lblBurc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBurc.Location = new System.Drawing.Point(80, 314);
            this.lblBurc.Name = "lblBurc";
            this.lblBurc.Size = new System.Drawing.Size(151, 31);
            this.lblBurc.TabIndex = 7;
            this.lblBurc.Text = "Burcunuz : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 370);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.dtpTarih);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Burc Gün Yaş Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblBurc;
    }
}

