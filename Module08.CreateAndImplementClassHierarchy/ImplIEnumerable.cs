//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module08.CreateAndImplementClassHierarchy
//{
//    class ImplIEnumerable
//    {
//        static void Main(string[] args)
//        {
//            //List<RaceCar> RaceCars = new List<RaceCar>();
//            //var RaceCar1 = new RaceCar(1, "Doctor Neo Cortex");
//            //var RaceCar2 = new RaceCar(2, "Crash Bandicoot");
//            //var RaceCar3 = new RaceCar(2, "Doctor N. Gin");
//            //RaceCars.Add(RaceCar1);
//            //RaceCars.Add(RaceCar2);
//            //RaceCars.Add(RaceCar3);

//            //foreach (var item in RaceCars)
//            //{

//            //}
//            var race = new Race("Crash Team Racing");

//            var car1 = new RaceCar(1, "Doctor Neo Cortex");
//            var car2 = new RaceCar(2, "Crash Bandicoot");
//            var car3 = new RaceCar(2, "Doctor N. Gin");

//            race.AddCar(car1);
//            race.AddCar(car2);
//            race.AddCar(car3);

//            foreach (var car in race)
//            {
//                Console.WriteLine($"Car number: {car.Number}, Driver: {car.Driver}");
//            };
//        }
//    }

//    public class Race : IEnumerable<RaceCar>
//    {
//        private List<RaceCar> _cars;

//        public Race(string title)
//        {
//            Title = title;
//            _cars = new List<RaceCar>();
//        }

//        public string Title { get; set; }

//        public void AddCar(RaceCar car)
//        {
//            _cars.Add(car);
//        }

//        public IEnumerator<RaceCar> GetEnumerator()
//        {
//            foreach (var car in _cars)
//            {
//                yield return car;
//            }
//        }

//        //IEnumerator IEnumerable.GetEnumerator()
//        //{
//        //    return GetEnumerator();
//        //}

//        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class RaceCar
//    {
//        public RaceCar(int number, string driver)
//        {
//            Number = number;
//            Driver = driver;
//        }

//        public int Number { get; set; }
//        public string Driver { get; set; }
//    }
//}
