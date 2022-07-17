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
    public partial class DoctorForm : Form
    {
        bool updateDoctor = false;
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (txtIdUpdate.Text != "" && txtPassUpdate.Text != "")
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string[] doctorId = new string[5];
                string sql = "select * from doctor where personnel_id_doctor = " + txtIdUpdate.Text ;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        doctorId[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (doctorId[1] == null)
                {
                    MessageBox.Show("!دکتری با این شماره پرسنلی پیدا نشد");
                }
                else
                {
                    if (txtPassUpdate.Text == doctorId[4])
                    {
                        txtId.Text = doctorId[0];
                        txtName.Text = doctorId[1];
                        txtFamilyName.Text = doctorId[2];
                        txtPhone.Text = doctorId[3];
                        txtPass.Text = doctorId[4];
                        updateDoctor = true;
                    }
                    else MessageBox.Show(".رمز عبور وارد شده غلط است");
                }
                dataReader.Close();
                cmd.Dispose();
            }
            else MessageBox.Show(".هم شماره پرسنلی و هم رمز عبور باید مشخص باشند");
        }

        private void btnDelDoctor_Click(object sender, EventArgs e)
        {
            if (txtIdUpdate.Text != "" && txtPassUpdate.Text != "")
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string[] doctorId = new string[5];
                string sql = "select * from doctor where personnel_id_doctor = " + txtIdUpdate.Text;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        doctorId[i] = dataReader.GetValue(i) + "";
                    }
                }
                dataReader.Close();
                cmd.Dispose();
                if (doctorId[1] == null)
                {
                    MessageBox.Show("!دکتری با این شماره پرسنلی پیدا نشد");
                }
                else
                {
                    if (txtPassUpdate.Text == doctorId[4])
                    {
                        
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        sql = "delete from doctor where personnel_id_doctor = " + txtIdUpdate.Text;
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
                    else MessageBox.Show(".رمز عبور وارد شده غلط است");
                }
            }
            else MessageBox.Show(".هم شماره پرسنلی و هم رمز عبور باید مشخص باشند");
        }

        private void btnInsertDoctor_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            if (updateDoctor)
            {
                try
                {
                    sql = "update doctor set personnel_id_doctor = " + txtId.Text + ", name_doctor = N'" + txtName.Text +
                        "', family_name_doctor = N'" + txtFamilyName.Text + "', contact_number_doctor = N'" + txtPhone.Text +
                        "', password_doctor = '" + txtPass.Text + "' where personnel_id_doctor = " + txtId.Text ;
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
                    sql = "insert into doctor (personnel_id_doctor,name_doctor,family_name_doctor,contact_number_doctor,password_doctor)values(" +
                        txtId.Text + ", N'" + txtName.Text + "', N'" + txtFamilyName.Text + "', N'" + txtPhone.Text + "', '" + txtPass.Text + "')";
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
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
