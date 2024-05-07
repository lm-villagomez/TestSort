

namespace Core.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        WebAppSort.Controllers.CityController _cityController;
        Services.ICityServices _services;

        public UnitTest1()
        {
            _cityController = new WebAppSort.Controllers.CityController(_services);
        }


        [TestMethod]
        public  void  TestMethod_CorrectResult()
        {
            int[] arryNumberTest = { 3, 2, 1, 5, 4 };
            string result = _services.SortCities(arryNumberTest);
           
            Assert.AreEqual("Chicago, Los Angeles, New York, Philadelphia, Houston,", result);

        }


        [TestMethod]
        public void TestMethod_CorrectLengh()
        {
            int[] arryNumberTest = { 3, 2, 1, 5, 4 };
            string result = _services.SortCities(arryNumberTest);

            Assert.Equals(5, arryNumberTest.Count());

        }


        

    }
}