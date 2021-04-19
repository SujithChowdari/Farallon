# MyPortfolio App

### Few points about the implementation:
1. The application has two main parts - Adding portfolio and adding trades under portfolio (by clicking portfolio name).
2. Once trades are added under a portfolio, P/L can be viewed under Profit and Loss tab
3. Application works with only "Buy" trade not "Sell" at this point - this is something that can be done but not within two days as per my understanding.
4. I have used the .Net Core  framework and SqlLite DB to build this application.
5. Additionally, the code is written in a way that all the functionality of portfolio and trades can be exposed using APIs which can be used by Web/Mobile applications.
6. Using AlphaVantage freemium version of the stocks API  - there is a rate limit of 5 API calls per minute
7. Ticker/Symbol drop down on the "Add Trade" panel use static list of tickers - Couldn't rely on any API because of the rate limits


### There is some additional functionality that I can envision, which adds great value to the users:
1. Providing the trades and portfolio performance information through various charts
2. Providing an export option to export all the data into excel/csv
3. Allowing the user's to set their own targets/thresholds on trades and notifying them as soon the profit/loss reaches certain targets/thresholds
4. Color indicators in data to indicate profit/loss
5. Use API call to fetch ticker information using any stocks apis 
6. A new page which allows them to configure their own application specific settings : example frequency of polling the stocks api to fetch stock quote of a ticker/symbol


## Screenshots:
