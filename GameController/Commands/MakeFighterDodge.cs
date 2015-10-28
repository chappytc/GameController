using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterDodge : IGameCommand
    {
        private Fighter _fighter;

        public MakeFighterDodge(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            _fighter.Dodge();  
        }

        public void Undo()
        {
            _fighter.Revive(_fighter.DodgeEnergyDrain);
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
