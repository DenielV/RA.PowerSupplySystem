using AutoMapper;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetAllMaterials;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialDetails;
using RA.PowerSupplySystem.Application.Features.Material.Queries.GetMaterialsInventory;
using RA.PowerSupplySystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Application.MappingProfiles
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {
            CreateMap<Material, MaterialListDto>().ReverseMap();
            CreateMap<Material, MaterialDetailsDto>().ReverseMap();
            CreateMap<Material, MaterialInventoryDto>().ReverseMap();
        }
    }
}
