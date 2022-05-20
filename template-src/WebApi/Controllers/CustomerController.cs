using Microsoft.AspNetCore.Mvc;

using MediatR;

using $ext_safeprojectname$.Domain.Entities;
using $ext_safeprojectname$.Application.Features.Customer.Queries;
using $ext_safeprojectname$.WebApi.Mapping.DTOs;


namespace $safeprojectname$.Controllers;

[Route("api/customer")]
[ApiController]
public class CustomerController : Controller
{
    #region Properties

    private ILogger<CustomerController> _logger;
    private readonly IMediator _mediator;

    #endregion

    #region Constructor

    public CustomerController(ILogger<CustomerController> logr, IMediator mediator)
    {
        _logger = logr;
        _mediator = mediator;
    }

    #endregion

    [HttpPost]
    [Route("getcustomerbycustomerid")]
    public async Task<ActionResult> GetCustomerByCustomerId([FromBody] GetCustomerByCustomerIdQuery input)
    {
        var result = new GetCustomerResponseDTO();

        try
        {
            Customer applicationResult = await _mediator.Send(input);

            if (applicationResult != null)
            {
                result = Mapping.Maps.CustomerMapper.ToGetCustomerResponseDTO(applicationResult);
            }
            else
            {
                result = new GetCustomerResponseDTO()
                {
                    HasError = true,
                    ErrorMessage = $"The application layer returned an unexpected null response for input CustomerId: {input.CustomerId} RequestingUserId: {input.RequestingUserId}"
                };
            }
        }
        catch (ArgumentNullException ex)
        {
            // Log the exception
            _logger.LogError(ex.ToString());

            // Return an error message to the calling code
            result.HasError = true;
            result.ErrorMessage = "A validation error occured with the input or a required value was null.";
            result.ErrorDetail = $"CustomerId:{input.CustomerId} RequestingUserId:{input.RequestingUserId} Exception:{ex} StackTrace:{ex.StackTrace}";
        }
        catch (Exception ex)
        {
            // Log the exception
            _logger.LogError(ex.ToString());

            // Return an error message to the calling code
            result.HasError = true;
            result.ErrorMessage = "An error was encountered getting the requested Customer.";
            result.ErrorDetail = $"CustomerId:{input.CustomerId} RequestingUserId:{input.RequestingUserId} Exception:{ex} StackTrace:{ex.StackTrace}";
        }

        return Json(result);
    }
}
