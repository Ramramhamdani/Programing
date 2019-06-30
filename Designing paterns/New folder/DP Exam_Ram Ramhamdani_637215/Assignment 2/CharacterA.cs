using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class CharacterA : GameCharacter
    {
        public CharacterA(string name)
        {
            AttackBehaviour = new WeakAttack();
            DefendBehaviour = new BronzeShield();
        }
        public override void Attack()
        {
            AttackBehaviour.Attack();
        }

        public override void Defend()
        {
            DefendBehaviour.Defend();
        }
    }
}
