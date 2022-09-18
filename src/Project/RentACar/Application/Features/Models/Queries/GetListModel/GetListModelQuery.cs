using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Models.Models;
using Application.Services.Repositories;
using AutoMapper;
using CoreApplication.Requests;
using CorePersistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Models.Queries.GetListModel
{
    public class GetListModelQuery : IRequest<ModelListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetListModelQueryHandler : IRequestHandler<GetListModelQuery, ModelListModel>
        {
            private readonly IMapper _mapper;
            private readonly IModelRepository _modelRepository;

            public GetListModelQueryHandler(IMapper mapper, IModelRepository modelRepository)
            {
                _mapper = mapper;
                _modelRepository = modelRepository;
            }

            public async Task<ModelListModel> Handle(GetListModelQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Model> models = await _modelRepository.GetListAsync(include:
                                                    m => m.Include(c => c.Brand),
                                                    index: request.PageRequest.Page,
                                                    size: request.PageRequest.PageSize
                                                    );
                ModelListModel mappedModel = _mapper.Map<ModelListModel>(models);
                return mappedModel;
            }
        }
    }
}