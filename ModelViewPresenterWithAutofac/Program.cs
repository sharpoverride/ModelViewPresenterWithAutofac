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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Register stuff
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Register<ILoginPresenter>(c => new LoginPresenter(c.Resolve<ILoginView>()));
            containerBuilder.Register<ILoginView>(c => new LoginView(c.Resolve<ILoginPresenter>));

            // start app
            var container = containerBuilder.Build();
            var presenter = container.Resolve<ILoginPresenter>();


            // Has to be called after the Visual styles etc calls
            presenter.ShowForm();

            Application.Run();
        }

        private static void StartApplication()
        {
        }
    }
}
