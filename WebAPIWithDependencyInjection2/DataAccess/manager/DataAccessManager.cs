using WebAPIWithDependencyInjection.DataAccess.interfaces;
using WebAPIWithDependencyInjection.Models;

namespace WebAPIWithDependencyInjection.DataAccess.manager
{
    public class DataAccessManager : IDataAccessLayer
    {
        public CarDeatils GetCarDetails(int carId)
        {
            return new CarDeatils
            {
                CarId = carId,
                Name = "Test Car",
                Description = "Car used for Testing purpose",
                FeatureDetails = "Power Stearing, Alloy Wheels, Sun roof, Windshield",
                LaunchYear = 2005,
                EngineType = "BS6"
            };
        }
    }
}