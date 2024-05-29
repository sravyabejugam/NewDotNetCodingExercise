namespace CodingExercise.Tests
{
    using CodingExercise.Controllers;
    using CodingExercise.Services;
    using CodingExercise.Utilities;
    using System.Collections;

    public class Tests
    {
        private IFizzBuzz FizzService;
        private IDivision divisionService;
        private FizzBuzzController? fizzBuzzController;
        [SetUp]
        public void Setup()
        {
            divisionService = new Division();
            FizzService = new FizzBuzz(divisionService);


        }

        [Test]
        public void TestForFizz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("12");

            var result = fizzBuzzController.Post(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                
                Assert.That(item1, Is.EqualTo("Fizz"));
            }
        }

        [Test]
        public void TestForBuzz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("20");

            var result = fizzBuzzController.Post(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                
                Assert.That(item1, Is.EqualTo("Buzz"));
            }
        }

        [Test]
        public void TestForFizzBuzz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("30");

            var result = fizzBuzzController.Post(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                
                Assert.That(item1, Is.EqualTo("FizzBuzz"));
            }
        }


        [Test]
        public void TestForInvalid()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("ABC");

            var result = fizzBuzzController.Post(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                Assert.That(item1, Is.EqualTo("Invalid Item"));
            }
        }

        [Test]
        public void TestForNumber()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("23");

            var result = fizzBuzzController.Post(arr1);

            var count = result.Count;

            var item2 = result[count - 1];
            var item1 = result[count - 2];

            Assert.That(item1, Is.EqualTo("Divided 23 by 3"));
            Assert.That(item2, Is.EqualTo("Divided 23 by 5"));
        }
    }
}