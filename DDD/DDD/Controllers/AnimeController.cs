using DDD.Domain.Command.Anime;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Controllers;

[Route("[controller]")]
[ApiController]
public class AnimeController(
    IHandler<Anime, 
        AnimeQuery,
        AnimeInsertCommand, 
        AnimeUpdateCommand, 
        AnimePatchCommand,
        AnimeDeleteCommand> handler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync(
          [FromQuery] AnimeQuery query,
          CancellationToken cancellationToken = default)
              => Ok(await handler.GetAsync(query, cancellationToken));

    [HttpPost]
    public async Task<IActionResult> PostAsync(
        [FromBody] AnimeInsertCommand command,
        CancellationToken cancellationToken = default)
            => Created(HttpContext.Request.GetDisplayUrl(), 
                    await handler.InsertAsync(command, cancellationToken));

    [HttpPut]
    public async Task<IActionResult> PutAsync(
        [FromBody] AnimeUpdateCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.UpdateAsync(command, cancellationToken));

    [HttpPatch]
    public async Task<IActionResult> PatchAsync(
        [FromBody] AnimePatchCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.PatchAsync(command, cancellationToken));

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(
        [FromBody] AnimeDeleteCommand command,
        CancellationToken cancellationToken = default)
            => Ok(await handler.DeleteAsync(command, cancellationToken));
}
