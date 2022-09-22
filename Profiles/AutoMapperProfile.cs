using VisitorManagementSystem.Models;
using VisitorManagementSystem.ViewModels;
using AutoMapper;

namespace VisitorManagementSystem.Profiles
{
    public class AutoMapperProfile
    {
        //put maps in the constructor
        public AutoMapperProfile()
        {
            CreateMap<Visitors, VisitorsVM>().ReverseMap();
            CreateMap<StaffNames, StaffNamesVM>().ReverseMap();
        }
    }
}
