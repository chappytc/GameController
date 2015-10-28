using System.ComponentModel;
using System.Windows.Forms;

namespace GameController.Fighters
{
    public abstract class Fighter : INotifyPropertyChanged
    {
        internal int _energy = 100;
        internal int _location = 0; // Number of steps from starting point (zero). Negative is number of steps left of start. Positive is number of steps right of start.
        internal int _inflictedDamage = 0;

        internal int _energyBonus = 10;
        internal int _energyBonusAcheivedAtDamageInflicted = 10;
        internal int _jumpEnergyDrain = 5;
        internal int _dodgeEnergyDrain = 2;
        internal int _moveEnergyDrain = 1;
        internal int _punchEnergyDrain = 2;
        internal int _kickEnergyDrain = 3;
        internal int _punchInflictedDamage = 5;
        internal int _kickInflictedDamage = 7;

        internal int _damageInflictedSinceLastEnergyBonus = 0;

        public int Energy
        {
            get { return _energy; }
            set
            {
                _energy = value;
                OnPropertyChanged("Energy");
            }
        }

        public int Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged("Location");
            }
        }

        public int InflictedDamage
        {
            get { return _inflictedDamage; }
            set
            {
                _inflictedDamage = value;
                OnPropertyChanged("InflictedDamage");
            }
        }

        public int EnergyBonus
        {
            get { return _energyBonus; }
            set { _energyBonus = value; }
        }

        public int EnergyBonusAcheivedAtDamageInflicted
        {
            get { return _energyBonusAcheivedAtDamageInflicted; }
            set { _energyBonusAcheivedAtDamageInflicted = value; }
        }


        public int JumpEnergyDrain
        {
            get { return _jumpEnergyDrain; }
            set { _jumpEnergyDrain = value; }
        }

        public int DodgeEnergyDrain
        {
            get { return _dodgeEnergyDrain; }
            set { _dodgeEnergyDrain = value; }
        }

        public int MoveEnergyDrain
        {
            get { return _moveEnergyDrain; }
            set { _moveEnergyDrain = value; }
        }

        public int PunchEnergyDrain
        {
            get { return _punchEnergyDrain; }
            set { _punchEnergyDrain = value; }
        }

        public int KickEnergyDrain
        {
            get { return _kickEnergyDrain; }
            set { _kickEnergyDrain = value; }
        }

        public int PunchInflictedDamage
        {
            get { return _punchInflictedDamage; }
            set { _punchInflictedDamage = value; }
        }

        public int KickInflictedDamage
        {
            get { return _kickInflictedDamage; }
            set { _kickInflictedDamage = value; }
        }

        public virtual void Jump()
        {
            if (Energy >= JumpEnergyDrain)
            {
                Energy -= JumpEnergyDrain;
            }
        }

        public virtual void Dodge()
        {
            if (Energy >= DodgeEnergyDrain)
            {
                Energy -= DodgeEnergyDrain;
            }
        }

        public virtual void MoveLeft()
        {
            if (Energy >= MoveEnergyDrain)
            {
                Energy -= MoveEnergyDrain;
                Location--;
            }
        }

        public virtual void MoveRight()
        {
            if (Energy >= MoveEnergyDrain)
            {
                Energy -= MoveEnergyDrain;
                Location++;
            }
        }

        public virtual void Punch()
        {
            if (Energy >= PunchEnergyDrain)
            {                
                InflictedDamage += PunchInflictedDamage;
                if (!ApplyEnergyBonus(PunchInflictedDamage))
                    Energy -= PunchEnergyDrain;
            }
        }

        public virtual void Kick()
        {
            if (Energy >= KickEnergyDrain)
            {                
                InflictedDamage += KickInflictedDamage;
                if (!ApplyEnergyBonus(KickInflictedDamage))
                    Energy -= KickEnergyDrain;
            }
        }

        public virtual void Revive(int amount)
        {
                Energy += amount;
        }

        public virtual bool ApplyEnergyBonus(int newAmountInflicted)
        {
            bool returnValue = false;

            _damageInflictedSinceLastEnergyBonus += newAmountInflicted;
            if (_damageInflictedSinceLastEnergyBonus >= _energyBonusAcheivedAtDamageInflicted)
            {
                Revive(_energyBonus);
                _damageInflictedSinceLastEnergyBonus -= _energyBonusAcheivedAtDamageInflicted;
                returnValue = true;
            }
            else
            {
                if (_damageInflictedSinceLastEnergyBonus < 0) // This logic reverses energy bonus; i.e., undo. Would only occur if a negative value was passed in.
                {
                    _damageInflictedSinceLastEnergyBonus += _energyBonusAcheivedAtDamageInflicted;
                    Revive(_energyBonus * -1);
                    returnValue = true;
                }
                
            }
            return returnValue;
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
