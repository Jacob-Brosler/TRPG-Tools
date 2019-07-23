using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class SkillPartTool : Form
    {
        public SkillPartBase returnSkill;
        private GroupBox[] panels;

        public SkillPartTool()
        {
            InitializeComponent();
            panels = new GroupBox[] { addTriggerBox };
        }

        /// <summary>
        /// Saves the created effect
        /// </summary>
        private void SkillPartTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (typeSelector.SelectedItem)
            {
                case "Add Trigger":
                    returnSkill = new AddTriggerPart((TargettingType)targetType.SelectedIndex, 
                        new TriggeredEffect((EffectTriggers)addTriggerTrigger.SelectedIndex),
                        (timesPerBattle.Checked ? (int)timesPerBattleCount.Value : -1),
                        (turnCD.Checked ? (int)cooldownCount.Value : -1),
                        (activeTurns.Checked ? (int)activeTurnCount.Value : -1),
                        (int)chance.Value);
                    break;
            }
        }

        /// <summary>
        /// Switches the shown effect options to match the new selection
        /// </summary>
        private void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < panels.Length; i++)
            {
                panels[i].Enabled = (i == typeSelector.SelectedIndex);
                panels[i].Visible = (i == typeSelector.SelectedIndex);
            }
        }
    }
}
