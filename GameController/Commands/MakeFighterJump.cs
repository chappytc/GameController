using GameController.Fighters;

namespace GameController.Commands
{
    public class MakeFighterJump : IGameCommand
    {
        private Fighter _fighter;

        public MakeFighterJump(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            _fighter.Jump();  
        }

        public void Undo()
        {
            _fighter.Revive(_fighter.JumpEnergyDrain);
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
