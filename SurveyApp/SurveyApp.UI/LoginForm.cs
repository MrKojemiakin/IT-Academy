using SurveyApp.BL.Services;
using SurveyApp.Data.Repository;
using SurveyApp.Interfaces.BL;
using SurveyApp.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyApp.UI
{
    public partial class LoginForm : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }


        private ISurveyService surveyService;
        public LoginForm()
        {
            InitializeComponent();
            surveyService = new SurveyService(new SurveyRepository());

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.UserPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(47, 98);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(78, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // UserPass
            // 
            this.UserPass.AutoSize = true;
            this.UserPass.Location = new System.Drawing.Point(47, 152);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(70, 20);
            this.UserPass.TabIndex = 1;
            this.UserPass.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 27);
            this.textBox1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginButton.Location = new System.Drawing.Point(180, 212);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(172, 41);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login/Register";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 27);
            this.textBox2.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(501, 291);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("UserName/Password cannot be empty","Validation",MessageBoxButtons.OK);
                this.DialogResult=DialogResult.None;
                return;
            }
            Login= textBox1.Text;
            Password= textBox2.Text;
            this.DialogResult = loginButton.DialogResult;
        }
    }
}
