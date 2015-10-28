namespace GameController.Commands
{
    public interface IGameCommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
