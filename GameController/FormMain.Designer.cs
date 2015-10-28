using System.ComponentModel;
using System.Windows.Forms;

namespace GameController
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboFighterType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEnergy = new System.Windows.Forms.GroupBox();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.grpDamage = new System.Windows.Forms.GroupBox();
            this.labelDamage = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.labelUndoItems = new System.Windows.Forms.Label();
            this.labelRedoItems = new System.Windows.Forms.Label();
            this.labelUndoItems1 = new System.Windows.Forms.Label();
            this.labelRedoItems1 = new System.Windows.Forms.Label();
            this.grpController = new System.Windows.Forms.GroupBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.grpEnergy.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.grpDamage.SuspendLayout();
            this.grpController.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFighterType
            // 
            this.cboFighterType.FormattingEnabled = true;
            this.cboFighterType.Items.AddRange(new object[] {
            "Student Fighter",
            "Classic Fighter",
            "Master Fighter"});
            this.cboFighterType.Location = new System.Drawing.Point(14, 23);
            this.cboFighterType.Name = "cboFighterType";
            this.cboFighterType.Size = new System.Drawing.Size(376, 21);
            this.cboFighterType.TabIndex = 0;
            this.cboFighterType.SelectedIndexChanged += new System.EventHandler(this.cboFighterType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Fighter Type:";
            // 
            // grpEnergy
            // 
            this.grpEnergy.Controls.Add(this.labelEnergy);
            this.grpEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnergy.Location = new System.Drawing.Point(4, 213);
            this.grpEnergy.Name = "grpEnergy";
            this.grpEnergy.Size = new System.Drawing.Size(130, 100);
            this.grpEnergy.TabIndex = 10;
            this.grpEnergy.TabStop = false;
            this.grpEnergy.Text = "Energy:";
            // 
            // labelEnergy
            // 
            this.labelEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergy.Location = new System.Drawing.Point(7, 18);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(117, 74);
            this.labelEnergy.TabIndex = 0;
            this.labelEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.labelLocation);
            this.grpLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocation.Location = new System.Drawing.Point(136, 213);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(130, 100);
            this.grpLocation.TabIndex = 11;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location:";
            // 
            // labelLocation
            // 
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(7, 18);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(117, 74);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDamage
            // 
            this.grpDamage.Controls.Add(this.labelDamage);
            this.grpDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDamage.Location = new System.Drawing.Point(268, 213);
            this.grpDamage.Name = "grpDamage";
            this.grpDamage.Size = new System.Drawing.Size(130, 100);
            this.grpDamage.TabIndex = 12;
            this.grpDamage.TabStop = false;
            this.grpDamage.Text = "Inflicted Damage:";
            // 
            // labelDamage
            // 
            this.labelDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamage.Location = new System.Drawing.Point(7, 18);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(117, 74);
            this.labelDamage.TabIndex = 1;
            this.labelDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(354, 316);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(44, 17);
            this.btnRedo.TabIndex = 14;
            this.btnRedo.Text = "REDO";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(308, 316);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(44, 17);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // labelUndoItems
            // 
            this.labelUndoItems.AutoSize = true;
            this.labelUndoItems.Location = new System.Drawing.Point(8, 317);
            this.labelUndoItems.Name = "labelUndoItems";
            this.labelUndoItems.Size = new System.Drawing.Size(108, 13);
            this.labelUndoItems.TabIndex = 15;
            this.labelUndoItems.Text = "Items on Undo stack:";
            // 
            // labelRedoItems
            // 
            this.labelRedoItems.AutoSize = true;
            this.labelRedoItems.Location = new System.Drawing.Point(147, 317);
            this.labelRedoItems.Name = "labelRedoItems";
            this.labelRedoItems.Size = new System.Drawing.Size(108, 13);
            this.labelRedoItems.TabIndex = 16;
            this.labelRedoItems.Text = "Items on Redo stack:";
            // 
            // labelUndoItems1
            // 
            this.labelUndoItems1.AutoSize = true;
            this.labelUndoItems1.Location = new System.Drawing.Point(111, 317);
            this.labelUndoItems1.Name = "labelUndoItems1";
            this.labelUndoItems1.Size = new System.Drawing.Size(13, 13);
            this.labelUndoItems1.TabIndex = 17;
            this.labelUndoItems1.Text = "0";
            // 
            // labelRedoItems1
            // 
            this.labelRedoItems1.AutoSize = true;
            this.labelRedoItems1.Location = new System.Drawing.Point(250, 317);
            this.labelRedoItems1.Name = "labelRedoItems1";
            this.labelRedoItems1.Size = new System.Drawing.Size(13, 13);
            this.labelRedoItems1.TabIndex = 18;
            this.labelRedoItems1.Text = "0";
            // 
            // grpController
            // 
            this.grpController.Controls.Add(this.btnA);
            this.grpController.Controls.Add(this.btnB);
            this.grpController.Controls.Add(this.btnStart);
            this.grpController.Controls.Add(this.btnSelect);
            this.grpController.Controls.Add(this.btnLeft);
            this.grpController.Controls.Add(this.btnRight);
            this.grpController.Controls.Add(this.btnDown);
            this.grpController.Controls.Add(this.btnUp);
            this.grpController.Enabled = false;
            this.grpController.Location = new System.Drawing.Point(4, 50);
            this.grpController.Name = "grpController";
            this.grpController.Size = new System.Drawing.Size(393, 160);
            this.grpController.TabIndex = 19;
            this.grpController.TabStop = false;
            this.grpController.Text = "Game Controller";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(342, 62);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(40, 43);
            this.btnA.TabIndex = 16;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(296, 62);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(40, 43);
            this.btnB.TabIndex = 15;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(223, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 17);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(177, 73);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(44, 17);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(11, 70);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(61, 26);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(94, 70);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(61, 26);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(70, 94);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 61);
            this.btnDown.TabIndex = 12;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(70, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 61);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 335);
            this.Controls.Add(this.grpController);
            this.Controls.Add(this.labelRedoItems1);
            this.Controls.Add(this.labelUndoItems1);
            this.Controls.Add(this.labelRedoItems);
            this.Controls.Add(this.labelUndoItems);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.grpDamage);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.grpEnergy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFighterType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Silly Little Command Example";
            this.grpEnergy.ResumeLayout(false);
            this.grpLocation.ResumeLayout(false);
            this.grpDamage.ResumeLayout(false);
            this.grpController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboFighterType;
        private Label label1;
        private GroupBox grpEnergy;
        private GroupBox grpLocation;
        private GroupBox grpDamage;
        private Label labelEnergy;
        private Label labelLocation;
        private Label labelDamage;
        private Button btnRedo;
        private Button btnUndo;
        private Label labelUndoItems;
        private Label labelRedoItems;
        private Label labelUndoItems1;
        private Label labelRedoItems1;
        private GroupBox grpController;
        private Button btnA;
        private Button btnB;
        private Button btnStart;
        private Button btnSelect;
        private Button btnLeft;
        private Button btnRight;
        private Button btnDown;
        private Button btnUp;
    }
}