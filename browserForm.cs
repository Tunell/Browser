using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Browser
{
    public partial class browserForm : Form
    {
        UrlBrowser browser = new UrlBrowser();
        public browserForm()
        {
            InitializeComponent();
            
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            browserField.Text = browser.requestHomepage(urlField.Text);
        }

        private void urlField_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    goButton_Click(sender, e);
                    break;
            }
        }
    }
}
