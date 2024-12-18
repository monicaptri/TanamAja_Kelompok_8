using System;
using System.Windows.Forms;

namespace TanamAja.App.View
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            LoadLoginForm();
        }

        private void AddUserControl(UserControl userControl)
        {
            // Mengatur UserControl agar mengisi panel
            userControl.Dock = DockStyle.Fill;
            tempatLogin.Controls.Clear();
            tempatLogin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void LoadLoginForm()
        {
            UC_Login loginForm = new UC_Login();
            loginForm.RegisterClicked += UCLogin_RegisterClicked;
            AddUserControl(loginForm);
        }

        private void LoadRegisterForm()
        {
            UC_Register registerForm = new UC_Register();
            registerForm.LoginClicked += UCRegister_LoginClicked;
            AddUserControl(registerForm);
        }

        public void UCLogin_RegisterClicked(object sender, EventArgs e)
        {
            LoadRegisterForm();
        }

        public void UCRegister_LoginClicked(object sender, EventArgs e)
        {
            LoadLoginForm();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
