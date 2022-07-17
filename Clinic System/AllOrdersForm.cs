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
    public partial class AllOrdersForm : Form
    {
        public static string Gregorian_to_jalali(string date)
        {
            int gy, gm, gd;
            int index = date.IndexOf('/');
            gm = int.Parse(date.Substring(0, index));
            int index2 = date.Length;
            date = date.Substring(index + 1);
            index = date.IndexOf('/');
            gd = int.Parse(date.Substring(0, index));
            date = date.Substring(index + 1);
            gy = int.Parse(date);

            int[] g_d_m = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
            int gy2 = (gm > 2) ? (gy + 1) : gy;
            int days = 355666 + (365 * gy) + ((int)((gy2 + 3) / 4)) - ((int)((gy2 + 99) / 100)) + ((int)((gy2 + 399) / 400)) + gd + g_d_m[gm - 1];
            int jy = -1595 + (33 * ((int)(days / 12053)));
            days %= 12053;
            jy += 4 * ((int)(days / 1461));
            days %= 1461;
            if (days > 365)
            {
                jy += (int)((days - 1) / 365);
                days = (days - 1) % 365;
            }
            int jm = (days < 186) ? 1 + (int)(days / 31) : 7 + (int)((days - 186) / 30);
            int jd = 1 + ((days < 186) ? (days % 31) : ((days - 186) % 30));
            string jalali = jy + "/" + jm + "/" + jd;
            return jalali;
        }

        public AllOrdersForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM orders", cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    listitem.SubItems.Add("| " + dr[1].ToString().PadLeft(3));
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    string productType = "";
                    if (dr[3].ToString() == "1")
                    {
                        productType = "اداری";
                    }
                    if (dr[3].ToString() == "2")
                    {
                        productType = "پزشکی";
                    }
                    listitem.SubItems.Add("| " + productType);
                    listitem.SubItems.Add("| " + dr[4].ToString());
                    string date = dr[5].ToString().Substring(0, dr[5].ToString().IndexOf(' '));
                    date = Gregorian_to_jalali(date);
                    listitem.SubItems.Add("| " + date);
                    listitem.SubItems.Add("| " + dr[6].ToString());
                    listView1.Items.Add(listitem);
                }
            }
            catch (Exception ms) 
            {
                MessageBox.Show(ms.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                string sql = "";
                if (cmbBoxProductType.Text == "" && txtBoxPersonnelIdDoctor.Text != "")
                {
                    sql = "select * from orders where personnel_id_doctor = " + txtBoxPersonnelIdDoctor.Text;
                }
                else if (txtBoxPersonnelIdDoctor.Text == "" && cmbBoxProductType.Text != "")
                {
                    string type = "";
                    if (cmbBoxProductType.Text == "اداری")
                    {
                        type = "1";
                    }
                    else type = "2";
                    sql = "select * from orders where product_type = " + type;
                }
                else if (cmbBoxProductType.Text != "" && txtBoxPersonnelIdDoctor.Text != "")
                {
                    string type = "";
                    if (cmbBoxProductType.Text == "اداری")
                    {
                        type = "1";
                    }
                    else type = "2";
                    sql = "select * from orders where product_type = " + type + " AND personnel_id_doctor = " + txtBoxPersonnelIdDoctor.Text;
                }
                else sql = "select * from orders";
                SqlDataAdapter adp = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    listitem.SubItems.Add("| " + dr[1].ToString().PadLeft(3));
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    string productType = "";
                    if (dr[3].ToString() == "1")
                    {
                        productType = "اداری";
                    }
                    if (dr[3].ToString() == "2")
                    {
                        productType = "پزشکی";
                    }
                    listitem.SubItems.Add("| " + productType);
                    listitem.SubItems.Add("| " + dr[4].ToString());
                    listitem.SubItems.Add("| " + dr[5].ToString().Substring(0,dr[5].ToString().IndexOf(' ')));
                    listitem.SubItems.Add("| " + dr[6].ToString());
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
