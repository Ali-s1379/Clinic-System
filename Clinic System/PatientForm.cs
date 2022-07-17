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
    public partial class PatientForm : Form
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

        public PatientForm()
        {
            InitializeComponent();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataReader dataReader;
            string[] patientId = new string[16];
            string sql = "select * from patient where patient_id = '" + txtPatientIdUpdate.Text + "'";
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
                txtPatientId.Text = patientId[0];
                txtName.Text = patientId[1];
                txtFamilyName.Text = patientId[2];
                txtPhone.Text = patientId[3];
                int index = patientId[4].IndexOf(' ');
                string date = patientId[4].Substring(0, index);
                date = Gregorian_to_jalali(date);
                txtLine.Text = patientId[5];
                txtVisitdate.Text = date;
                txtReferral.Text = patientId[6];
                txtNationalId.Text = patientId[7];
                txtBirthCir.Text = patientId[8];
                txtAdress.Text = patientId[9];
                txtAge.Text = patientId[10];
                if (patientId[11] == "1")
                {
                    cmboGender.Text = "مرد";
                }
                else
                {
                    cmboGender.Text = "زن";
                }
                txtInsurance.Text = patientId[12];
                txtJob.Text = patientId[13];
                switch (patientId[14])
                {
                    case "0":
                        cmboEdu.Text = "زیر دیپلم";
                        break;
                    case "1":
                        cmboEdu.Text = "دیپلم";
                        break;
                    case "2":
                        cmboEdu.Text = "لیسانس";
                        break;
                    case "3":
                        cmboEdu.Text = "فوق لیسانس";
                        break;
                    case "4":
                        cmboEdu.Text = "دکترا";
                        break;
                }
                txtOffspring.Text = patientId[15];
            }
            dataReader.Close();
            cmd.Dispose();
        }

        private void btnInsertPatient_Click(object sender, EventArgs e)
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
            int n = 0;
            sql = "select patient_id from patient";
            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listPatientId.Add(dataReader.GetValue(0).ToString());
                n++;
            }
            string[] outputId = listPatientId.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (txtPatientId.Text == outputId[i])
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
                    string date = txtVisitdate.Text;
                    date = Jalali_to_gregorian(date);
                    string gender = "";
                    string education = "";
                    if (cmboGender.Text == "مرد")
                    {
                        gender = "1";
                    }
                    else if (cmboGender.Text == "زن")
                    {
                        gender = "0";
                    }
                    switch (cmboEdu.Text)
                    {
                        case "زیر دیپلم":
                            education = "0";
                            break;
                        case "دیپلم":
                            education = "1";
                            break;
                        case "لیسانس":
                            education = "2";
                            break;
                        case "فوق لیسانس":
                            education = "3";
                            break;
                        case "دکترا":
                            education = "4";
                            break;
                    }
                    string refer = "";
                    string insurance = "";
                    if (txtReferral.Text == "")
                    {
                        refer = "null";
                    }
                    else refer = "N'" + txtReferral.Text + "'";
                    if (txtInsurance.Text == "")
                    {
                        insurance = "null";
                    }
                    else insurance = txtInsurance.Text;
                    sql = "update patient set patient_id = " + txtPatientId.Text + ", name_patient = N'" +
                        txtName.Text + "', family_name_patient = N'" + txtFamilyName.Text + "', contact_number_patient = '" + txtPhone.Text +
                        "', visit_date = '" + date + "', line_number = " + txtLine.Text + ", referral = " + refer +", national_id = "+
                        txtNationalId.Text +", birth_certificate_number = " + txtBirthCir.Text+", address = N'"+ txtAdress.Text +"', age = "+ txtAge.Text+ 
                        ", gender = "+ gender +", insurance_id = "+ insurance +", occupation = N'"+ txtJob.Text +"', education_degree = "+ education +
                        ", number_of_offsprings = "+ txtOffspring.Text+" where patient_id = " + txtPatientId.Text;
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
                    string date = txtVisitdate.Text;
                    date = Jalali_to_gregorian(date);
                    string gender = "";
                    string education = "";
                    if (cmboGender.Text == "مرد")
                    {
                        gender = "1";
                    }
                    else if (cmboGender.Text == "زن")
                    {
                        gender = "0";
                    }
                    switch (cmboEdu.Text)
                    {
                        case "زیر دیپلم":
                            education = "0";
                            break;
                        case "دیپلم":
                            education = "1";
                            break;
                        case "لیسانس":
                            education = "2";
                            break;
                        case "فوق لیسانس":
                            education = "3";
                            break;
                        case "دکترا":
                            education = "4";
                            break;
                    }
                    string refer = "";
                    string insurance = "";
                    if (txtReferral.Text == "")
                    {
                        refer = "null";
                    }
                    else refer = "N'" + txtReferral.Text + "'";
                    if (txtInsurance.Text == "")
                    {
                        insurance = "null";
                    }
                    else insurance = txtInsurance.Text;
                    sql = "insert into PATIENT (PATIENT_ID,NAME_PATIENT,FAMILY_NAME_PATIENT,CONTACT_NUMBER_PATIENT,VISIT_DATE," +
                        "LINE_NUMBER,REFERRAL,NATIONAL_ID,BIRTH_CERTIFICATE_NUMBER,ADDRESS,AGE,GENDER,INSURANCE_ID,OCCUPATION," +
                        "EDUCATION_DEGREE,NUMBER_OF_OFFSPRINGS)values(" + txtPatientId.Text +",N'" + txtName.Text+ "' , N'" +txtFamilyName.Text+ "' , N'" + 
                        txtPhone.Text + "' , '" + date + "' , " + txtLine.Text + " , " +refer + " , " + txtNationalId.Text + " , " +
                        txtBirthCir.Text + " , N'" +txtAdress.Text+ "' , " + txtAge.Text + " , " + gender + " , " + insurance + " , N'" +
                        txtJob.Text+ "' , " + education + " , " + txtOffspring.Text +" )";
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
