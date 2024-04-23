using System.Text;

namespace demo_des
{
    public partial class Form1 : Form
    {
        private des DES;
        public Form1()
        {
            InitializeComponent();

        }

        #region event
        private void btn_des_mahoa_Click(object sender, EventArgs e)
        {
            DES = new des();
            try
            {
                //check dữ liệu đầu vào 
                string text = txt_des_text.Text;
                string key = txt_des_key.Text;
                string plain = txt_des_result.Text;

                txt_des_result.Clear();
                if (string.IsNullOrWhiteSpace(txt_des_key.Text) || string.IsNullOrWhiteSpace(txt_des_text.Text) || key.Length != 8)
                {
                    MessageBox.Show("Điền chuỗi hợp lệ vô ok..");
                    return;
                }
                else
                {
                    //thực hiện sang hexa
                    ulong K = DES.ConvertStrToHexa(key);
                    ulong K1 = DES.chiathanh2nua(K, 0, 32);
                    ulong K2 = DES.chiathanh2nua(K, 32, 64);
                    string res = DES.mahoachuoi(text, K1, K2);

                    txt_des_result.Text = res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_des_giaima_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txt_des_text.Text;
                string key = txt_des_key.Text;
                txt_des_result.Clear();
                if (string.IsNullOrWhiteSpace(txt_des_key.Text) || string.IsNullOrWhiteSpace(txt_des_text.Text) || key.Length != 8)
                {
                    MessageBox.Show("Điền chuỗi hợp lệ vô ok..");
                    return;
                }
                else
                {
                    //thực hiện sang hexa
                    ulong K = DES.ConvertStrToHexa(key);
                    ulong K1 = DES.chiathanh2nua(K, 0, 32);
                    ulong K2 = DES.chiathanh2nua(K, 32, 64);
                    string res = DES.giaimachuoi(text, K1, K2);

                    txt_des_result.Text = res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion event




        private void btn_3des_mahoa_Click(object sender, EventArgs e)
        {
            //check input dau vao
            if (string.IsNullOrEmpty(txt_3des_text.Text) || string.IsNullOrEmpty(txt_3des_key1.Text) ||
                string.IsNullOrEmpty(txt_3des_key2.Text) || string.IsNullOrEmpty(txt_3des_key3.Text))
            {
                MessageBox.Show("Nhập đầy đủ các thông tin để mã hóa...");
                return;
            }
            else
            {
                string plain = txt_3des_text.Text;
                string key1 = txt_3des_key1.Text;
                string key2 = txt_3des_key2.Text;
                string key3 = txt_3des_key3.Text;
                string res = _3des.Mahoa3DES(plain, key1, key2, key3);

                txt_3des_result.Text = res;
            }
        }

        private void btn_3des_giaima_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_3des_text.Text) || string.IsNullOrEmpty(txt_3des_key1.Text) ||
                string.IsNullOrEmpty(txt_3des_key2.Text) || string.IsNullOrEmpty(txt_3des_key3.Text))
            {
                MessageBox.Show("Nhập đầy đủ các thông tin để mã hóa...");
                return;
            }
            else
            {
                string cipher = txt_3des_text.Text;
                string key1 = txt_3des_key1.Text;
                string key2 = txt_3des_key2.Text;
                string key3 = txt_3des_key3.Text;
                string res = _3des.Giaima3DES(cipher, key1, key2, key3);

                txt_3des_result.Text = res;
            }
        }

        
    }
} 