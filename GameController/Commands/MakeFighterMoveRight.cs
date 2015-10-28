using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterMoveRight : IGameCommand
    {
        private Fighter _fighter;

        public MakeFighterMoveRight(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            _fighter.MoveRight(); 
        }

        public void Undo()
        {
            _fighter.Revive(_fighter._moveEnergyDrain);
            _fighter.Location--;
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
