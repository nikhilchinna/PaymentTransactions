using Microsoft.AspNetCore.Mvc;
using FinanceTransaction.Infrastructure.FinanceTransaction.Core.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace FinanceTransaction.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        // [Authorize(Roles = "Admin")] if needed
        [Authorize(Roles ="Admin, Manager")]
        [HttpPost]
        public IActionResult SubmitTransaction([FromBody] TransactionDto transaction)
        {
            // Save transaction to DB
            return Ok("Transaction submitted");
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAllTransactions()
        {
            // Get from DB
            return Ok(new[] { "Txn1", "Txn2" });
        }
    }

}
