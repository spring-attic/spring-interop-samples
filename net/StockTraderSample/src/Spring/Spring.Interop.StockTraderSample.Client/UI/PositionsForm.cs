using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spring.Context.Support;
using Spring.Interop.StockTraderSample.Client.Repositories;
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
            accountLabel.Text = string.Format("Position Report for Account {0}", _accountName);

            var repository = ContextRegistry.GetContext().GetObject("PositionRepository") as PositionRepository;
            var shares = repository.GetAllShares();

            foreach (var position in shares)
            {
                currentPositionsListBox.Items.Add(string.Format("{0}: {1}", position.Symbol, position.Shares));
            }

        }
    }
}
