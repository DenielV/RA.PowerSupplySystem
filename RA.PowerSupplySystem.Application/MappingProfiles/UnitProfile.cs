using AutoMapper;
using RA.PowerSupplySystem.Application.Features.Unit.Commands.CreateUnit;
using RA.PowerSupplySystem.Application.Features.Unit.Queries.GetOrderUnitsToRework;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.MappingProfiles
{
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<Unit, CreateUnitCommand>().ReverseMap();
            CreateMap<Unit, UnitDto>().ReverseMap();
        }
    }
}
