using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public abstract class Animals
    {
        public string Name {  get; set; }
        public Animals(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();

    }
}
