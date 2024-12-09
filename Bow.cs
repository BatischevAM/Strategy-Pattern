using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("выстрелить стрелой!");
        }
    }
}
