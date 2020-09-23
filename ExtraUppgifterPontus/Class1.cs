using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgifterPontus
{
    class SkogenAnimal
    {
        public string name { get; set; }
        public bool nocturnal { get; set; }

        public SkogenAnimal(string _name, bool _nocturnal)
        {
            name = _name;
            nocturnal = _nocturnal;
        }
    }
}
