using WebAPIWithDependencyInjection.Models;

namespace WebAPIWithDependencyInjection.DataAccess.interfaces
{
    public interface IDataAccessLayer
    {
        CarDeatils GetCarDetails(int carId);
    }
}
