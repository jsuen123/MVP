using System;
using System.Windows.Forms;

namespace MVP.View
{
    public interface IMainFormView
    {
        Button ButtonOk { get; set; }
        Label LabelResult { get; set; }
        TextBox TextBoxInput { get; set; }
        event EventHandler ButtonOkClicked;
        void ShowResult(string text);
    }
}