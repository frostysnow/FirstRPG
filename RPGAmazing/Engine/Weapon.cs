using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int MagicDamage { get; set; }

        public Weapon(int id, string name, string namePlural, string description, int minimumDamage, int maximumDamage, int magicDamage, int price) : base(id, name, namePlural, description, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            MagicDamage = magicDamage;
        }
    }
}
