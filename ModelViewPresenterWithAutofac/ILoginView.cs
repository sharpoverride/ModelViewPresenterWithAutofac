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

         void ShowView();

         event Action<string, string> Login;
         event Action CloseForm;

         void SetTitle(string title);
    }
}
