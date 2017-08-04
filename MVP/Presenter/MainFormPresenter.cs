using System;
using MVP.View;

namespace MVP.Presenter
{
   public class MainFormPresenter
    {
        private IMainFormView _view;

        public MainFormPresenter(IMainFormView view)
        {
            this._view = view;
            this._view.ButtonOkClicked += ViewOnButtonOkClicked;
        }

        private void ViewOnButtonOkClicked(object sender, EventArgs eventArgs)
        {
            _view.ShowResult(_view.TextBoxInput.Text);
        }
    }
}
