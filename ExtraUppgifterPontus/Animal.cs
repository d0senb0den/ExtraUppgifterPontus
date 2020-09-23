using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgifterPontus
{
    class Animal
    {
        public string animalType { get; set; }

        public string name { get; set; }

        public int birthYear { get; set; }

        public int age { get; set; }

        public int legs { get; set; }

        public bool fast { get; set; }

        public void Story()
        {
            Console.WriteLine($"Det var en gång en {age} år gammal {animalType} som hette {name}.\n" +
            $"En dag var {name} ute på en promenad i skogen och mötte en stor varg.\n" +
            $"Vargen bet av ett ben. {name} sprang {CheckFast()} hem på {CheckLegs()}.\n" +
            "Så var sagan slut.");
        }
        public string CheckFast()
        {
            if (fast)
            {
                return "snabbt";
            }
            else
            {
                return "långsamt";
            }
        }
        public string CheckLegs()
        {
            if ((legs -1) > 1)
            {
                return $"sina {legs - 1} ben";
            }
            else
            {
                return $"sitt enda ben";
            }
        }
    }
}
