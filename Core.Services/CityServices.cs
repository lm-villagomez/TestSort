using Core.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CityServices : ICityServices
    {
        private readonly ICityRepository _cityRepository;

        public CityServices(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Convert data in strng</returns>
        public string SortCities(int[] number)
        {
            string? cityString = "";

            string[] city=  _cityRepository.GetAll();

            //se ordena el arreglo en base a la numeracion


            var cityList = SortCity(city, number);
            var cityArray = cityList.ToArray();


            foreach(var cityItem in cityArray)
            {
                cityString = cityString  +cityItem.city.ToString() + ",";
            }


            return cityString;
        }

  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sample_order"></param>
        /// <returns>Get and reorder data using all arrays</returns>
        static List<Core.Entities.City> SortCity(string[] array, int[] sample_order)
        {

            var response = new List<Core.Entities.City>();

            string searchString = "";
            int index = Array.IndexOf(array, searchString, 1);
            int position = index + 2;

            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                var item = new Core.Entities.City();
                var numberSort = (sample_order[i] - 1);


                item.city = array[numberSort];
                response.Add(item);

            }


            return response;

        }

      
    }
}
