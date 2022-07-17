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
    public partial class SecretaryForm : Form
    {
        bool updateSecretary = false;

        public SecretaryForm()
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
                string[] secretaryId = new string[5];
                string sql = "select * from secretary where personnel_id_secretary = " + txtIdUpdate.Text;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        secretaryId[i] = dataReader.GetValue(i) + "";
                    }
                }
                if (secretaryId[1] == null)
                {
                    MessageBox.Show("!دکتری با این شماره پرسنلی پیدا نشد");
                }
                else
                {
                    if (txtPassUpdate.Text == secretaryId[4])
                    {
                        txtId.Text = secretaryId[0];
                        txtName.Text = secretaryId[1];
                        txtFamilyName.Text = secretaryId[2];
                        txtPhone.Text = secretaryId[3];
                        txtPass.Text = secretaryId[4];
                        updateSecretary = true;
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
                string[] secretaryId = new string[5];
                string sql = "select * from secretary where personnel_id_secretary = " + txtIdUpdate.Text;
                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        secretaryId[i] = dataReader.GetValue(i) + "";
                    }
                }
                dataReader.Close();
                cmd.Dispose();
                if (secretaryId[1] == null)
                {
                    MessageBox.Show("!دکتری با این شماره پرسنلی پیدا نشد");
                }
                else
                {
                    if (txtPassUpdate.Text == secretaryId[4])
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        sql = "delete from secretary where personnel_id_secretary = " + txtIdUpdate.Text;
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

        private void btnInsertSecretary_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            if (updateSecretary)
            {
                try
                {
                    sql = "update secretary set personnel_id_secretary = " + txtId.Text + ", name_secretary = N'" + txtName.Text +
                        "', family_name_secretary = N'" + txtFamilyName.Text + "', contact_number_secretary = N'" + txtPhone.Text +
                        "', password_secretary = '" + txtPass.Text + "' where personnel_id_secretary = " + txtId.Text;
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
                    sql = "insert into secretary (personnel_id_secretary,name_secretary,family_name_secretary,contact_number_secretary,password_secretary)values(" +
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
