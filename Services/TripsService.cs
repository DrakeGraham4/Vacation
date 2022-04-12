using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacation.Models;
using Vacation.Repositories;

namespace Vacation.Services
{
    public class TripsService
    {
        private readonly TripsRepository _tRepo;
        public TripsService(TripsRepository tRepo)
        {
            _tRepo = tRepo;
        }
        internal List<Trip> GetAll()
        {
            return _tRepo.GetAll();
        }

        internal Trip GetById(int id)
        {
            Trip found = _tRepo.GetById(id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;

        }

        internal Trip Create(Trip tripData)
        {
            return _tRepo.Create(tripData);
        }

        internal void Remove(int id)
        {
            GetById(id);
            _tRepo.Delete(id);
        }
    }
}