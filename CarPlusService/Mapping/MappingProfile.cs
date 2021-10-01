using AutoMapper;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlusService.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDataDTO, StudentData>();
        }
    }
}
