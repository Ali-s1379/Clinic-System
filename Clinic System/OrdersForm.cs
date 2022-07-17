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
    public partial class OrdersForm : Form
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

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void lblProductTypeOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertOrders_Click(object sender, EventArgs e)
        {
            bool update = false;
            string productType = "";
            if (cmbBoxProductType.Text == "اداری")
            {
                productType = "1";
            }
            if (cmbBoxProductType.Text == "پزشکی")
            {
                productType = "2";
            }
            if (txtOrderPrice.Text == "")
            {
                txtOrderPrice.Text = "null";
            }
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            List<string> listOrderId = new List<string>();
            int n = 0;
            sql = "select order_id from orders";
            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listOrderId.Add(dataReader.GetValue(0).ToString());
                n++;
            }
            string[] outputId = listOrderId.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (txtBoxOrderId.Text == outputId[i])
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
                    string date = txtBoxOrderDate.Text;
                    date = Jalali_to_gregorian(date);
                    sql = "update orders set PERSONNEL_ID_DOCTOR = " + txtBoxPersonnelIdDoctor.Text + ", PRODUCT_NAME = N'" +
                        txtBoxProductName.Text + "', PRODUCT_TYPE = " + productType + ", PRODUCT_NUMBER = " + txtBoxProductNumber.Text +
                        ", ORDER_DATE = '" + date + "', PRICE_ORDER = " + txtOrderPrice.Text + " where ORDER_ID = " + txtBoxOrderId.Text;
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
                    string date = txtBoxOrderDate.Text;
                    date = Jalali_to_gregorian(date);
                    sql = "insert into orders (ORDER_ID,PERSONNEL_ID_DOCTOR,PRODUCT_NAME,PRODUCT_TYPE,PRODUCT_NUMBER,ORDER_DATE,PRICE_ORDER) values(" +
                    txtBoxOrderId.Text + ", " + txtBoxPersonnelIdDoctor.Text + ", N'" + txtBoxProductName.Text + "', " + productType + ", " +
                    txtBoxProductNumber.Text + ", '" + date + "', " + txtOrderPrice.Text + ")";
                    cmd = new SqlCommand(sql, cnn);
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

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DRAGON;Initial Catalog=clinicDatabase;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd;
            SqlDataReader dataReader;
            string[] orderId = new string[7];
            string sql = "select * from orders where order_id = '" + txtBoxOrderIdUpdate.Text + "'";
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
                txtBoxOrderId.Text = orderId[0];
                txtBoxPersonnelIdDoctor.Text = orderId[1];
                txtBoxProductName.Text = orderId[2];
                if (orderId[3] == "1")
                {
                    cmbBoxProductType.Text = "اداری";
                }
                else
                {
                    cmbBoxProductType.Text = "پزشکی";
                }
                txtBoxProductNumber.Text = orderId[4];
                int index = orderId[5].IndexOf(' ');
                string date = orderId[5].Substring(0, index);
                date = Gregorian_to_jalali(date);
                txtBoxOrderDate.Text = date;
                txtOrderPrice.Text = orderId[6];
            } 
            dataReader.Close();
            cmd.Dispose();
        }
    }
}
