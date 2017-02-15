using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_web_browser
{
    public partial class ParentForm : Form
    {

        private List<History> history;

        public ParentForm()
        {
            InitializeComponent();
            this.history = new List<History>();
            navigate();
        }

        private void go_Click(object sender, EventArgs e)
        {
            navigate();
        }

        private void url_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigate();
            }
        }

        private void navigate()
        {
            string address = navBox.Text;

            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }

            try
            {
                simpleWebBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
            finally
            {
            }

        }

        private void addHistory(string address)
        {
            System.DateTime dateTime = DateTime.Now;
            this.history.Add(new History(address, dateTime));

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoSize = true;
            panel.Margin = new Padding(10);

            Label dateLabel = new Label();
            Label addressLabel = new Label();

            dateLabel.Text = dateTime.ToString();
            addressLabel.Text = address;
            addressLabel.AutoSize = true;

            panel.Controls.Add(dateLabel);
            panel.Controls.Add(addressLabel);
            flowLayoutPanel3.Controls.Add(panel);
        }

        private void exportHistory_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "history.json";
            dialog.Filter = "JSON File | *.json";

            Dictionary<string, List<History>> navigationHistory = new Dictionary<string, List<History>>();
            navigationHistory.Add("NavigationHistory", this.history);

            string json = JsonConvert.SerializeObject(navigationHistory);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != "")
                {
                    StreamWriter writer = new StreamWriter(dialog.OpenFile());
         
                    writer.Write(json);
                    writer.Dispose();
                    writer.Close();
                }
            }

        }

        private void updateNavBox(object sender, WebBrowserNavigatedEventArgs e)
        {
            string address = e.Url.ToString();
            navBox.Text = address;
            addHistory(address);
        }

    }
}
