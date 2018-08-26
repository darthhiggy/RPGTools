using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Skills;

namespace Character
{
    public class Character
    {
        private int _brawn;

        public int Brawn
        {
            get { return _brawn; }
            set { _brawn = value; }
        }

        private int _agility;

        public int Agility
        {
            get { return _agility; }
            set { _agility = value; }
        }

        private int _intellect;

        public int Intellect
        {
            get { return _intellect; }
            set { _intellect = value; }
        }

        private int _cunning;

        public int Cunning
        {
            get { return _cunning; }
            set { _cunning = value; }
        }

        private int _willpower;

        public int Willpower
        {
            get { return _willpower; }
            set { _willpower = value; }
        }

        private int _prescence;

        public int Prescence
        {
            get { return _prescence; }
            set { _prescence = value; }
        }

        public Character(int brawn, int agility, int intellect, int cunning, int willpower, int prescence)
        {
            Brawn = brawn;
            Agility = agility;
            Intellect = intellect;
            Cunning = cunning;
            Willpower = willpower;
            Prescence = prescence;
        }

        
    }
}
