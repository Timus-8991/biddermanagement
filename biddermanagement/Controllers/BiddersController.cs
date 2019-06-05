using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biddermanagement.Data;
using biddermanagement.Entity;
using Microsoft.AspNetCore.Mvc;

namespace biddermanagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiddersController : ControllerBase
    {
        private readonly MongoService _mongoService;
        public BiddersController(MongoService mongoService)
        {
            _mongoService = mongoService;
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Bidder>> Get()
        {
            var bidders = await _mongoService.GetAllDocumentsAsync<Bidder>("Bidders");
            return bidders;
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Bidder bidder)
        {
            bidder.Id = new Guid();
            await _mongoService.CreateAsync("Bidders", bidder);
        }

        [HttpPut]
        public async Task Put([FromBody] Bidder bidder)
        {
            var existingBidder = await _mongoService.GetDocumentsByIdAsync<Bidder>(bidder.Id, "bidders");
            existingBidder.Teams.Clear();
            existingBidder.Teams.AddRange(bidder.Teams);
            await _mongoService.UpdateDocumentFieldByIdAsync<Bidder>(bidder.Id,"bidders","teams", existingBidder);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _mongoService.DeleteDocumentByIdAsync<Bidder>(id, "Bidders");
        }
    }
}
