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
            //in some future sample, use this to get the positions for just this one account,
            // but for now just store it for future use
            _accountName = accountName;
            
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            var repository = ContextRegistry.GetContext().GetObject("PositionRepository") as PositionRepository;
            var shares = repository.GetAllShares();

            foreach (var share in shares)
            {
                currentPositionsListBox.Items.Add(string.Format("{0}: {1}", share.Symbol, share.Shares));
            }

        }
    }
}
