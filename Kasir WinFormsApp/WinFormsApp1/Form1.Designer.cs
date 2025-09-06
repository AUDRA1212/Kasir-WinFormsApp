namespace WinFormsApp1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnlogin = new Button();
            txtuser = new TextBox();
            label2 = new Label();
            txtpassword = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(37, 218);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(307, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(118, 86);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(226, 27);
            txtuser.TabIndex = 0;
            txtuser.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(118, 139);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(226, 27);
            txtpassword.TabIndex = 1;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(279, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 292);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(100, 139);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 86);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 5;
            label3.Text = ":";
            // 
            // label5
            // 
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(77, 9);
            label5.Name = "label5";
            label5.Size = new Size(228, 36);
            label5.TabIndex = 6;
            label5.Text = "WM 29";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(862, 617);
            Controls.Add(groupBox1);
            ForeColor = Color.FromArgb(128, 64, 64);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnlogin;
        private TextBox txtuser;
        private Label label2;
        private TextBox txtpassword;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}
