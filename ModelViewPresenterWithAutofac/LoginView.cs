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
    internal partial class LoginView : Form, ILoginView
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

        public void ShowView()
        {
            this.Show();
        }


        public event Action<string, string> Login;

        public new event Action CloseForm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login != null)
            {
                Login("admin", "password");
            }
        }


        public void SetTitle(string title)
        {
            this.Text = title;
        }
    }
}
