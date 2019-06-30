using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public abstract class GameCharacter
    {
        private string name;
        private IAttackBehaviour attackBehaviour;
        private IDefendBehaviour defendBehaviour;

        public IDefendBehaviour DefendBehaviour { get { return defendBehaviour; } set { defendBehaviour = value; } }
        public IAttackBehaviour AttackBehaviour { get { return attackBehaviour; } set { attackBehaviour = value; } }

        public abstract void Attack();
        public abstract void Defend();
        public GameCharacter()
        {

        }

    }
}
