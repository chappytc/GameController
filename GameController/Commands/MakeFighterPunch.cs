using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterPunch : IGameCommand
    {
        private Fighter _fighter;

        public MakeFighterPunch(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            _fighter.Punch();  
        }

        public void Undo()
        {
            if (!_fighter.ApplyEnergyBonus(_fighter.PunchInflictedDamage * -1))
            {
                _fighter.Revive(_fighter.PunchEnergyDrain);
            }
            _fighter.InflictedDamage -= _fighter.PunchInflictedDamage;
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
