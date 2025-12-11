using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.ViewModel.Drivers;

namespace TowzinSaravan.DataLayer.Repositories
{
    public interface IDriverRepository
    {
        List<Drivers> GetAllDrivers();
        IEnumerable<Drivers> GetDriversByFilter(string parameter);
        Drivers GetDriverById(int driverId);
        List<ListDriverViewModel> GetDriverFullnames();
        Drivers CheckDriverForUpdate(int id, string firstname, string lastname);
        Drivers GetDriverByDriverFullname(string firstname, string lastname);
        bool InsertDriver(Drivers driver);
        bool UpdateDriver(Drivers driver);
        bool DeleteDriver(Drivers driver);
        bool DeleteDriver(int driverId);
        string GetDriverFullnameById(int Id);
    }

}
