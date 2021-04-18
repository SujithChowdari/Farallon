using Dapper;
using Microsoft.Data.Sqlite;
using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Implementations
{
    /// <summary>
    /// This holds a local data store being used for POC purpose
    /// Actual data store implementation can be done as per needs and using ITradesRepository as template
    /// </summary>
    public class TradesRepository : ITradesRepository
    {
        private string _connectionString = string.Empty;
        public TradesRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PortfolioDBConnectionString"].ConnectionString;
            _connectionString = _connectionString.Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// Get all the trades from the store
        /// </summary>
        /// <returns>Trade collection</returns>
        public async Task<List<Trade>> GetTrades(int portfolioId)
        {
            string sql = $"SELECT * FROM Trade Where PortfolioId = {portfolioId}";

            using (var connection = new SqliteConnection(_connectionString))
            {
                var trades = await connection.QueryAsync<Trade>(sql);

                return trades.ToList();
            }
        }

        /// <summary>
        /// Adds a new trade
        /// </summary>
        /// <param name="newTrade">Trade object</param>
        /// <returns></returns>
        public async Task Add(int portfolioId, Trade newTrade)
        {
            newTrade.PortfolioId = portfolioId;
            string sql = "INSERT INTO Trade (Ticker, TradeDate, TradeType, Quantity, Price, ParentTradeId, PortfolioId) " +
                "Values (@Ticker, @TradeDate, @TradeType, @Quantity, @Price, @ParentTradeId, @PortfolioId);";

            using (var connection = new SqliteConnection(_connectionString))
            {
                await connection.ExecuteAsync(sql, new { newTrade.Ticker, newTrade.TradeDate, newTrade.TradeType, newTrade.Quantity, newTrade.Price, newTrade.ParentTradeId, newTrade.PortfolioId });
            }
        }
    }
}
