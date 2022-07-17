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
    public partial class ClockingInForm : Form
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

        public ClockingInForm()
        {
            InitializeComponent();
        }

        private void btnUpdateClock_Click(object sender, EventArgs e)
        {
            if (txtDateUpdate.Text != "" && txtPersonnelIdUpdate.Text != "" && txtEnterTimeUpdate.Text != "")
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string[] login = new string[5];
                string date = txtDateUpdate.Text;
                date = Jalali_to_gregorian(date);
                string sql = "select * from clocking_in where login_date = '" + date + "' AND login_time = '"+ txtEnterTimeUpdate.Text + "' AND personnel_id_secretary = " + txtPersonnelIdUpdate.Text;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        login[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (login[1] == null)
                {
                    MessageBox.Show("!ورودی با این شناسه پیدا نشد");
                }
                else
                {
                    txtPersonnelId.Text = login[2];
                    int index = login[0].IndexOf(' ');
                    string date2 = login[0].Substring(0, index);
                    date2 = Gregorian_to_jalali(date2);
                    txtDate.Text = date2;
                    txtEnterTime.Text = login[1];
                    txtExitTime.Text = login[3];
                    if (login[4] != "")
                    {
                        int index2 = login[4].IndexOf(' ');
                        string date3 = login[4].Substring(0, index);
                        date3 = Gregorian_to_jalali(date3);
                        txtDateOff.Text = date3;
                    }
                }
                dataReader.Close();
                cmd.Dispose();
            }
            else MessageBox.Show(".همه فضا ها باید پر باشند");
        }

        private void btnInsertClock_Click(object sender, EventArgs e)
        {
            bool update = false;
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            List<string> listPersonnelId = new List<string>();
            List<string> listDate = new List<string>();
            List<string> listTime = new List<string>();
            int n = 0;
            sql = "select login_date,login_time,personnel_id_secretary from clocking_in";
            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listPersonnelId.Add(dataReader.GetValue(2).ToString());
                listDate.Add(dataReader.GetValue(0).ToString());
                listTime.Add(dataReader.GetValue(1).ToString());
                n++;
            }
            string[] outputId = listPersonnelId.ToArray();
            string[] outputDate = listDate.ToArray();
            string[] outputTime = listTime.ToArray();
            for (int i = 0; i < n; i++)
            {
                string dateOutput = outputDate[i].Substring(0, outputDate[i].IndexOf(' '));
                dateOutput = Gregorian_to_jalali(dateOutput);
                if (txtPersonnelId.Text == outputId[i] && txtDate.Text == dateOutput && txtEnterTime.Text == outputTime[i])
                {
                    update = true;
                }
            }
            dataReader.Close();
            cmd.Dispose();
            if (update)
            {
                try
                {
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    string date2 = txtDateOff.Text;
                    if (date2 != "")
                    {
                        date2 = Jalali_to_gregorian(date2);
                        date2 = "'" + date2 + "'";
                    }
                    else date2 = "null";              
                    sql = "update clocking_in set login_date = '" + date + "', login_time = '" + txtEnterTime.Text +
                        ", personnel_id_secretary = " + txtPersonnelId.Text + ", logout_time = '" + txtExitTime.Text + "', leave_of_absence_date = " + date2 +
                        "' where personnel_id_secretary = " + txtPersonnelId.Text + " AND login_date = '" + date + "' AND login_time = '"+ txtEnterTime.Text +"'";
                    cmd = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                    MessageBox.Show("!عملیات تغییر با موفقیت انجام شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    string date2 = txtDateOff.Text;
                    if (date2 != "")
                    {
                        date2 = Jalali_to_gregorian(date2);
                        date2 = "'" + date2 + "'";
                    }
                    else date2 = "null";
                    sql = "insert into clocking_in (login_date,login_time,personnel_id_secretary,logout_time,leave_of_absence_date)values('" +
                        date + "', '" + txtEnterTime.Text + "', " + txtPersonnelId.Text + ", '" + txtExitTime.Text + "', "+ date2+")";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                    MessageBox.Show("!عملیات ثبت با موفقیت انجام شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
