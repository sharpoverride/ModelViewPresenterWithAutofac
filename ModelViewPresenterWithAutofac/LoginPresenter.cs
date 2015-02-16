using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenterWithAutofac
{
    internal class LoginPresenter:ILoginPresenter
    {
        private ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
        }

        
    }
}
