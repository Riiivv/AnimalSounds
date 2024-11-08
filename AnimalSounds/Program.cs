using AnimalSounds;
Animals dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Rex");
Animals cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Whiskers");
Animals sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Fluffy");

// Kald MakeSound() metoden for hver instans og udskriv deres lyde
Console.WriteLine(dog.MakeSound());    // Output: Rex siger: Woof!!
Console.WriteLine(cat.MakeSound());    // Output: Whiskers siger: Meow!!
Console.WriteLine(sheep.MakeSound());  // Output: Fluffy siger: Baaaah!!

Console.WriteLine(); // Tilføj en tom linje for bedre læsbarhed

// Opret alle 3 dyr ved hjælp af overload versionen af CreateAnimal (med hardcoded navne)
Animals hardcodedDog = AnimalFactory.CreateAnimal(enmAnimals.Dog);
Animals hardcodedCat = AnimalFactory.CreateAnimal(enmAnimals.Cat);
Animals hardcodedSheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep);

// Kald MakeSound() metoden for hver instans med hardcoded navne
Console.WriteLine(hardcodedDog.MakeSound());    // Output: Bella siger: Woof!!
Console.WriteLine(hardcodedCat.MakeSound());    // Output: Luna siger: Meow!!
Console.WriteLine(hardcodedSheep.MakeSound());  // Output: Daisy siger: Baaaah!!