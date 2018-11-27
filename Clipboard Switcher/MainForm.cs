using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clipboard_Switcher
{
    public partial class MainForm : Form
    {
        private readonly PreviewForm _preview;
        public MainForm()
        {
            InitializeComponent();
            _preview = new PreviewForm(this);
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var lookFor = replaceBox.Text;
            if (lookFor.Length <= 0)
            {
                foundCount.Text = @"0";
                return;
            }
            var download = Clipboard.GetText();
            foundCount.Text = Regex.Matches(download, lookFor).Count.ToString();
            _preview.UpdatePreviewBox(lookFor, withBox.Text);
        }

        private void TextBox2TextChanged(object sender, EventArgs e)
        {
            _preview.UpdatePreviewBox(replaceBox.Text, withBox.Text);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (replaceBox.Text.Length <= 0) return;
            var download = Clipboard.GetText();
            string output;
            if (withBox.Text.Length == 0)
            {
                DialogResult confirmResult = MessageBox.Show($@"This will wipe all ""{replaceBox.Text}""", @"Confirm",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    output = download.Replace(replaceBox.Text, withBox.Text);
                    Clipboard.SetText(output);
                    replaceBox.Text = "";
                    withBox.Text = "";
                    foundCount.Text = @"Replaced";
                }
            }
            else
            {
                output = download.Replace(replaceBox.Text, withBox.Text);
                Clipboard.SetText(output);
                replaceBox.Text = "";
                withBox.Text = "";
                foundCount.Text = @"Replaced";
            }
            //_preview.UpdatePreviewBox();
        }

        public void PreviewButtom_Click(object sender=null, EventArgs e=null)
        {
            if (_preview.IsDisposed || !_preview.Visible)
            {
                _preview.Show();
                previewButtom.Text = @"Hide<<";
            }
            else
            {
                _preview.Hide();
                previewButtom.Text = @"Preview>>";

            }

            _preview.UpdatePreviewBox(replaceBox.Text, withBox.Text);
        }

        private void UpdatePreview(object sender, EventArgs e)
        {
            _preview.UpdatePreviewBox(replaceBox.Text, withBox.Text);
        }
    }
}
