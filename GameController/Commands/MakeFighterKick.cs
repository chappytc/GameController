using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterKick : IGameCommand
    {
        private Fighter _fighter;

        public MakeFighterKick(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            _fighter.Kick();  
        }

        public void Undo()
        {            
            if (!_fighter.ApplyEnergyBonus(_fighter.KickInflictedDamage * -1))
            {
                _fighter.Revive(_fighter.KickEnergyDrain);
            }
            _fighter.InflictedDamage -= _fighter.KickInflictedDamage;
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
