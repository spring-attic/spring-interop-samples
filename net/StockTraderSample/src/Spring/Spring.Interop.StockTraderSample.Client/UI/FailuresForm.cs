using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spring.Interop.StockTraderSample.Client.UI
{
    public partial class FailuresForm : Form
    {
        private readonly string _accountName;

        public FailuresForm(string accountName)
        {
            _accountName = accountName;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
