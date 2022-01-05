using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_pendulum
{
    public partial class FrmEdit : Form
    {
        public string ConnectionString { get; set; }
        public int Id { get; set; }
        public FrmEdit(int id)
        //public FrmEdit()
        {
            ConnectionString =
                @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = music;";
            Id = id;
            InitializeComponent();
            tbId.Enabled = false;
        }
        private void FrmEdit_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand($"SELECT * FROM Tracks WHERE id = {Id}", c).ExecuteReader();
                while (r.Read())
                {
                    tbId.Text = r[0].ToString();
                    tbTitle.Text = r[1].ToString();
                    tbLength.Text = r[2].ToString();
                    tbAlbum.Text = r[3].ToString();
                    tbUrl.Text = r[4].ToString();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Biztos szerkeszteni akarod?", "Edit", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    if (tbUrl.Text.ToLower() == "null")
                    {
                        new SqlCommand($"UPDATE Tracks SET title = '{tbTitle.Text}', length = '{tbLength.Text}', album = '{tbAlbum.Text}', url = '{tbUrl.Text}' WHERE id = {Id};", conn).ExecuteNonQuery();
                    }
                    else
                    {
                        new SqlCommand($"UPDATE Tracks SET title = '{tbTitle.Text}', length = '{tbLength.Text}', album = '{tbAlbum.Text}', url = '{tbUrl.Text}' WHERE id = '{Id}';", conn).ExecuteNonQuery();
                    }
                }
                this.Close();
                MessageBox.Show("Sikeresen módosítottuk");
            }
            if (response == DialogResult.No)
            {
                MessageBox.Show("Megszakítottuk a szerkeztést");
            }
        }
    }
}
