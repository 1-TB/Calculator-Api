using Microsoft.AspNetCore.Mvc;
using System.Web;
namespace CalculatorAPI.Controllers;

[ApiController]
[Route("/api/calculation")]
public class CalculationController: ControllerBase {

    private readonly ILogger<CalculationController> _logger;

    public CalculationController(ILogger<CalculationController> logger)
    {
        _logger = logger;
    }
    [HttpGet("{first}/{next}/{type}")]
    public Calculation Get(double first, double next, string type)
    {
        double result = 0;
        bool success = true;
        switch(type.ToLower().Replace(" ",""))
        {
            case "add":
                result = Calc.Add(first,next);
                break;
            case "subtract":
                result = Calc.Subtract(first,next);
                break;
            case "multiply":
                result = Calc.Multiply(first,next);
                break;
            case "divide":
                result = Calc.Divide(first,next);
                break;
            default:
                success = false;
                break;
        }
        if (success == true)
        {
            return new Calculation
            {
                first = first,
                next = next,
                type = type,
                result = result,
            };
        }else
        {
            _logger.LogError("Bad request made " + type);
            return null;

        }
    }

}