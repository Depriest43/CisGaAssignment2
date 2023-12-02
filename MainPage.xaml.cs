using System.Runtime.CompilerServices;

namespace CisGaAssignment2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void btnDisplayShortMessage_Clicked(object sender, EventArgs e)
        {
            string displayMessage = entDisplayMessage.Text;
            editDisplay.Text = displayMessage;
        }
        private void btnAppendShortMessage_Clicked(object sender, EventArgs e)
        {
            string displayMessage = entDisplayMessage.Text;
            editDisplay.Text = displayMessage += displayMessage;
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {


            string longMessageToAppend = editUserLongMessage.Text;
            editDisplay.Text += longMessageToAppend;
            {
                entDisplayMessage.Text = "";
                editDisplay.Text = "";
                editUserLongMessage.Text = "";
            }
            

        }

        /*
         *     // This will append the message from our editor ( for long messages )
                private void btnAppendLongMessage_Clicked(object sender, EventArgs e)
                {
                    string longMessageToAppend = editUserLongMessage.Text;
                    editDisplay.Text += longMessageToAppend;
                }
         * 
         */

        private void btnAppendLongMessage_Clicked(object sender, EventArgs e)
        {
            string longMessageToAppend = editUserLongMessage.Text;
            editDisplay.Text += longMessageToAppend;
        }
     
    }

}
