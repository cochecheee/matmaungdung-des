using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace demo_des
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        // kết nối ứng dụng của mình với dịch vụ Firebase
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "C4n3cmu3NJVytNiNwmOt1lSiyknFm2GakZXJXsr5",
            BasePath = "https://fir-des-647b5-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;
        des d = new des();
        //key
        ulong K1 = 0xF813;
        ulong K2 = 0x5678;

        private void btn_logintab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_signuptab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra nhập đầy đủ thông tin chưa
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_pass.Text) || string.IsNullOrEmpty(txt_phone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đù thông tin đề đăng kí tài khoản..");
                return;
            }
            else
            {
                //cập nhật mã hóa password des
                string encPass = d.mahoachuoi(txt_pass.Text.ToString(),K1,K2);

                var dk = new dangki()
                {
                    Name = txt_name.Text,
                    Phone = txt_phone.Text,
                    Password = encPass,
                };
                //cập nhật dữ liệu lên cơ sở dữ liệu Firebase
                FirebaseResponse response = client.Set("users/" + txt_phone.Text, dk);
                dangki result = response.ResultAs<dangki>();
                MessageBox.Show("Update thành công");
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đù thông tin đề đăng kí tài khoản..");
                return;
            }
            else
            {
                FirebaseResponse response = client.Get("users/");
                Dictionary<string, dangki> result = response.ResultAs<Dictionary<string, dangki>>();    
                foreach(var u in result)
                {
                    string username = u.Value.Name;
                    string password = u.Value.Password;
                    string decPass = d.giaimachuoi(password, K1, K2);
                    if(txt_username.Text == username && txt_pass.Text == decPass) //them pass
                    {
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                }
            }
        }
    }
}
