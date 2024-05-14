using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Character
    {
        public Character(int level, string name, string @class, string breed)
        {
            Level = level;
            Name = name;
            Class = @class;
            Breed = breed;
        }

        public int Level { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Breed { get; set; }
    }
}
