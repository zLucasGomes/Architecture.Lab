using DDD.Domain.Command.Movie;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Controllers;

[Route("[controller]")]
[ApiController]
public class MovieController(
    IHandler<Movie,
        MovieQuery,
        MovieInsertCommand,
        MovieUpdateCommand,
        MoviePatchCommand,
        MovieDeleteCommand> handler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync(
        [FromQuery] MovieQuery query,
        CancellationToken cancellationToken = default)
            => Ok(await handler.GetAsync(query, cancellationToken));

    [HttpPost]
    public async Task<IActionResult> PostAsync(
        [FromBody] MovieInsertCommand command,
        CancellationToken cancellationToken = default)
            => Created(HttpContext.Request.GetDisplayUrl(),
                        await handler.InsertAsync(command, cancellationToken));

    [HttpPut]
    public async Task<IActionResult> PutAsync(
        [FromBody] MovieUpdateCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.UpdateAsync(command, cancellationToken));

    [HttpPatch]
    public async Task<IActionResult> PatchAsync(
        [FromBody] MoviePatchCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.PatchAsync(command, cancellationToken));

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(
        [FromBody] MovieDeleteCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.DeleteAsync(command, cancellationToken));
}
