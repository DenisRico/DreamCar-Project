using AutoMapper;

namespace Dream.BusinessLogic.Models.CarModels
{
    /// <summary>
    /// Model Car
    /// </summary>
    public class Car
    {
        public int Id { get; set; }   //id
        public string Name { get; set; }    // name 
        public int Year { get; set; } // year
        public string Condition { get; set; }  // condition 
        public string FuelType { get; set; }  // Fuel type
        public string Color { get; set; }  // color
        public int Price { get; set; }  // price
        public string Description { get; set; }  // definition 
        public string Image { get; set; }  // image

        /// <summary>
		/// Мапка автомапера
		/// </summary>
		/// <param name="profile"></param>
		public static void CreateMaps(Profile profile)
        {
            profile.CreateMap<Dream.DataAccess.Models.Models.Car, Car>()
                .ForMember(item => item.Id, exp => exp.MapFrom(item => item.Id))
                .ForMember(item => item.Name, exp => exp.MapFrom(item => item.Name))
                .ForMember(item => item.Year, exp => exp.MapFrom(item => item.Year))
                .ForMember(item => item.Condition, exp => exp.MapFrom(item => item.Condition))
                .ForMember(item => item.FuelType, exp => exp.MapFrom(item => item.FuelType))
                .ForMember(item => item.Color, exp => exp.MapFrom(item => item.Color))
                .ForMember(item => item.Price, exp => exp.MapFrom(item => item.Price))
                .ForMember(item => item.Description, exp => exp.MapFrom(item => item.Description))
                .ForMember(item => item.Image, exp => exp.MapFrom(item => item.Image))
                .ReverseMap();
        }
    }
}
