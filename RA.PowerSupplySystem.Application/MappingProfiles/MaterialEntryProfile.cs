using AutoMapper;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Commands.CreateMaterialEntry;
using RA.PowerSupplySystem.Application.Features.MaterialEntry.Queries.GetAllMaterialEntries;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.MappingProfiles
{
    public class MaterialEntryProfile : Profile
    {
        public MaterialEntryProfile()
        {
            CreateMap<MaterialEntry, MaterialEntryListDto>().ReverseMap();
            CreateMap<MaterialEntry, CreateMaterialEntryCommand>().ReverseMap();
        }
    }
}
