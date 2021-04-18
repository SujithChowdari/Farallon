using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Interfaces;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPortfolio
{
    public partial class BuildPortfolio : Form
    {
        private IPortfolioBusinessLogic _portfolioBusinessLogic;
        private ITradesBusinessLogic _tradesBusinessLogic;
        private IPortfolioPerformanceBusinessLogic _portfolioPerformanceBusinessLogic;
        private IStockInformationRepository _stockInformationRepository;
        public BuildPortfolio(IPortfolioBusinessLogic portfolioBusinessLogic,
                        ITradesBusinessLogic tradesBusinessLogic,
                        IPortfolioPerformanceBusinessLogic portfolioPerformanceBusinessLogic,
                        IStockInformationRepository stockInformationRepository)
        {
            _portfolioBusinessLogic = portfolioBusinessLogic;
            _tradesBusinessLogic = tradesBusinessLogic;
            _portfolioPerformanceBusinessLogic = portfolioPerformanceBusinessLogic;
            _stockInformationRepository = stockInformationRepository;

            InitializeComponent();

            this.CenterToScreen();
            this.Load += new EventHandler(BuildPortfolio_Load);
        }

        private async void BuildPortfolio_Load(object sender, EventArgs e)
        {
            // Bind only first tab data
            await BindPortfoliosData();
        }

        private async void AddPortfolio_Click(object sender, EventArgs e)
        {
            var newPortfolio = new DataAccess.Models.Portfolio()
            {
                Name = PortfolioNameTextBox.Text,
            };

            await _portfolioBusinessLogic.Add(newPortfolio);

            await BindPortfoliosData();
        }

        private void GoToPortfolio_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var portfolioId = Convert.ToInt32(button.Tag);
            Portfolio portfolioForm = new Portfolio(_tradesBusinessLogic, 
                                                    _portfolioPerformanceBusinessLogic, 
                                                    _stockInformationRepository,
                                                    portfolioId);
            portfolioForm.ShowDialog();
        }

        #region Helpers
        public async Task BindPortfoliosData()
        {
            var portfoliosList = await _portfolioBusinessLogic.GetPortfolios();

            int x = 0;
            int y = 0;
            int delta = 10;
            for (int i = 0; i < portfoliosList.Count; i++)
            {
                // Create name label
                var portfolioButton = new Button();
                portfolioButton.AutoSize = false;
                portfolioButton.Location = new Point(x, y);
                portfolioButton.Font = new Font("Arial", 10, FontStyle.Bold);
                portfolioButton.Text = "Portfolio: " + portfoliosList[i].Name;
                portfolioButton.Size = new Size(PortfoliosPanel.Size.Width - 3, 60);
                portfolioButton.TextAlign = ContentAlignment.MiddleLeft;
                portfolioButton.Margin = new Padding(0, 10, 0, 10);
                portfolioButton.Click += GoToPortfolio_Click;

                portfolioButton.Tag = portfoliosList[i].Id;

                PortfoliosPanel.Controls.Add(portfolioButton);

                // Iterate
                int dy1 = portfolioButton.Height;
                y += dy1 + delta;
            }
        }
        #endregion

    }
}
