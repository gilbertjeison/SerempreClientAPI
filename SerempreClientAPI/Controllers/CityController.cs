using MediatR;
using Microsoft.AspNetCore.Mvc;
using SerempreClientAPI.Application.City.CreateCity;
using SerempreClientAPI.Application.City.DeleteCity;
using SerempreClientAPI.Application.City.GetCity;
using SerempreClientAPI.Application.City.UpdateCity;

namespace SerempreClientAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : ControllerBase
{
    private readonly IMediator mediator;

    public CityController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await mediator.Send(new CityRequest());
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateCityRequest cityRequest)
    {
        var createdEntity = await mediator.Send(cityRequest);

        if (createdEntity == null)
        {
            return BadRequest();
        }

        return Ok(createdEntity);
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateCityRequest cityRequest)
    {
        var updatedEntity = await mediator.Send(cityRequest);

        if (updatedEntity == null)
        {
            return BadRequest();
        }

        return Ok(updatedEntity);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(DeleteCityRequest cityRequest)
    {
        var updatedEntity = await mediator.Send(cityRequest);

        if (!updatedEntity)
        {
            return BadRequest();
        }

        return Ok();
    }
}
