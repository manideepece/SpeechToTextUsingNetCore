using System.Windows.Forms;
using SpeechToTextClassLibrary;

namespace SpeechToTextWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSpeaking_Click(object sender, System.EventArgs e)
        {
            var repository = new Repository();
            var output = repository.ReturnSpeech();
            lblText.Text = output;
        }
    }
}
