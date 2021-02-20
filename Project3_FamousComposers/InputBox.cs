using System;
using System.Windows.Forms;

namespace Project3_FamousComposers
{
    public partial class InputBox : Form
    {
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             InputBox
        ' Description:      Default constructor for InputBox form.
        '
        ' Date:             11/28/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public InputBox()
        {
            InitializeComponent();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             InputBox_Load()
        ' Description:
        ' 
        ' On Load event handler for the input box form, sets textbox as
        ' ActiveControl (focus.)
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/28/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void InputBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtInput;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnOK_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'OK'. Sets DialogueResult to
        ' DialogueResult.OK.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/28/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnCancel_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Cancel'. Sets DialogueResult to
        ' DialogueResult.Cancel.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             11/28/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             Input
        ' Description:
        ' 
        ' Get method for textbox input.
        ' 
        ' Return:           String txtInput.Text
        ' Date:             11/28/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public String Input
        {
            get { return txtInput.Text; }
        }

        public static DialogResult Show(String title, String message, String inputTitle, out String inputValue)
        {
            InputBox inputBox = null;
            DialogResult results = DialogResult.None;

            using (inputBox = new InputBox() { Text = title })
            {
                inputBox.lblMessage.Text = message;
                if (title.Contains("Delete"))
                    inputBox.lblDelete.Text = "Type delete to confirm.";
                results = inputBox.ShowDialog();
                inputValue = inputBox.Input;
            }
            return results;
        }
    }
}
