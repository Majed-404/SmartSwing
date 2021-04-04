using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
