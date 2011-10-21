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
    public partial class OutstandingSharesForm : Form
    {
        private readonly string _accountName;

        public OutstandingSharesForm(string accountName)
        {
            _accountName = accountName;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OutstandingSharesForm_Load(object sender, EventArgs e)
        {
            var rest = ContextRegistry.GetContext().GetObject("restTemplate") as RestTemplate;
            var outstandingShares = rest.GetForObject<IEnumerable<OutstandingShares>>("/home/OutstandingShares");

            foreach (var share in outstandingShares)
            {
                outstandingSharesListBox.Items.Add(string.Format("{0}: {1}", share.Symbol, share.Shares));
            }

        }
    }
}
