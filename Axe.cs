using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Рубить топором!");
        }
    }
}
