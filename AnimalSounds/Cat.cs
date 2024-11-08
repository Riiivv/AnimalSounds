using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cat : Animals
    {
        public Cat(string name) : base (name)
        {

        }
        public override string MakeSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\Tec\source\repos\AnimalSounds\AnimalSounds\assets\cat.wav"))
            {
                player.Load();
                player.PlaySync(); // Afspil lyden og vent til den er færdig
            }
            return $"{Name} Says: Meow!!!";
        }
    }
}
