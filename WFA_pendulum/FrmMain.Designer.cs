namespace WFA_pendulum
{
    partial class FrmMain
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
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.pBKepek = new System.Windows.Forms.PictureBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.llbLink = new System.Windows.Forms.LinkLabel();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.rTBAdatok = new System.Windows.Forms.RichTextBox();
            this.tbDiscoDiscoJoJo = new System.Windows.Forms.Button();
            this.btUrl = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBKepek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(19, 45);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(121, 21);
            this.cbArtist.TabIndex = 0;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(170, 45);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(121, 21);
            this.cbAlbum.TabIndex = 1;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.cbAlbum_SelectedIndexChanged);
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Location = new System.Drawing.Point(45, 20);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(30, 13);
            this.lbArtist.TabIndex = 2;
            this.lbArtist.Text = "Artist";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(16, 93);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(105, 13);
            this.lbSearch.TabIndex = 4;
            this.lbSearch.Text = "Search in track\'s title";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.length,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(19, 176);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(398, 241);
            this.dgv.TabIndex = 5;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // length
            // 
            this.length.HeaderText = "Length";
            this.length.Name = "length";
            this.length.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // tbKereses
            // 
            this.tbKereses.Location = new System.Drawing.Point(19, 123);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.Size = new System.Drawing.Size(398, 20);
            this.tbKereses.TabIndex = 6;
            this.tbKereses.TextChanged += new System.EventHandler(this.tbKereses_TextChanged);
            // 
            // pBKepek
            // 
            this.pBKepek.Cursor = System.Windows.Forms.Cursors.Default;
            this.pBKepek.Location = new System.Drawing.Point(452, 176);
            this.pBKepek.Name = "pBKepek";
            this.pBKepek.Size = new System.Drawing.Size(104, 104);
            this.pBKepek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBKepek.TabIndex = 7;
            this.pBKepek.TabStop = false;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(449, 319);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(63, 13);
            this.lbUrl.TabIndex = 8;
            this.lbUrl.Text = "URL(if any):";
            // 
            // llbLink
            // 
            this.llbLink.AutoSize = true;
            this.llbLink.Location = new System.Drawing.Point(518, 319);
            this.llbLink.Name = "llbLink";
            this.llbLink.Size = new System.Drawing.Size(37, 13);
            this.llbLink.TabIndex = 9;
            this.llbLink.TabStop = true;
            this.llbLink.Text = "NOPE";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(205, 20);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(36, 13);
            this.lbAlbum.TabIndex = 10;
            this.lbAlbum.Text = "Album";
            // 
            // rTBAdatok
            // 
            this.rTBAdatok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTBAdatok.Location = new System.Drawing.Point(565, 176);
            this.rTBAdatok.Name = "rTBAdatok";
            this.rTBAdatok.Size = new System.Drawing.Size(207, 104);
            this.rTBAdatok.TabIndex = 11;
            this.rTBAdatok.Text = "";
            // 
            // tbDiscoDiscoJoJo
            // 
            this.tbDiscoDiscoJoJo.Location = new System.Drawing.Point(452, 364);
            this.tbDiscoDiscoJoJo.Name = "tbDiscoDiscoJoJo";
            this.tbDiscoDiscoJoJo.Size = new System.Drawing.Size(104, 40);
            this.tbDiscoDiscoJoJo.TabIndex = 12;
            this.tbDiscoDiscoJoJo.Text = "Add Discography";
            this.tbDiscoDiscoJoJo.UseVisualStyleBackColor = true;
            this.tbDiscoDiscoJoJo.Click += new System.EventHandler(this.tbDiscoDiscoJoJo_Click);
            // 
            // btUrl
            // 
            this.btUrl.Location = new System.Drawing.Point(565, 364);
            this.btUrl.Name = "btUrl";
            this.btUrl.Size = new System.Drawing.Size(96, 40);
            this.btUrl.TabIndex = 13;
            this.btUrl.Text = "Add URL";
            this.btUrl.UseVisualStyleBackColor = true;
            this.btUrl.Click += new System.EventHandler(this.btUrl_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(677, 364);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 40);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Edit Selected";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btUrl);
            this.Controls.Add(this.tbDiscoDiscoJoJo);
            this.Controls.Add(this.rTBAdatok);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.llbLink);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.pBKepek);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Name = "FrmMain";
            this.Text = "Discograpy Tracker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBKepek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.PictureBox pBKepek;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.LinkLabel llbLink;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.RichTextBox rTBAdatok;
        private System.Windows.Forms.Button tbDiscoDiscoJoJo;
        private System.Windows.Forms.Button btUrl;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

