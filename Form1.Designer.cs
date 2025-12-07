namespace Red_Dead_Redemption_2_Türkçe_Yama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSelectExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(16, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(244, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Lütfen RDR2.exe dosyasını seçin!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectExe
            // 
            this.btnSelectExe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectExe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectExe.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSelectExe.FlatAppearance.BorderSize = 5;
            this.btnSelectExe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectExe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExe.ForeColor = System.Drawing.Color.Red;
            this.btnSelectExe.Location = new System.Drawing.Point(16, 25);
            this.btnSelectExe.Name = "btnSelectExe";
            this.btnSelectExe.Size = new System.Drawing.Size(244, 31);
            this.btnSelectExe.TabIndex = 2;
            this.btnSelectExe.Text = "Gözat";
            this.btnSelectExe.UseVisualStyleBackColor = false;
            this.btnSelectExe.Click += new System.EventHandler(this.btnSelectExe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(276, 68);
            this.Controls.Add(this.btnSelectExe);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 107);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 107);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Dead Redemption 2 Türkçe Yama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSelectExe;
    }
}

