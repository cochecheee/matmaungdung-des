namespace demo_des
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPage = new TabPage();
            groupBox2 = new GroupBox();
            txt_des_result = new RichTextBox();
            label4 = new Label();
            btn_des_giaima = new Button();
            btn_des_mahoa = new Button();
            groupBox1 = new GroupBox();
            txt_des_text = new RichTextBox();
            txt_des_key = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            txt_3des_result = new RichTextBox();
            label3 = new Label();
            btn_3des_giaima = new Button();
            btn_3des_mahoa = new Button();
            groupBox4 = new GroupBox();
            txt_3des_text = new RichTextBox();
            txt_3des_key3 = new TextBox();
            label8 = new Label();
            txt_3des_key2 = new TextBox();
            label7 = new Label();
            txt_3des_key1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            mainPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // mainPage
            // 
            mainPage.BackColor = Color.LightSteelBlue;
            mainPage.Controls.Add(groupBox2);
            mainPage.Controls.Add(btn_des_giaima);
            mainPage.Controls.Add(btn_des_mahoa);
            mainPage.Controls.Add(groupBox1);
            mainPage.Location = new Point(4, 29);
            mainPage.Name = "mainPage";
            mainPage.Padding = new Padding(3);
            mainPage.Size = new Size(576, 580);
            mainPage.TabIndex = 0;
            mainPage.Text = "DES";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_des_result);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 359);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(501, 189);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // txt_des_result
            // 
            txt_des_result.Location = new Point(80, 50);
            txt_des_result.Name = "txt_des_result";
            txt_des_result.ReadOnly = true;
            txt_des_result.Size = new Size(372, 98);
            txt_des_result.TabIndex = 1;
            txt_des_result.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "Result";
            // 
            // btn_des_giaima
            // 
            btn_des_giaima.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_des_giaima.Location = new Point(410, 254);
            btn_des_giaima.Name = "btn_des_giaima";
            btn_des_giaima.Size = new Size(124, 29);
            btn_des_giaima.TabIndex = 2;
            btn_des_giaima.Text = "Giải mã";
            btn_des_giaima.UseVisualStyleBackColor = true;
            btn_des_giaima.Click += btn_des_giaima_Click;
            // 
            // btn_des_mahoa
            // 
            btn_des_mahoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_des_mahoa.Location = new Point(221, 254);
            btn_des_mahoa.Name = "btn_des_mahoa";
            btn_des_mahoa.Size = new Size(124, 29);
            btn_des_mahoa.TabIndex = 2;
            btn_des_mahoa.Text = "Mã hóa";
            btn_des_mahoa.UseVisualStyleBackColor = true;
            btn_des_mahoa.Click += btn_des_mahoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_des_text);
            groupBox1.Controls.Add(txt_des_key);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 189);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // txt_des_text
            // 
            txt_des_text.Location = new Point(99, 26);
            txt_des_text.Name = "txt_des_text";
            txt_des_text.Size = new Size(353, 82);
            txt_des_text.TabIndex = 2;
            txt_des_text.Text = "";
            // 
            // txt_des_key
            // 
            txt_des_key.Location = new Point(99, 128);
            txt_des_key.Name = "txt_des_key";
            txt_des_key.Size = new Size(353, 27);
            txt_des_key.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 128);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 0;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(mainPage);
            tabControl.Controls.Add(tabPage1);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(584, 613);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(btn_3des_giaima);
            tabPage1.Controls.Add(btn_3des_mahoa);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(576, 580);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "3DES";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_3des_result);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(38, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(501, 189);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Output";
            // 
            // txt_3des_result
            // 
            txt_3des_result.Location = new Point(80, 50);
            txt_3des_result.Name = "txt_3des_result";
            txt_3des_result.ReadOnly = true;
            txt_3des_result.Size = new Size(372, 98);
            txt_3des_result.TabIndex = 1;
            txt_3des_result.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 53);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Result";
            // 
            // btn_3des_giaima
            // 
            btn_3des_giaima.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_3des_giaima.Location = new Point(415, 325);
            btn_3des_giaima.Name = "btn_3des_giaima";
            btn_3des_giaima.Size = new Size(124, 29);
            btn_3des_giaima.TabIndex = 5;
            btn_3des_giaima.Text = "Giải mã";
            btn_3des_giaima.UseVisualStyleBackColor = true;
            btn_3des_giaima.Click += btn_3des_giaima_Click;
            // 
            // btn_3des_mahoa
            // 
            btn_3des_mahoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_3des_mahoa.Location = new Point(227, 325);
            btn_3des_mahoa.Name = "btn_3des_mahoa";
            btn_3des_mahoa.Size = new Size(124, 29);
            btn_3des_mahoa.TabIndex = 6;
            btn_3des_mahoa.Text = "Mã hóa";
            btn_3des_mahoa.UseVisualStyleBackColor = true;
            btn_3des_mahoa.Click += btn_3des_mahoa_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_3des_text);
            groupBox4.Controls.Add(txt_3des_key3);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txt_3des_key2);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txt_3des_key1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(38, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(501, 288);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Input";
            // 
            // txt_3des_text
            // 
            txt_3des_text.Location = new Point(99, 26);
            txt_3des_text.Name = "txt_3des_text";
            txt_3des_text.Size = new Size(353, 82);
            txt_3des_text.TabIndex = 2;
            txt_3des_text.Text = "";
            // 
            // txt_3des_key3
            // 
            txt_3des_key3.Location = new Point(99, 231);
            txt_3des_key3.Name = "txt_3des_key3";
            txt_3des_key3.Size = new Size(353, 27);
            txt_3des_key3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 231);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 0;
            label8.Text = "Key 3";
            // 
            // txt_3des_key2
            // 
            txt_3des_key2.Location = new Point(99, 177);
            txt_3des_key2.Name = "txt_3des_key2";
            txt_3des_key2.Size = new Size(353, 27);
            txt_3des_key2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 177);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Key 2";
            // 
            // txt_3des_key1
            // 
            txt_3des_key1.Location = new Point(99, 128);
            txt_3des_key1.Name = "txt_3des_key1";
            txt_3des_key1.Size = new Size(353, 27);
            txt_3des_key1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 128);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 0;
            label5.Text = "Key 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 53);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 0;
            label6.Text = "Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 613);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Mã hóa DES";
            mainPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage mainPage;
        private GroupBox groupBox2;
        private RichTextBox txt_des_result;
        private Label label4;
        private Button btn_des_giaima;
        private Button btn_des_mahoa;
        private GroupBox groupBox1;
        private RichTextBox txt_des_text;
        private TextBox txt_des_key;
        private Label label2;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private RichTextBox txt_3des_result;
        private Label label3;
        private Button btn_3des_giaima;
        private Button btn_3des_mahoa;
        private GroupBox groupBox4;
        private RichTextBox txt_3des_text;
        private TextBox txt_3des_key3;
        private Label label8;
        private TextBox txt_3des_key2;
        private Label label7;
        private TextBox txt_3des_key1;
        private Label label5;
        private Label label6;
    }
}
