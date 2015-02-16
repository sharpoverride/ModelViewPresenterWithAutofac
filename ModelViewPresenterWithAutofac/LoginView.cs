using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewPresenterWithAutofac
{
    public partial class LoginView : Form, ILoginView
    {
        private Func<ILoginPresenter> _loginPresenterFactory;

        public LoginView(Func<ILoginPresenter> loginPresenterFactory)
        {
            InitializeComponent();

            _loginPresenterFactory = loginPresenterFactory;
        }



        public string User
        {
            get { throw new NotImplementedException(); }
        }

        public string Password
        {
            get { throw new NotImplementedException(); }
        }

        public void Login(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void ShowView()
        {
            this.Show();
        }

    }
}
