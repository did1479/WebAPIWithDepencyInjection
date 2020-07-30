using WebAPIWithDependencyInjection.Models;

namespace WebAPIWithDependencyInjection.BusinessAccess.interfaces
{
    public interface IBusinessAccessLayer
    {
        CarDeatils GetCarDetails(int carId);
    }
}
