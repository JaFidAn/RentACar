using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Application.Features.Models.Queries.GetListModel.GetListModelByDynamic;
using CoreApplication.Requests;
using CorePersistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery() { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getListModelQuery);
            return Ok(result);
        }

        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelByDynamicQuery getListModelByDynamicQuery = new GetListModelByDynamicQuery() { PageRequest = pageRequest, Dynamic = dynamic };
            ModelListModel result = await Mediator.Send(getListModelByDynamicQuery);
            return Ok(result);
        }
    }
}