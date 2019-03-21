#region License

/*
 * Copyright 2002-2009 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
using System.Collections;
using Common.Logging;
using Spring.Interop.StockTraderSample.Client.Gateways;
using Spring.Interop.StockTraderSample.Common.Data;

namespace Spring.Interop.StockTraderSample.Client.UI
{
    /// <summary>
    /// Handles requests from the UI and forwards them to the remote service.  Messages recieved from
    /// the service routed through this contcroller to update the UI. 
    /// </summary>
    /// <author>Mark Pollack</author>
    /// <author>Don McRae</author>
    public class StockController
    {

        private readonly ILog log = LogManager.GetLogger(typeof(StockController));

        private StockForm stockForm;

        private IStockServiceGateway stockService;
        private int _nextRequest;

        public StockForm StockForm
        {
            get { return stockForm; }
            set { stockForm = value; }
        }

        public IStockServiceGateway StockService
        {
            get { return stockService; }
            set { stockService = value; }
        }

        public void SendTradeRequest(string symbol, int quantity, string account, bool buyRequest)
        {
            TradeRequest tradeRequest = new TradeRequest();
            tradeRequest.AccountName = account;
            tradeRequest.BuyRequest = buyRequest;
            tradeRequest.OrderType = "MARKET";
            tradeRequest.Quantity = quantity;
            tradeRequest.RequestId = NextRequest();
            tradeRequest.Ticker = symbol;
            tradeRequest.UserName = "Joe Trader";
            
            log.Info("Sending TradeRequest: " + tradeRequest);
            stockService.Send(tradeRequest);
        }

        private string NextRequest()
        {
            _nextRequest++;
            return string.Format("REQ-{0}", _nextRequest);
        }

        public void UpdateMarketData(Quote quote)
        {
            if (stockForm != null)
            {
                stockForm.UpdateMarketData(quote);
            }
        }

        public void UpdateTrade(TradeResponse tradeResponse)
        {
            if (stockForm != null)
            {
                stockForm.UpdateTrade(tradeResponse);
            }
        }


    }
}