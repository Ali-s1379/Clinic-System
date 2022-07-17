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
    public partial class SecretaryLoginForm : Form
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

        public SecretaryLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogoutSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
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
                string[] patientId = new string[16];
                string sql = "select * from patient where patient_id = '" + txtPatientId.Text + "'";
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 16; i++)
                    {
                        patientId[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (patientId[1] == null)
                {
                    MessageBox.Show("!پرونده ای با این شناسه پیدا نشد");
                }
                else
                {
                    int index = patientId[4].IndexOf(' ');
                    string date = patientId[4].Substring(0, index);
                    date = Gregorian_to_jalali(date);
                    patientId[4] = patientId[4] = date; 
                    if (patientId[11] == "1")
                    {
                        patientId[11] = "مرد";
                    }
                    else
                    {
                        patientId[11] = "زن";
                    }
                    switch (patientId[14])
                    {
                        case "0":
                            patientId[14] = "زیر دیپلم";
                            break;
                        case "1":
                            patientId[14] = "دیپلم";
                            break;
                        case "2":
                            patientId[14] = "لیسانس";
                            break;
                        case "3":
                            patientId[14] = "فوق لیسانی";
                            break;
                        case "4":
                            patientId[14] = "دکترا";
                            break;
                    }
                    string output = "";
                    for (int i = 15; i > -1; i--)
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

        private void btnDelPatient_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "delete from patient where patient_id = " + txtPatientId.Text;
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

        private void btnViewCounselling_Click(object sender, EventArgs e)
        {
            if (txtDateCounselling.Text != "" && txtIdCounselling.Text != "")
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
                    string[] patientId = new string[9];
                    string date = txtDateCounselling.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "select * from counselling where date_counselling = '" + date + "' AND patient_id = " + txtIdCounselling.Text;
                    cmd = new SqlCommand(sql, cnn);
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            patientId[i] = dataReader.GetValue(i) + "";
                        }
                    }
                    if (patientId[1] == null)
                    {
                        MessageBox.Show("!جلسه ای با این شناسه پیدا نشد");
                    }
                    else
                    {
                        int index = patientId[0].IndexOf(' ');
                        string date2 = patientId[0].Substring(0, index);
                        date2 = Gregorian_to_jalali(date2);
                        patientId[0] = date2;
                        string output = "";
                        for (int i = 8; i > -1; i--)
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

        private void btnDelCounselling_Click(object sender, EventArgs e)
        {
            if (txtDateCounselling.Text != "" && txtIdCounselling.Text != "")
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
                    string date = txtDateCounselling.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "delete from counselling where patient_id = " + txtIdCounselling.Text + " AND date_counselling = '" + date + "'";
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

        private void btnViewClock_Click(object sender, EventArgs e)
        {
            if (txtDateClock.Text != "" && txtIdClock.Text != "")
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
                    string[] login = new string[5];
                    string date = txtDateClock.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "select * from clocking_in where login_date = '" + date + "' AND personnel_id_secretary = " + txtIdClock.Text;
                    cmd = new SqlCommand(sql, cnn);
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            login[i] = dataReader.GetValue(i) + "";
                        }
                    }
                    if (login[0] == null)
                    {
                        MessageBox.Show("!ورودی در این تاریخ پیدا نشد");
                    }
                    else
                    {
                        int index = login[0].IndexOf(' ');
                        string date2 = login[0].Substring(0, index);
                        login[0] = Gregorian_to_jalali(date2);
                        if (login[4] != "")
                        {
                            int index2 = login[4].IndexOf(' ');
                            string date3 = login[4].Substring(0, index);
                            login[4] = Gregorian_to_jalali(date3);
                        }
                        else login[4] = "null";
                        string output = "";

                            for (int i = 4; i > -1; i--)
                            {
                                output = output + "\u200F" + login[i] + " - ";
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
            else MessageBox.Show(".هم شماره پرسنلی و هم تاریخ باید مشخص باشند");
        }

        private void btnDelClock_Click(object sender, EventArgs e)
        {
            if (txtDateClock.Text != "" && txtIdClock.Text != "")
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
                    string date = txtDateClock.Text;
                    date = Jalali_to_gregorian(date);
                    string sql = "delete from clocking_in where personnel_id_secretary = " + txtIdClock.Text + " AND login_date = '" + date + "'";
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
            else MessageBox.Show(".هم شماره پرسنلی و هم تاریخ باید مشخص باشند");
        }

        private void btnViewExpenditure_Click(object sender, EventArgs e)
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
                string[] orderId = new string[5];
                string sql = "select * from expenditure where recipt_id = '" + txtRecipt.Text + "'";
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        orderId[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (orderId[1] == null)
                {
                    MessageBox.Show("!هزینه ای با این کد پیدا نشد");
                }
                else
                {
                    int index = orderId[4].IndexOf(' ');
                    string date = orderId[4].Substring(0, index);
                    orderId[4] = Gregorian_to_jalali(date);
                    string output = "";
                    for (int i = 4; i > -1; i--)
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

        private void btnDelExpenditure_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "delete from expenditure where recipt_id = " + txtRecipt.Text;
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

        private void btnClockingIn_Click(object sender, EventArgs e)
        {
            ClockingInForm clockingInForm = new ClockingInForm();
            clockingInForm.Show();
        }

        private void btnExpenditure_Click(object sender, EventArgs e)
        {
            ExpenditureForm expenditureForm = new ExpenditureForm();
            expenditureForm.Show();
        }

        private void btnAllclockingIn_Click(object sender, EventArgs e)
        {
            AllClockingInForm allClockingInForm = new AllClockingInForm();
            allClockingInForm.Show();
        }

        private void btnAllExpenditure_Click(object sender, EventArgs e)
        {
            AllExpenditureForm allExpenditureForms = new AllExpenditureForm();
            allExpenditureForms.Show();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm();
            secretaryForm.Show();
        }

        private void btnViewAllOrders_Click(object sender, EventArgs e)
        {
            AllOrdersForm allOrdersForm = new AllOrdersForm();
            allOrdersForm.Show();
        }

        private void btnAllSecretary_Click(object sender, EventArgs e)
        {
            AllSecretaryForm secretaryForm = new AllSecretaryForm();
            secretaryForm.Show();
        }

        private void btnAllDoctor_Click(object sender, EventArgs e)
        {
            AllDoctorForm allDoctorForms = new AllDoctorForm();
            allDoctorForms.Show();
        }

        private void btnAllPatient_Click(object sender, EventArgs e)
        {
            AllPatientsForm allPatientsForm = new AllPatientsForm();
            allPatientsForm.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void btnAllMedicalHistory_Click(object sender, EventArgs e)
        {
            AllMedicalHistoryForm allMedicalHistoryForm = new AllMedicalHistoryForm();
            allMedicalHistoryForm.Show();
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            MedicalHistoryForm medicalHistoryForm = new MedicalHistoryForm();
            medicalHistoryForm.Show();
        }

        private void btnAllCounselling_Click(object sender, EventArgs e)
        {
            AllCounsellingForm allCounsellingForms = new AllCounsellingForm();
            allCounsellingForms.Show();
        }

        private void btnCounselling_Click(object sender, EventArgs e)
        {
            CounsellingForm counsellingForms = new CounsellingForm();
            counsellingForms.Show();
        }
    }
}
