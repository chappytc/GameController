using System.Collections;
using System.ComponentModel;
using System.Security.Policy;
using GameController.Commands;

namespace GameController
{
    public class GameController : INotifyPropertyChanged
    {
        private Stack _undoStack;
        private Stack _redoStack;

        public int UndoStackCount
        {
            get { return _undoStack.Count; }
        }

        public int RedoStackCount
        {
            get { return _redoStack.Count; }
        }
     
        public GameController()
        {
            _undoStack = new Stack();
            _redoStack = new Stack();
        }

        public void ExecuteCommand(IGameCommand cmd)
        {
            cmd.Execute();

            _undoStack.Push(cmd);
            OnPropertyChanged("UndoStackCount");

            if (_redoStack.Count > 0)
            {
                _redoStack.Clear();
                OnPropertyChanged("RedoStackCount");
            }
        }
        
        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                IGameCommand cmd = (IGameCommand)_undoStack.Pop();
                cmd.Undo();
                _redoStack.Push(cmd);

                OnPropertyChanged("UndoStackCount");
                OnPropertyChanged("RedoStackCount");
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                IGameCommand cmd = (IGameCommand)_redoStack.Pop();
                cmd.Redo();
                _undoStack.Push(cmd);

                OnPropertyChanged("UndoStackCount");
                OnPropertyChanged("RedoStackCount");
            }
        }

        // Easter Egg - Not the best implementation; just a little fun.
        public bool DoesKonamiLiveOn()
        {
            bool returnValue = false;
            if (_undoStack.Count >= 10)
            {
                object[] cmds = _undoStack.ToArray();
                if (cmds[0].GetType() == typeof (MakeFighterKick))
                {
                    if (cmds[1].GetType() == typeof(MakeFighterPunch))
                    {
                        if (cmds[2].GetType() == typeof (MakeFighterMoveRight) &&
                            cmds[4].GetType() == typeof(MakeFighterMoveRight))
                        {
                            if (cmds[3].GetType() == typeof (MakeFighterMoveLeft) &&
                                cmds[5].GetType() == typeof(MakeFighterMoveLeft))
                            {
                                if (cmds[6].GetType() == typeof (MakeFighterDodge) &&
                                    cmds[7].GetType() == typeof(MakeFighterDodge))
                                {
                                    if (cmds[8].GetType() == typeof(MakeFighterJump) &&
                                        cmds[9].GetType() == typeof(MakeFighterJump))
                                    {
                                        returnValue = true;
                                    }
                                }
                            }
                        }
                    }
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
