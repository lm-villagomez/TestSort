using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class CityRepository : ICityRepository
    {
        // Data simularion from DataBase
        private static readonly string[] cities = new[]
        {
            "New York", "Los Angeles", "Chicago", "Houston", "Philadelphia"
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Get data from principal information</returns>
        public string[] GetAll()
        {
            return cities;
        }


    }
}
