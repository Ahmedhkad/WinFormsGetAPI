
using ServerLibrary;

namespace WinFormsClassTest
{
    public partial class ServerUI : Form
    {
        private readonly TestServerLibrary server = new();
        public ServerUI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Created by Ahmed Alomairi");
        }

        private async void buttonGetHttp_Click(object sender, EventArgs e)
        {
            respondTextBox.Text = "";
            StatusLabelDown.Text = "Trying ...";
            try
            {
                
                respondTextBox.Text = await server.CallServer("https://www.timeapi.io/api/time/current/zone?timeZone=Europe%2FAmsterdam");
                StatusLabelDown.Text = "Done";

            }
            catch (Exception ex)
            {
                respondTextBox.Text = "Error: " + ex.Message;
                StatusLabelDown.Text = "Error: " ;

            }
        }
    }
}
