using System;
using System.Windows.Forms;
using GameController.Commands;
using GameController.Fighters;

namespace GameController
{
    public partial class FormMain : Form
    {
        private Fighter _fighter;
        private GameController _invokerGameController;

        public FormMain()
        {
            InitializeComponent();            
        }

        private void cboFighterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFighterType();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterJump(_fighter));
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterMoveRight(_fighter));
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterDodge(_fighter));
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterMoveLeft(_fighter));
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterPunch(_fighter));
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            _invokerGameController.ExecuteCommand(new MakeFighterKick(_fighter));

            // A little throwback easter egg
            if (_invokerGameController.DoesKonamiLiveOn())
                MessageBox.Show("The Konami Code Lives On!", "UP UP DOWN DOWN LEFT RIGHT LEFT RIGHT B A");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetFighterType();
        }

        private void GetFighterType()
        {
            grpController.Enabled = false;

            _invokerGameController = new GameController();

            FighterFactory newFactory = new FighterFactory();
            _fighter = newFactory.CreateFighter(cboFighterType.Text);

            labelEnergy.DataBindings.Clear();
            labelEnergy.DataBindings.Add(new Binding("Text", _fighter, "Energy"));

            labelLocation.DataBindings.Clear();
            labelLocation.DataBindings.Add(new Binding("Text", _fighter, "Location"));

            labelDamage.DataBindings.Clear();
            labelDamage.DataBindings.Add(new Binding("Text", _fighter, "InflictedDamage"));

            labelUndoItems1.DataBindings.Clear();
            labelUndoItems1.DataBindings.Add(new Binding("Text", _invokerGameController, "UndoStackCount"));

            labelRedoItems1.DataBindings.Clear();
            labelRedoItems1.DataBindings.Add(new Binding("Text", _invokerGameController, "RedoStackCount"));

            grpController.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _invokerGameController.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            _invokerGameController.Redo();
        }
    }
}
