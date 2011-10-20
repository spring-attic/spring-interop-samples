using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spring.Context.Support;
using Spring.Interop.StockTraderSample.Common.Data;
using Spring.Rest.Client;

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

        private void FailuresForm_Load(object sender, EventArgs e)
        {
            var rest = ContextRegistry.GetContext().GetObject("restTemplate") as RestTemplate;
            var failures = rest.GetForObject<IEnumerable<CreditCheckFailure>>("/home/CreditFailureReport");

            foreach (var failure in failures)
            {
                tradeFailuresListBox.Items.Add(failure);
            }

        }
    }
}
