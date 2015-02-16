using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenterWithAutofac
{
    interface ILoginView
    {
         string User { get; }
         string Password { get; }

         void Login(LoginModel login);
         void Cancel();

         void ShowView();
         void Close();
    }
}
