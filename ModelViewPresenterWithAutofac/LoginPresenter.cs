using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewPresenterWithAutofac
{
    internal class LoginPresenter: ILoginPresenter
    {
        private ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;

            BindToEvents();
        }

        private void BindToEvents()
        {
            _view.Login += _view_Login;
        }

        void _view_Login(string user, string pass)
        {
            _view.SetTitle("Success");
        }

        public void ShowForm()
        {
            _view.ShowView(); 
        }
    }
}
