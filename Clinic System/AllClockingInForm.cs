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
    public partial class AllClockingInForm : Form
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

        public static string Jalali_to_gregorian(string date)
        {
            int jy, jm, jd;
            int index = date.IndexOf('/');
            jy = int.Parse(date.Substring(0, index));
            int index2 = date.Length;
            date = date.Substring(index + 1);
            index = date.IndexOf('/');
            jm = int.Parse(date.Substring(0, index));
            date = date.Substring(index + 1);
            jd = int.Parse(date);

            jy += 1595;
            int days = -355668 + (365 * jy) + (((int)(jy / 33)) * 8) + ((int)(((jy % 33) + 3) / 4)) + jd + ((jm < 7) ? (jm - 1) * 31 : ((jm - 7) * 30) + 186);
            int gy = 400 * ((int)(days / 146097));
            days %= 146097;
            if (days > 36524)
            {
                gy += 100 * ((int)(--days / 36524));
                days %= 36524;
                if (days >= 365) days++;
            }
            gy += 4 * ((int)(days / 1461));
            days %= 1461;
            if (days > 365)
            {
                gy += (int)((days - 1) / 365);
                days = (days - 1) % 365;
            }
            int gd = days + 1;
            int[] sal_a = { 0, 31, ((gy % 4 == 0 && gy % 100 != 0) || (gy % 400 == 0)) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int gm;
            for (gm = 0; gm < 13 && gd > sal_a[gm]; gm++) gd -= sal_a[gm];
            string gregorian = gy + "-" + gm + "-" + gd;
            return gregorian;
        }

        public AllClockingInForm()
        {
            InitializeComponent();
        }

        private void AllClockingInForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM clocking_in", cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string date = dr[0].ToString().Substring(0, dr[0].ToString().IndexOf(' '));
                    date = Gregorian_to_jalali(date);
                    ListViewItem listitem = new ListViewItem(date);
                    listitem.SubItems.Add("| " + dr[1].ToString());
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    listitem.SubItems.Add("| " + dr[3].ToString());
                    if (dr[4].ToString() != "")
                    {
                        string date2 = dr[4].ToString().Substring(0, dr[4].ToString().IndexOf(' '));
                        date2 = Gregorian_to_jalali(date2);
                        listitem.SubItems.Add("| " + date2);
                    }
                    else listitem.SubItems.Add("| " + dr[4].ToString());
                    listView1.Items.Add(listitem);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.ToString());
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                string sql = "";
                if (txtPersonnelId.Text == "" && txtDate.Text != "")
                {
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    sql = "select * from clocking_in where login_date = '" + date + "'";
                }
                else if (txtDate.Text == "" && txtPersonnelId.Text != "")
                {
                    sql = "select * from clocking_in where personnel_id_secretary = " + txtPersonnelId.Text;
                }
                else if (txtPersonnelId.Text != "" && txtDate.Text != "")
                {
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    sql = "select * from clocking_in where login_date = '" + date + "' AND personnel_id_secretary = " + txtPersonnelId.Text;
                }
                else sql = "select * from clocking_in";
                SqlDataAdapter adp = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string date = dr[0].ToString().Substring(0, dr[0].ToString().IndexOf(' '));
                    date = Gregorian_to_jalali(date);
                    ListViewItem listitem = new ListViewItem(date);
                    listitem.SubItems.Add("| " + dr[1].ToString());
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    listitem.SubItems.Add("| " + dr[3].ToString());
                    if (dr[4].ToString() != "")
                    {
                        string date2 = dr[4].ToString().Substring(0, dr[4].ToString().IndexOf(' '));
                        date2 = Gregorian_to_jalali(date2);
                        listitem.SubItems.Add("| " + date2);
                    }
                    else listitem.SubItems.Add("| " + dr[4].ToString());
                    listView1.Items.Add(listitem);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.ToString());
            }
        }

        private void btnNotPaid_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                string connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                listView1.Items.Clear();
                string sql = "";
                if (txtIdOff.Text == "")
                {
                    sql = "select * from clocking_in where LEAVE_OF_ABSENCE_DATE is not null";
                }
                else sql = "select * from clocking_in where LEAVE_OF_ABSENCE_DATE is not null AND personnel_id_secretary = " + txtIdOff.Text;
                SqlDataAdapter adp = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string date = dr[0].ToString().Substring(0, dr[0].ToString().IndexOf(' '));
                    date = Gregorian_to_jalali(date);
                    ListViewItem listitem = new ListViewItem(date);
                    listitem.SubItems.Add("| " + dr[1].ToString());
                    listitem.SubItems.Add("| " + dr[2].ToString());
                    listitem.SubItems.Add("| " + dr[3].ToString());
                    if (dr[4].ToString() != "")
                    {
                        string date2 = dr[4].ToString().Substring(0, dr[4].ToString().IndexOf(' '));
                        date2 = Gregorian_to_jalali(date2);
                        listitem.SubItems.Add("| " + date2);
                    }
                    else listitem.SubItems.Add("| " + dr[4].ToString());
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
