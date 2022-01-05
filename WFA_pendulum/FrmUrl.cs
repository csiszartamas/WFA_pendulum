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
    public partial class FrmUrl : Form
    {
        public string ConnectionString { get; set; }
        public int Id { get; set; }
        public FrmUrl(int id)
        {
            ConnectionString =
                @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = music;";
            Id = id;
            InitializeComponent();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/";
            try
            {
                if (tbUrl.Text.Substring(0, 17) == url)
                {
                    using (var c = new SqlConnection(ConnectionString))
                    {
                        c.Open();
                        new SqlCommand($"UPDATE Tracks SET url = '{tbUrl.Text.Remove(0, 17)}' WHERE id = {Id};", c).ExecuteNonQuery();
                        MessageBox.Show("Sikeresen frissítetted!", "");
                    }
                }
                else
                {
                    MessageBox.Show("Nem megfelelő a link!", "");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem megfelelő a link!", "");
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
