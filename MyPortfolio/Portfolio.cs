using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPortfolio
{
    public partial class Portfolio : Form
    {
        private ITradesBusinessLogic _tradesBusinessLogic;
        private IPortfolioPerformanceBusinessLogic _portfolioPerformanceBusinessLogic;
        private IPortfolioBusinessLogic _portfolioBusinessLogic;
        private IStockInformationRepository _stockInformationRepository;
        private Timer PerformanceDataPollingTimer = new Timer();
        private int _portfolioId = 0;
        public Portfolio(ITradesBusinessLogic tradesBusinessLogic,
                        IPortfolioPerformanceBusinessLogic portfolioPerformanceBusinessLogic,
                        IStockInformationRepository stockInformationRepository,
                        int portfolioId)
        {
            _tradesBusinessLogic = tradesBusinessLogic;
            _portfolioPerformanceBusinessLogic = portfolioPerformanceBusinessLogic;
            _stockInformationRepository = stockInformationRepository;
            _portfolioId = portfolioId;

            InitializeComponent();

            this.CenterToScreen();
            this.Load += new EventHandler(Portfolio_Load);
        }


        #region Events
        private async void Portfolio_Load(object sender, EventArgs e)
        {
            // Bind only first tab data
            await BindTradesData();
        }

        private async void AddTrade_Click(object sender, EventArgs e)
        {
            //ToDo: Peform validation
            var newTrade = new Trade()
            {
                Ticker = Ticker.SelectedItem.ToString(),
                Quantity = int.Parse(Quantity.Text),
                Price = float.Parse(Price.Text),
                TradeType = (DataAccess.TradeType)(TradeType.SelectedIndex),
                TradeDate = DateTime.Now,               
            };

            await _tradesBusinessLogic.Add(_portfolioId, newTrade);

            // Re-bind latest trades data
            await BindTradesData();

            //Finally clear form fields
            ClearFields();
        }

        private async void PortfolioTabControl_SelectedIndexchanged(object sender, EventArgs e)
        {

            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    await BindTradesData();
                    ResetPerformanceDataPollingTimer();
                    break;
                case 1:
                    await BindPortfolioPerformanceData();
                    StartPerformanceDataPollingTimer();
                    break;
            }
        }

        private async void Ticker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ticker.SelectedItem != null)
            {
                var stockQuote = await _stockInformationRepository.GetStockQuote(Ticker.SelectedItem.ToString());
                if (stockQuote != null)
                {
                    Price.Text = stockQuote.CurrentPrice.ToString(); ;
                }
            }
        }

        private async void PerformanceDataPollingTimer_Tick(object sender, EventArgs e)
        {
            await BindPortfolioPerformanceData();
        }
        #endregion

        #region Helpers
        public async Task BindTradesData()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = await _tradesBusinessLogic.GetTrades(_portfolioId);
            TradesGridView.DataSource = bindingSource;
        }

        public async Task BindPortfolioPerformanceData()
        {
            // Get trades data (this is a candidate for caching to avoid frequent reads from data store
            var trades = await _tradesBusinessLogic.GetTrades(_portfolioId);

            // Bind the performance by ticker/symbol data
            var bindingSource = new BindingSource();
            var portfolioPerformanceSummary = await _portfolioPerformanceBusinessLogic.GetTradesPerformanceSummary(trades);
            bindingSource.DataSource = portfolioPerformanceSummary.PortfolioPerformances;
            PortfolioPerformanceGridView.DataSource = bindingSource;

            // Bind profile performance summary
            NetProfitValueLabel.Text = string.Format("{0:C}", portfolioPerformanceSummary.NetProfits);
            TotalInvestmentLabel.Text = string.Format("{0:C}", portfolioPerformanceSummary.TotalInvestedAmount);
            NumberOfInvestmentsLabel.Text = portfolioPerformanceSummary.TotalNumberOfInvestments.ToString();
        }

        public void ClearFields()
        {
            Ticker.SelectedIndex = -1;
            TradeType.SelectedIndex = -1;
            Quantity.Text = string.Empty;
            Price.Text = string.Empty;
        }

        public void StartPerformanceDataPollingTimer()
        {
            //ToDo: try parse instead of convert to int as a general practice
            var pollingInterval = ConfigurationManager.AppSettings["PollingIntervalInMinutes"];

            PerformanceDataPollingTimer = new Timer();
            PerformanceDataPollingTimer.Interval = (Convert.ToInt32(pollingInterval) * 60 * 1000); // 1 minutes
            PerformanceDataPollingTimer.Tick += new EventHandler(PerformanceDataPollingTimer_Tick);
            PerformanceDataPollingTimer.Start();
        }

        public void ResetPerformanceDataPollingTimer()
        {
            PerformanceDataPollingTimer.Stop();
            PerformanceDataPollingTimer.Dispose();
        }
        public void Validate()
        {

        }
        #endregion
    }
}
