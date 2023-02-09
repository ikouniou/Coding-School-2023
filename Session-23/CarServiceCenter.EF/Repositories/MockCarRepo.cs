using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class MockCarRepo : IEntityRepo<Car> {

        private readonly List<Car> _cars;

        public MockCarRepo() {
            _cars = new List<Car> {
                    new("Audi", "A6", "ERI 1111"),
                    new("BMW", "M3", "XAT 6563"),
                    new("Mercedez", "CLA35", "NKM 3842")
                };
        }

        public void Add(Car entity) {

            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            var lastId = _cars.OrderBy(car => car.Id).Last().Id;
            entity.Id = ++lastId;
            _cars.Add(entity);
        }

        public void Delete(int id) {

            var foundCar = _cars.SingleOrDefault(car => car.Id == id);
            if (foundCar is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _cars.Remove(foundCar);
        }

        public IEnumerable<Car> GetAll() {
            
            return _cars;
        }

        public Car? GetById(int id) {
            
            return _cars.Where(car => car.Id == id).FirstOrDefault();
        }

        public void Update(int id, Car entity) {

            var foundCar = _cars.SingleOrDefault(car => car.Id == id);
            if (foundCar is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundCar.Brand = entity.Brand;
            foundCar.Model = entity.Model;
            foundCar.CarRegistrationNumber = entity.CarRegistrationNumber;
        }
    }
}
