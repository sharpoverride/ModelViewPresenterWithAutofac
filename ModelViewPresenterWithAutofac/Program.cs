using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewPresenterWithAutofac
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new ContainerBuilder();
            container.Register<ILoginPresenter>(c => new LoginPresenter(c.Resolve<ILoginView>()));
            container.Register<ILoginView>(c => new LoginView(c.Resolve<ILoginPresenter>));
            StartApplication();
        }

        private static void StartApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }
    }
}
