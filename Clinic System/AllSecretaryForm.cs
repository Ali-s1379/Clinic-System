using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic_System
{
    public partial class AllSecretaryForm : Form
    {
        public AllSecretaryForm()
        {
            InitializeComponent();
        }

        private void AllSecretaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM secretary", cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    listitem.SubItems.Add("| " + dr[1].ToString());
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    listitem.SubItems.Add("| " + dr[3].ToString());
                    listView1.Items.Add(listitem);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.ToString());
            }
        }
    }
}
