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
    public partial class MainForm : Form
    {
        private ISurveyService surveyService;
        private IUserService userService;
        public MainForm()
        {
            InitializeComponent();
            var repository = new SurveyRepository();
            surveyService = new SurveyService(repository);
            userService = new UserService(repository);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            LoginUser(loginForm);
        }

        private void LoginUser(LoginForm loginForm)
        {
            loginForm.ShowDialog(this);
            
            if (loginForm.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            var loginResult = userService.LoginUser(loginForm.Login, loginForm.Password);

            if (UserService.CurrentUser == null)
            {
                var addUser = MessageBox.Show("Add new user", "AddUser", MessageBoxButtons.YesNo);
                if (addUser == DialogResult.Yes)
                {
                    var user = new UserDTO() { Login = loginForm.Login, Password = loginForm.Password };
                    user.Id=userService.AddUser(user);
                    UserService.CurrentUser= user;
                    loginResult = true;
                }
                else
                {
                    LoginUser(loginForm);
                }



            }

            if(UserService.CurrentUser != null&&loginResult==false) 
            {
                MessageBox.Show("Incorrect password");
                LoginUser(loginForm);
            }
            if (UserService.CurrentUser != null)
            {
                this.Text = UserService.CurrentUser.Login + (UserService.CurrentUser.IsAdmin ? "(Admin)" : String.Empty);
            }


            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserService.CurrentUser = null;
            this.Text = String.Empty;
            var loginForm = new LoginForm();
            LoginUser(loginForm);
        }
    }
}
