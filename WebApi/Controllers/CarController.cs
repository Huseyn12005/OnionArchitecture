using Infrastructure.Features.AddCar;
using Infrastructure.Features.GetAllCar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddCar(AddCarRequest addCar)
    {
        AddCarResponse? result = await _mediator.Send(addCar);
        return Ok(result);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllCar([FromQuery] GetAllCarRequest getAllCar)
    {
        var result = await _mediator.Send(getAllCar);
        return Ok(result);
    }
}
