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
    public class PortfolioRepository : IPortfolioRepository
    {
        private string _connectionString = string.Empty;
        public PortfolioRepository()
        { 
            _connectionString = ConfigurationManager.ConnectionStrings["PortfolioDBConnectionString"].ConnectionString;
            _connectionString = _connectionString.Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// Get all the portfolios from the store
        /// </summary>
        /// <returns>Portfolio collection</returns>
        public async Task<List<Portfolio>> GetPortfolios()
        {
            string sql = "SELECT * FROM Portfolio";

            using (var connection = new SqliteConnection(_connectionString))
            {
                var portfolios = await connection.QueryAsync<Portfolio>(sql);

                return portfolios.ToList();
            }            
        }

        /// <summary>
        /// Get a portfolio based on Id
        /// </summary>
        /// <returns>Portfolio object</returns>
        public async Task<Portfolio> GetPortfolio(int Id)
        {
            string sql = $"SELECT * FROM Portfolio WHERE PortfolioId = {Id}";

            using (var connection = new SqliteConnection(_connectionString))
            {
                var portfolio = await connection.QueryFirstAsync<Portfolio>(sql);

                return portfolio;
            }
        }

        /// <summary>
        /// Adds a new Portfolio
        /// </summary>
        /// <param name="newTrade">newly created portfolio object</param>
        /// <returns></returns>
        public async Task Add(Portfolio newPortfolio)
        {
            string sql = "INSERT INTO Portfolio (Name, CreatedDateTime) Values (@Name, @CreatedDateTime);";

            using (var connection = new SqliteConnection(_connectionString))
            {
                await connection.ExecuteAsync(sql, new { newPortfolio.Name, CreatedDateTime = DateTime.Now });
            }
        }
    }
}
