using Microsoft.AspNetCore.Mvc;
using MonthyExpenseControl.Application.DTOs;
using MonthyExpenseControl.Application.Interfaces;

namespace MonthyExpenseControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthController : ControllerBase
    {
        private readonly IMonthSummaryService _monthSummaryService;
        public MonthController(IMonthSummaryService monthSummaryService)
        {
            _monthSummaryService = monthSummaryService;
        }

        [HttpGet("{monthid:int}")]
        public ActionResult<MonthSummaryDTO> GetMonthSummary(int monthId)
        {
            var monthSummary = _monthSummaryService.GetMonthSummary(monthId);

            if (monthSummary == null)
            {
                return NotFound("Month summary data not found.");
            }

            return Ok(monthSummary);
        }

        [HttpPut]

        public ActionResult<MonthSummaryDTO> UpdateMonthSummary(MonthSummaryDTO monthSummary)
        {
            var month = _monthSummaryService.UpdateMonthSummary(monthSummary).Result;

            if (month == null)
            {
                return NotFound("Month summary data not found.");
            }

            return Ok(month);
        }
    }
}
