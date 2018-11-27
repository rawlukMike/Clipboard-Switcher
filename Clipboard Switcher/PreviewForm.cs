using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Switcher
{
    public partial class PreviewForm : Form
    {
        private MainForm _main;
        public PreviewForm(MainForm main)
        {
            _main = main;
            InitializeComponent();
            UpdatePreviewBox();
            previewTextBox.DetectUrls = false;
            ControlBox = false;
            previewTextBox.AutoSize = true;
        }


        public void UpdatePreviewBox(string oldWord = "", string newWord= "")
        {
            try
            {
                var temp = Clipboard.GetText();
                if (oldWord.Length > 0) previewTextBox.Text = temp.Replace(oldWord, newWord);
                else previewTextBox.Text = temp;
            }
            catch
            {

            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _main.PreviewButtom_Click();
            }
        }
    }
}
