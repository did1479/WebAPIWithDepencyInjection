using WebAPIWithDependencyInjection.BusinessAccess.interfaces;
using WebAPIWithDependencyInjection.DataAccess.interfaces;
using WebAPIWithDependencyInjection.Models;

namespace WebAPIWithDependencyInjection.BusinessAccess.manager
{
    public class BusinessAccessManager : IBusinessAccessLayer
    {
        public IDataAccessLayer _dal;

        public BusinessAccessManager(IDataAccessLayer _dalobj)
        {
            _dal = _dalobj;
        }

        public CarDeatils GetCarDetails(int carId)
        {
            return _dal.GetCarDetails(carId);
        }
    }
}