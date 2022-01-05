using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_pendulum
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        static List<AlbumsClass> Albums = new List<AlbumsClass>();
        static List<TracksClass> Tracks = new List<TracksClass>();
        public bool cbChanged;
        public int pBpic;
        public FrmMain()
        {
            ConnectionString =
                @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = music;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tbKereses.Enabled = false;
            btUrl.Enabled = false;
            btEdit.Enabled = false; 
            FillCB();
            
        }

        private void FillCB()
        {
            if (!cbChanged)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r = new SqlCommand("SELECT artist FROM Albums GROUP BY artist;", c).ExecuteReader();
                    while (r.Read()) cbArtist.Items.Add(r[0]);
                }
            }
            if (cbArtist.Text != "" && cbChanged)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r = new SqlCommand($"SELECT title FROM Albums;", c).ExecuteReader();
                    while (r.Read())
                    {
                        cbAlbum.Items.Add(r[0]);
                    }
                }
            }
            
        }
        private void FillRTB()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand($"SELECT release,length FROM Albums,Tracks;", c).ExecuteReader();
                while (r.Read())
                {
                    rTBAdatok.Text = $"{r[0]} \n{r[1]}";
                }
            }
        }

        private void FillPB()
        {
            if(cbAlbum.Text == "Hold Your Colour")
                pBKepek.Image = Image.FromFile(@"..\..\res\hold_your_colour.jpg");
            else if (cbAlbum.Text == "In Silico")
                pBKepek.Image = Image.FromFile(@"..\..\res\in_silico.jpg");
            else if (cbAlbum.Text == "Immersion")
                pBKepek.Image = Image.FromFile(@"..\..\res\immersion.jpg");
            else
                pBKepek.Image = null;
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
               
                var r = new SqlCommand($"SELECT Tracks.title,Tracks.length,Tracks.url,Tracks.id FROM Albums,Tracks WHERE Tracks.album = Albums.id AND Tracks.title LIKE '%{tbKereses.Text}%' AND Albums.title LIKE '{cbAlbum.Text}';", c).ExecuteReader();
                
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }

                tbKereses.Enabled = true;
            }
        }

        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChanged = true;
            FillCB();
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPB();
            FillRTB();
            FillDGV();
        }

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            string urlShow = dgv.CurrentRow.Cells[2].Value.ToString();

            if (urlShow == "null")
            {
                llbLink.Text = String.Empty;
                btUrl.Enabled = true;
            }
            else
            {
                llbLink.Text = "https://youtu.be/" + urlShow;
                btUrl.Enabled = false;
            }
            btEdit.Enabled = true;
        }

        private void btUrl_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells[3].Value);
            var frm = new FrmUrl(id);
            frm.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //var frm = new FrmEdit();
            int id = Convert.ToInt32(dgv.CurrentRow.Cells[3].Value);
            var frm = new FrmEdit(id);
            frm.ShowDialog();
        }

        private void tbDiscoDiscoJoJo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Későn olvastam el a feladatot :'D", "");
        }
    }
}
