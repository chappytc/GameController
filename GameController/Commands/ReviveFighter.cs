using GameController.Fighters;

namespace GameController.Commands
{
    public class ReviveFighter : IGameCommand
    {
        private Fighter _fighter;
        private int _amount;

        public ReviveFighter(Fighter fighter, int amount)
        {
            _fighter = fighter;
            _amount = amount;
        }

        public void Execute()
        {
            _fighter.Revive(_amount);  
        }

        public void Undo()
        {
            _fighter.Energy -= _amount;
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
