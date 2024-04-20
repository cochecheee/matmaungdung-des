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
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion event

       
    }
} 