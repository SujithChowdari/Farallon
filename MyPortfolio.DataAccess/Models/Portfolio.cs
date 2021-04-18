using System;
using System.Collections.Generic;

namespace MyPortfolio.DataAccess.Models
{
    public class Portfolio
    {
        public Portfolio()
        {
            Trades = new List<Trade>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
