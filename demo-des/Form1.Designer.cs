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
            mainPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainPage
            // 
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
            mainPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_des_result);
            groupBox2.Controls.Add(label4);
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
            txt_des_result.Size = new Size(344, 98);
            txt_des_result.TabIndex = 1;
            txt_des_result.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Result";
            // 
            // btn_des_giaima
            // 
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
            label2.Size = new Size(33, 20);
            label2.TabIndex = 0;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(mainPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(584, 613);
            tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 613);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            mainPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage mainPage;
        private GroupBox groupBox2;
        private RichTextBox txt_des_result;
        private Label label4;
        private Button btn_des_mahoa;
        private GroupBox groupBox1;
        private TextBox txt_des_key;
        private Label label2;
        private Label label1;
        private TabControl tabControl;
        private Button btn_des_giaima;
        private RichTextBox txt_des_text;
    }
}
