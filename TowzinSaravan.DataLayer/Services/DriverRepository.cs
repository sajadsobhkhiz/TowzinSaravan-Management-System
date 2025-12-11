using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.ViewModel.Drivers;

namespace TowzinSaravan.DataLayer.Services
{
    public class DriverRepository : IDriverRepository
    {
        private TowzinSaravan_DBEntities db;

        public DriverRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
        }

        public List<Drivers> GetAllDrivers()
        {
            return db.Drivers.OrderBy(d => d.Lastname).ToList();
        }

        public IEnumerable<Drivers> GetDriversByFilter(string parameter)
        {
            return db.Drivers.Where(d =>
                                        d.Firstname.Contains(parameter) ||
                                        d.Lastname.Contains(parameter) ||
                                        d.Mobile.Contains(parameter)).ToList();
        }

        public Drivers GetDriverById(int driverId)
        {
            return db.Drivers.Where(d => d.Id == driverId).SingleOrDefault();
        }

        public Drivers CheckDriverForUpdate(int id, string firstname, string lastname)
        {
            return db.Drivers.Where(d => d.Firstname == firstname && d.Lastname == lastname && d.Id != id).SingleOrDefault();
        }

        public string GetDriverFullnameById(int Id)
        {
            return db.Drivers.Where(d => d.Id == Id).Select(d => d.Lastname + " " + d.Firstname).ToString();
        }

        public bool InsertDriver(Drivers driver)
        {
            try
            {
                db.Drivers.Add(driver);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDriver(Drivers driver)
        {
            try
            {
                db.Entry(driver).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDriver(Drivers driver)
        {
            try
            {
                db.Entry(driver).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDriver(int driverId)
        {
            try
            {
                var user = GetDriverById(driverId);
                DeleteDriver(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Drivers GetDriverByDriverFullname(string firstname, string lastname)
        {
            return db.Drivers.Where(d => d.Firstname == firstname && d.Lastname == lastname).SingleOrDefault();
        }

        public List<ListDriverViewModel> GetDriverFullnames()
        {
            List<Drivers> result = db.Drivers.OrderBy(d => d.Lastname).ToList();
            return result.Select(d => new ListDriverViewModel()
            {
                Id = d.Id,
                Fullname = d.Lastname + " " + d.Firstname
            }).ToList();
        }
    }
}
