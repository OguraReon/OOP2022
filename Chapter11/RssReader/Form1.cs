using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<string> xTitle;
        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var data in xTitle) {
                    lbRssTitle1.Items.Add(data);

                }


            }
        }

        private void lbRssTitle1_SelectedIndexChanged(object sender, EventArgs e) {
            int urlIndex = lbRssTitle1.SelectedIndex;

        }
    }
}
