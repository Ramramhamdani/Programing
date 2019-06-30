using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class CharacterB : GameCharacter
    {
        public CharacterB(string name)
        {
            AttackBehaviour = new NormalAttack();
            DefendBehaviour = new SilverShild();
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
