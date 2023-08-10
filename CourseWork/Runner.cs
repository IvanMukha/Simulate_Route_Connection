using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Models;
using CourseWork.Presenters;
using CourseWork.Views;

namespace CourseWork
{
    static class Runner
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Presenter presenter = new Presenter(new RouterSimulatorImpl(), new RoutingImpl());
            presenter.run();
        }
    }
}