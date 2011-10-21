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
    public partial class PositionsForm : Form
    {
        private readonly string _accountName;

        public PositionsForm(string accountName)
        {
            _accountName = accountName;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            var rest = ContextRegistry.GetContext().GetObject("restTemplate") as RestTemplate;
            var outstandingShares = rest.GetForObject<IEnumerable<Position>>("/home/Position");

            foreach (var share in outstandingShares)
            {
                currentPositionsListBox.Items.Add(string.Format("{0}: {1}", share.Symbol, share.Shares));
            }

        }
    }
}
