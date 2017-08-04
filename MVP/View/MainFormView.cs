using System;
using System.Windows.Forms;

namespace MVP.View
{
    public partial class MainFormView : Form, IMainFormView
    {
        public MainFormView()
        {
            InitializeComponent();
            //Testing for event-related activities
            //  - Testing that someone is listening to an event
                
            //  - Testing that someone is triggering an event
        }

        public TextBox TextBoxInput
        {
            get { return txtInput; }
            set { txtInput = value; }
        }

        public event EventHandler ButtonOkClicked
        {
            add { btnOK.Click += value; }
            remove { btnOK.Click -= value; }
        }
            

        public Label LabelResult
        {
            get { return lblResult; }
            set { lblResult = value; }
        }
        public Button ButtonOk
        {
            get { return btnOK; }
            set { btnOK = value; }
        }

        public void ShowResult(string text)
        {
            lblResult.Text = text;
        }
    }
}
