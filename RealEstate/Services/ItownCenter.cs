using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Services
{
    public interface ItownCenter
    {
        List<Town> GetTowns();
        public void AddTown(Town tony);
        public void DeleteTown();
    }
}
