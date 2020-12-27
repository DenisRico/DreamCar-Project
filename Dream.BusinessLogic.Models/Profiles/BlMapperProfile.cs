using AutoMapper;

namespace Dream.BusinessLogic.Models.Profiles
{
    /// <summary>
    /// Профиль моделей BL
    /// </summary>
    public class BlMapperProfile : Profile
    {
        /// <inheritdoc />
        
        public BlMapperProfile()
        {
            CarModels.Car.CreateMaps(this);
            PersonModels.Person.CreateMaps(this);
        }
    }
}
