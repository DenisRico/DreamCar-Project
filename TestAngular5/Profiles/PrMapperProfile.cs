using AutoMapper;


namespace TestAngular5.Profiles
{
    /// <summary>
    /// Конфигурация маппинга уровня Presentation
    /// </summary>
    public class PrMapperProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PrMapperProfile()
        {
            Dream.BusinessLogic.Models.CarModels.Car.CreateMaps(this);
            Dream.BusinessLogic.Models.PersonModels.Person.CreateMaps(this);
        }
    }
}
