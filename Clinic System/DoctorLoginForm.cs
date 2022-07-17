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
    public partial class DoctorLoginForm : Form
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

        public DoctorLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogoutDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            AllOrdersForm allOrdersForm = new AllOrdersForm();
            allOrdersForm.Show();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string[] orderId = new string[7];
                string sql = "select * from orders where order_id = '" + txtBoxOrderId.Text + "'";
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        orderId[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (orderId[1] == null)
                {
                    MessageBox.Show("!سفارشی با این کد پیدا نشد");
                }
                else
                {
                    int index = orderId[5].IndexOf(' ');
                    string date = orderId[5].Substring(0, index);
                    orderId[5] = Gregorian_to_jalali(date);
                    if (orderId[3] == "1")
                    {
                        orderId[3] = "اداری";
                    }
                    else
                    {
                        orderId[3] = "پزشکی";
                    }
                    string output = "";
                    for (int i = 6; i > -1; i--)
                    {
                        output = output + "\u200F" + orderId[i] + " - ";
                    }
                    output = output.Substring(0, output.Length - 2);
                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "delete from orders where order_id = " + txtBoxOrderId.Text;
            cmd = new SqlCommand(sql, cnn);
            try
            {
                adapter.DeleteCommand = new SqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("!عملیات با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Dispose();
        }

        private void btnAllPatient_Click(object sender, EventArgs e)
        {
            AllPatientsForm form = new AllPatientsForm();
            form.Show();
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            MedicalHistoryForm form = new MedicalHistoryForm();
            form.Show();
        }

        private void btnAllMedicalHistory_Click(object sender, EventArgs e)
        {
            AllMedicalHistoryForm form= new AllMedicalHistoryForm();
            form.Show();
        }

        private void btnAllCounselling_Click(object sender, EventArgs e)
        {
            AllCounsellingForm form= new AllCounsellingForm();
            form.Show();
        }

        private void btnCounselling_Click(object sender, EventArgs e)
        {
            CounsellingForm form = new CounsellingForm();
            form.Show();
        }

        private void btnAllExpenditure_Click(object sender, EventArgs e)
        {
            AllExpenditureForm form= new AllExpenditureForm();
            form.Show();
        }

        private void btnAllclockingIn_Click(object sender, EventArgs e)
        {
            AllClockingInForm form= new AllClockingInForm();
            form.Show();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (txtDate.Text != "" && txtPatientId.Text != "")
            {
                try
                {
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string[] patientId = new string[4];
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "select * from medical_history where date_medical_history = '" + date + "' AND patient_id = " + txtPatientId.Text;
                    cmd = new SqlCommand(sql, cnn);
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            patientId[i] = dataReader.GetValue(i) + "";
                        }
                    }
                    if (patientId[1] == null)
                    {
                        MessageBox.Show("!سابقه ای با این شناسه پیدا نشد");
                    }
                    else
                    {
                        int index = patientId[1].IndexOf(' ');
                        string date2 = patientId[1].Substring(0, index);
                        date2 = Gregorian_to_jalali(date2);
                        patientId[1] = date2;
                        string output = "";
                        for (int i = 3; i > -1; i--)
                        {
                            output = output + "\u200F" + patientId[i] + " - ";
                        }
                        output = output.Substring(0, output.Length - 2);
                        MessageBox.Show(output);
                    }
                    dataReader.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show(".هم شناسه پرونده بیمار و هم تاریخ باید مشخص باشند");
        }

        private void btnDelHistory_Click(object sender, EventArgs e)
        {
            if (txtDate.Text != "" && txtPatientId.Text != "")
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    string date = txtDate.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "delete from medical_history where patient_id = " + txtPatientId.Text + " AND date_medical_history = '" + date + "'";
                    cmd = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("!عملیات با موفقیت انجام شد");
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show(".هم شناسه پرونده بیمار و هم تاریخ باید مشخص باشند");
        }

        private void DoctorLoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                txtBoxOrderId.Text = "";
                txtDate.Text = "";
                txtPatientId.Text = "";
            }
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
        }

        private void btnAllSecretary_Click(object sender, EventArgs e)
        {
            AllSecretaryForm form = new AllSecretaryForm();
            form.Show();
        }

        private void btnAllDoctor_Click(object sender, EventArgs e)
        {
            AllDoctorForm form = new AllDoctorForm();
            form.Show();
        }
    }
}
