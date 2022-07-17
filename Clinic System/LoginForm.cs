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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            bool login = false;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql = "";
            List<string> listId = new List<string>();
            List<string> listPass = new List<string>();
            int n = 0;
            sql = "select personnel_id_secretary,password_secretary from secretary";
            cmd = new SqlCommand(sql,cnn);
            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                listId.Add(dataReader.GetValue(0).ToString());
                listPass.Add((string)dataReader.GetValue(1));
                n++;
            }
            string[] outputId = listId.ToArray();
            string[] outputPass = listPass.ToArray();   
            for (int i = 0; i < n; i++)
            {
                if (txtUserId.Text == outputId[i])
                {
                    if (txtPass.Text == outputPass[i])
                    {
                        this.Hide();
                        SecretaryLoginForm f1 = new SecretaryLoginForm();
                        f1.Closed += (s, args) => this.Close();
                        f1.Show();
                        login = true;
                    }
                }
            }
            dataReader.Close();
            cmd.Dispose();

            listId = new List<string>();
            listPass = new List<string>();
            n = 0;
            sql = "select personnel_id_doctor,password_doctor from doctor";
            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listId.Add(dataReader.GetValue(0).ToString());
                listPass.Add((string)dataReader.GetValue(1));
                n++;
            }
            outputId = listId.ToArray();
            outputPass = listPass.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (txtUserId.Text == outputId[i])
                {
                    if (txtPass.Text == outputPass[i])
                    {
                        this.Hide();
                        DoctorLoginForm f2 = new DoctorLoginForm();
                        f2.Closed += (s, args) => this.Close();
                        f2.Show();
                        login = true;
                    }
                }
            }
            if (login == false)
            {
                MessageBox.Show("!نام کاربری یا کلمه عبور اشتباه می باشند");
            }
            cnn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUserId.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
