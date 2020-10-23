﻿using Application.Common.Models;
using Application.Dto;
using Application.Villages.Queries.GetVillagesWithPagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Authorize]
    public class VillagesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<ServiceResult<PaginatedList<VillageDto>>>> GetAllVillagesWithPagination(GetAllVillagesWithPaginationQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
