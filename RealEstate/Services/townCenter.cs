using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Services
{
    public class townCenter : ItownCenter
    {
        List<Town> towni = new List<Town>();
        
        public List<Town> GetTowns()
        {
            towni.Add(new Town { Age = 2, Name = "cosik" });
            return towni;

        }
    }
}
