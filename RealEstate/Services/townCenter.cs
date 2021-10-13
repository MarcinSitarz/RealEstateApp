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
            

            return towni;

        }

        public void AddTown(Town tony)
        {
            
            towni.Add(tony);
           
        }

        public void DeleteTown()
        {
            towni.Clear();
        }
    }
}
