using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SMM.Application.Services;
using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;
using SMM.Persistence.Context;

namespace SMM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly MediaService mediaService;

        public MediaController(MediaService mediaService)
        {
            this.mediaService = mediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediaService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Add(MediaCreateDto media)
        {
            return Ok(await mediaService.Add(media));
        }
    }
}
