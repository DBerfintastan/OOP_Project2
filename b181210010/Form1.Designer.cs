namespace b181210010
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.x_deger = new System.Windows.Forms.Label();
            this.txtSayiX = new System.Windows.Forms.TextBox();
            this.y_deger = new System.Windows.Forms.Label();
            this.txtSayiY = new System.Windows.Forms.TextBox();
            this.arkadasmi = new System.Windows.Forms.Button();
            this.son = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x_deger
            // 
            this.x_deger.AutoSize = true;
            this.x_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_deger.Location = new System.Drawing.Point(59, 53);
            this.x_deger.Name = "x_deger";
            this.x_deger.Size = new System.Drawing.Size(38, 29);
            this.x_deger.TabIndex = 1;
            this.x_deger.Text = "X:";
            // 
            // txtSayiX
            // 
            this.txtSayiX.Location = new System.Drawing.Point(175, 60);
            this.txtSayiX.Name = "txtSayiX";
            this.txtSayiX.Size = new System.Drawing.Size(105, 22);
            this.txtSayiX.TabIndex = 3;
            // 
            // y_deger
            // 
            this.y_deger.AutoSize = true;
            this.y_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_deger.Location = new System.Drawing.Point(59, 125);
            this.y_deger.Name = "y_deger";
            this.y_deger.Size = new System.Drawing.Size(37, 29);
            this.y_deger.TabIndex = 4;
            this.y_deger.Text = "Y:";
            // 
            // txtSayiY
            // 
            this.txtSayiY.Location = new System.Drawing.Point(175, 125);
            this.txtSayiY.Name = "txtSayiY";
            this.txtSayiY.Size = new System.Drawing.Size(105, 22);
            this.txtSayiY.TabIndex = 5;
            // 
            // arkadasmi
            // 
            this.arkadasmi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.arkadasmi.Location = new System.Drawing.Point(26, 191);
            this.arkadasmi.Name = "arkadasmi";
            this.arkadasmi.Size = new System.Drawing.Size(117, 41);
            this.arkadasmi.TabIndex = 6;
            this.arkadasmi.Text = "ARKADAŞ MI?";
            this.arkadasmi.UseVisualStyleBackColor = false;
            this.arkadasmi.Click += new System.EventHandler(this.arkadasmi_Click);
            // 
            // son
            // 
            this.son.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.son.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.son.Location = new System.Drawing.Point(175, 191);
            this.son.Name = "son";
            this.son.Size = new System.Drawing.Size(117, 41);
            this.son.TabIndex = 7;
            this.son.Text = "SON";
            this.son.UseVisualStyleBackColor = false;
            this.son.Click += new System.EventHandler(this.son_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 289);
            this.Controls.Add(this.son);
            this.Controls.Add(this.arkadasmi);
            this.Controls.Add(this.txtSayiY);
            this.Controls.Add(this.y_deger);
            this.Controls.Add(this.txtSayiX);
            this.Controls.Add(this.x_deger);
            this.Name = "Form1";
            this.Text = "ARKADAŞ MI?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x_deger;
        private System.Windows.Forms.TextBox txtSayiX;
        private System.Windows.Forms.Label y_deger;
        private System.Windows.Forms.TextBox txtSayiY;
        private System.Windows.Forms.Button arkadasmi;
        private System.Windows.Forms.Button son;
    }
}

