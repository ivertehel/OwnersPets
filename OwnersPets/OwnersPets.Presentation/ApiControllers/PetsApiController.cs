﻿using System.Threading.Tasks;
using System.Web.Http;
using OwnersPets.Presentation.Models;
using OwnersPets.Presentation.Service.Abstract;

namespace OwnersPets.Presentation.ApiControllers
{
    [RoutePrefix("api/Pets")]
    public class PetsApiController : ApiController
    {
        private readonly IPetsPresentationService _petsPresentationService;

        public PetsApiController(IPetsPresentationService petsPresentationService)
        {
            _petsPresentationService = petsPresentationService;
        }

        [HttpPost]
        [Route("Delete")]
        public async Task DeletePet([FromBody] DeletePetRequest request)
        {
            await _petsPresentationService.DeletePet(request);
        }

        [HttpPost]
        [Route("Create")]
        public async Task CreatePet([FromBody] CreatePetRequest request)
        {
            await _petsPresentationService.CreatePet(request);
        }
    }
}
