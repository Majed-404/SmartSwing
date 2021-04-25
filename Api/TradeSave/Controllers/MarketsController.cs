using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeSave.Identity.Models;

namespace TradeSave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        private readonly TradeSaveContext _db;
        public MarketsController(TradeSaveContext db)
        {
            _db = db;
        }

        [HttpGet("MarketList")]
        public IActionResult MarketList()
        {
            var mktList = _db.Markets.ToList();
            return Ok(mktList);
        }

        //search box
        [HttpGet("StockList/{Id}")]
        public IActionResult StockList(string Id="2")
        {
            var stockList = _db.NwNmDics.Where(a=>a.NmMktId==Id).ToList();
            return Ok(stockList);
        }

        //stocks in home page

        [HttpGet("StockListExchange/{Id}")]
        public IActionResult StockListExchange(int Id = 2)
        {
            var stockDetails=_db.StockExchanges.Where(a=>a.DtMktId==Id).ToList();
            var marketConnectionString = _db.Markets.FirstOrDefault(a => a.Id == Id).DestHost;

            #region open connection
            //try
            //{
            //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(marketConnectionString);

            //    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            //    {

            //        connection.Open();

            //        String sql = "SELECT name, collation_name FROM sys.databases";

            //        using (SqlCommand command = new SqlCommand(sql, connection))
            //        {
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    var s = reader.GetString(0);
            //                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            #endregion

            return Ok(stockDetails);
        }
    }
}
