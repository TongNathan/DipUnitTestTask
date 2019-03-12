using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Tests.Mocking;

namespace DipTestingExercises.Tests
{
    [TestFixture]
    public class MotorVehicleTests
    {
        IPerson _driver;
        MotorVehicle _mv;

        [SetUp]
        public void Setup()
        {
            _driver = new FakePerson();
            _mv = new FakeMotorVehicle(_driver, 100, 50, 2);
        }


        [Test]
        public void MotorVehicle_IsCalled_PropertiesSet()
        {
            // act


            // assert
            Assert.That(_mv.maxFuel.Equals(100));
            Assert.That(_mv.currentFuel.Equals(50));
            Assert.That(_mv.litresPerKM.Equals(2));
            Assert.That(_mv.driver.Equals(_driver));
        }

        [Test]
        public void GetFuelRemaining_IsCalled_ReturnsCorrectAmount()
        {
            // act
            var result = _mv.getFuelRemaining();

            // assert
            Assert.That(result.Equals(50));
        }



    }
}
