
using ServerLibrary;
using ServerListenLibarary;
using System.Data;
using System.Text.Json;

namespace WinFormsClassTest
{
    public partial class ServerUI : Form
    {
        private readonly TestServerLibrary server = new();
        private HttpServer _server;

        public ServerUI()
        {
            InitializeComponent();
            _server = new HttpServer("http://localhost:5000/");
            _server.OnRequestReceived += ReadData; // Use ReadData for request handling
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
                StatusLabelDown.Text = "Error: ";

            }
        }
        private void buttonStartLIsten_Click(object sender, EventArgs e)
        {
            respondTextBox.Text = "";
            StatusLabelDown.Text = "Trying Listining...";
            try
            {
                _server.Start();
                StatusLabelDown.Text = "Server started";

                respondTextBox.Text = "Server started. Press Enter to stop... http://localhost:5000/";


            }
            catch (Exception ex)
            {
                respondTextBox.Text = "Error: " + ex.Message;
                StatusLabelDown.Text = "Error: ";

            }

        }

        private void buttonStopListning_Click(object sender, EventArgs e)
        {
            _server.Stop();
            StatusLabelDown.Text = "Server stopped.";
        }

        private void ReadData(string jsonData)
        {
            if (IsValidJson(jsonData))
            {
                try
                {
                    using (JsonDocument doc = JsonDocument.Parse(jsonData))
                    {
                        JsonElement root = doc.RootElement;
                        DataTable table = new DataTable();
                        table.Columns.Add("Key", typeof(string));
                        table.Columns.Add("Value", typeof(string));

                        if (root.ValueKind == JsonValueKind.Object)
                        {
                            foreach (JsonProperty property in root.EnumerateObject())
                            {
                                DataRow row = table.NewRow();
                                row["Key"] = property.Name;
                                row["Value"] = property.Value.ToString();
                                table.Rows.Add(row);
                            }
                        }

                        // Use Invoke to update the DataGridView and TextBox on the UI thread
                        dataGridView.Invoke((MethodInvoker)(() =>
                        {
                            dataGridView.DataSource = table; 
                        }));

                        respondTextBox.Invoke((MethodInvoker)(() =>
                        {
                            respondTextBox.AppendText("Valid JSON Data Received and displayed in table.\n");
                        }));
                    }
                }
                catch (JsonException ex)
                {
                    respondTextBox.Invoke((MethodInvoker)(() =>
                    {
                        respondTextBox.AppendText($"An error occurred during JSON parsing: {ex.Message}\n");
                    }));
                }
            }
            else
            {
                respondTextBox.Invoke((MethodInvoker)(() =>
                {
                    respondTextBox.AppendText("Invalid JSON Data received.\n");
                }));
            }
        }

        // Method to check if a string is valid JSON
        private bool IsValidJson(string jsonString)
        {
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                return false;
            }

            try
            {
                JsonDocument.Parse(jsonString);
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }

        
    }

}
