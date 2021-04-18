using System.Collections.Generic;
using System.Linq;

namespace MyPortfolio.DataAccess.Models
{
    public class PortfolioPerformanceSummary
    {
        public PortfolioPerformanceSummary()
        {
            PortfolioPerformances = new List<PortfolioPerformance>();
        }

        public List<PortfolioPerformance> PortfolioPerformances { get; set; }

        public float TotalInvestedAmount
        {
            get
            {
                return PortfolioPerformances.Sum(p => p.Cost);
            }
        }

        public float NetProfits
        {
            get
            {
                return PortfolioPerformances.Sum(p => p.InceptionProfitAndLoss);
            }
        }

        public float TotalNumberOfInvestments
        {
            get
            {
                return PortfolioPerformances.Count;
            }
        }
    }
}
