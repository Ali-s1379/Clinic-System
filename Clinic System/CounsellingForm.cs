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
    public partial class CounsellingForm : Form
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

        public CounsellingForm()
        {
            InitializeComponent();
        }

        private void btnUpdateCounselling_Click(object sender, EventArgs e)
        {
            if (txtDateUpdate.Text != "" && txtPatientIdUpdate.Text != "" )
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string[] counselling = new string[9];
                string date = txtDateUpdate.Text;
                date = Jalali_to_gregorian(date);
                string sql = "select * from counselling where date_counselling = '" + date + "' AND patient_id = " + txtPatientIdUpdate.Text;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 9; i++)
                    {
                        counselling[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (counselling[1] == null)
                {
                    MessageBox.Show("!ورودی با این شناسه پیدا نشد");
                }
                else
                {
                    txtPersonnelId.Text = counselling[1];
                    int index = counselling[0].IndexOf(' ');
                    string date2 = counselling[0].Substring(0, index);
                    date2 = Gregorian_to_jalali(date2);
                    txtDate.Text = date2;
                    txtDoctorId.Text = counselling[2];
                    txtPatientId.Text = counselling[3];
                    txtTime.Text = counselling[4];
                    txtDuration.Text = counselling[5];
                    txtNumber.Text = counselling[6];
                    txtPrice.Text = counselling[7];
                    txtMedication.Text = counselling[8];
                }
                dataReader.Close();
                cmd.Dispose();
            }
            else MessageBox.Show(".همه فضا ها باید پر باشند");
        }

        private void btnInsertCounselling_Click(object sender, EventArgs e)
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
            List<string> listPatientId = new List<string>();
            List<string> listDate = new List<string>();
            int n = 0;
            sql = "select date_counselling,patient_id from counselling";
            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listPatientId.Add(dataReader.GetValue(1).ToString());
                int index = dataReader.GetValue(0).ToString().IndexOf(' ');
                string date = dataReader.GetValue(0).ToString().Substring(0, index);
                date = Gregorian_to_jalali(date);
                listDate.Add(date);
                n++;
            }
            string[] outputId = listPatientId.ToArray();
            string[] outputDate = listDate.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (txtPatientId.Text == outputId[i] && txtDate.Text == outputDate[i])
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
                    string price = "";
                    if (txtPrice.Text == "")
                    {
                        price = "null";
                    }
                    else price = txtPrice.Text;
                    sql = "update counselling set date_counselling = '" + date + "', personnel_id_secretary = " + txtPersonnelId.Text +
                        ", personnel_id_doctor = " + txtDoctorId.Text + ", patient_id = " + txtPatientId.Text + ", time_counselling = '" + txtTime.Text +
                        "', duration_counselling = "+ txtDuration.Text +", number_of_sessions = "+ txtNumber.Text +", price_paid = "+ price +
                        ", medication = N'"+ txtMedication.Text +"' where patient_id = " + txtPatientId.Text + " AND date_counselling = '" + date + "'";
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
                    string price = "";
                    if (txtPrice.Text == "")
                    {
                        price = "null";
                    }
                    else price = txtPrice.Text;
                    sql = "insert into counselling (date_counselling,personnel_id_secretary,personnel_id_doctor,patient_id,time_counselling,duration_counselling," +
                        "number_of_sessions,price_paid,medication)values('" +date + "', " + txtPersonnelId.Text + ", " + txtDoctorId.Text + ", " + txtPatientId.Text + 
                        ", '" + txtTime.Text + "', "+ txtDuration.Text +", "+ txtNumber.Text +", "+ price +", N'"+ txtMedication.Text +"')";
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
