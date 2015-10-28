using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterMoveRight : IGameCommand
    {
        private Fighter _fighter;
        private int _previousLocation;

        public MakeFighterMoveRight(Fighter fighter)
        {
            _fighter = fighter;
            _previousLocation = _fighter.Location;
        }

        public void Execute()
        {
            _fighter.MoveRight(); 
        }

        public void Undo()
        {
            _fighter.Revive(_fighter._moveEnergyDrain);
            _fighter.Location = _previousLocation;
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
