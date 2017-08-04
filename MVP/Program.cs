using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MVP.Presenter;
using MVP.View;

namespace MVP
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
            MainFormView _view = new MainFormView();
            MainFormPresenter _presenter = new MainFormPresenter(_view);
            Application.Run(_view);
        }
    }
}
