namespace WFA_pendulum
{
    partial class FrmEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Album:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "url:";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(24, 259);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(427, 35);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Szerkesztés";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(56, 98);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(373, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(56, 134);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(373, 20);
            this.tbLength.TabIndex = 7;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(56, 186);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(373, 20);
            this.tbAlbum.TabIndex = 8;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(56, 223);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(373, 20);
            this.tbUrl.TabIndex = 9;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(56, 62);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(373, 20);
            this.tbId.TabIndex = 10;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 319);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbId;
    }
}