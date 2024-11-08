using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public static class AnimalFactory
    {
        // Factory metode der tager både dyretype og navn som parameter
        public static Animals CreateAnimal(enmAnimals type, string navn)
        {
            return type switch
            {
                enmAnimals.Dog => new Dog(navn),
                enmAnimals.Cat => new Cat(navn),
                enmAnimals.Sheep => new Sheep(navn),
                _ => throw new ArgumentException("Ukendt dyretype")
            };
        }

        // Overload af CreateAnimal metode, hvor navnet er hardcoded
        public static Animals CreateAnimal(enmAnimals type)
        {
            return type switch
            {
                enmAnimals.Dog => new Dog("Bella"),   // Hardcoded navn for Dog
                enmAnimals.Cat => new Cat("Luna"),    // Hardcoded navn for Cat
                enmAnimals.Sheep => new Sheep("Daisy"), // Hardcoded navn for Sheep
                _ => throw new ArgumentException("Ukendt dyretype")
            };
        }
    }
}
