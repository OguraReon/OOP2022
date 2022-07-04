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
        IEnumerable<string> xLink;
        public Form1() {
            InitializeComponent();
        }
        
        private void btRssGet_Click(object sender, EventArgs e) {
             
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle) {
                    lbRssTitle1.Items.Add(data);

                }
            }
        }

        private void lbRssTitle1_SelectedIndexChanged(object sender, EventArgs e) {
            int urlIndex = lbRssTitle1.SelectedIndex;
            if (urlIndex == -1) return;
            var url = xLink.ElementAt(urlIndex);
            wvBrowser.Source = new Uri(url);
        }

        private void btBack_Click(object sender, EventArgs e) {
            wvBrowser.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e) {
            wvBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackForwardMaskCheck();
        }

        private void BackForwardMaskCheck() {
            //進む・戻るボタンのマスク処理
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            BackForwardMaskCheck();
        }
    }
}
