using AutoMapper;

namespace Dream.BusinessLogic.Models.PersonModels
{
    /// <summary>
    /// Model Person
    /// </summary>
    public class Person
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public string Position { get; set; } // company
        public string Image { get; set; }  // price
        public string Profile { get; set; }  // price

        /// <summary>
        /// Мапка автомапера
        /// </summary>
        /// <param name="profile"></param>
        public static void CreateMaps(Profile profile)
        {
            profile.CreateMap<Dream.DataAccess.Models.Models.Person, Person>()
                .ForMember(item => item.Id, exp => exp.MapFrom(item => item.Id))
                .ForMember(item => item.Name, exp => exp.MapFrom(item => item.Name))
                .ForMember(item => item.Position, exp => exp.MapFrom(item => item.Position))
                .ForMember(item => item.Image, exp => exp.MapFrom(item => item.Image))
                .ForMember(item => item.Profile, exp => exp.MapFrom(item => item.Profile))
                .ReverseMap();
        }
    }
}
