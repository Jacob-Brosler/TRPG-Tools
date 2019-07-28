using MasterTool.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool
{
    public partial class ToolHub : Form
    {
        public BasicItemTool itemScreen;
        public BattleItemTool battleItemScreen;

        public ToolHub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemDefinitions_Click(object sender, EventArgs e)
        {
            if(itemScreen == null)
                itemScreen = new BasicItemTool();

            itemScreen.ShowDialog(this);
        }

        private void BattleItems_Click(object sender, EventArgs e)
        {
            if (battleItemScreen == null)
                battleItemScreen = new BattleItemTool();

            battleItemScreen.ShowDialog(this);
        }

        private void PlayerTemplates_Click(object sender, EventArgs e)
        {
            PlayerTemplatesTool playerScreen = new PlayerTemplatesTool();

            playerScreen.ShowDialog(this);
        }

        private void EnemyDefinitions_Click(object sender, EventArgs e)
        {
            EnemyDefinitionsTool enemyScreen = new EnemyDefinitionsTool();

            enemyScreen.ShowDialog(this);
        }

        private void WeaponTypes_Click(object sender, EventArgs e)
        {
            WeaponTypesTool weaponScreen = new WeaponTypesTool();

            weaponScreen.ShowDialog(this);
        }

        private void TileTypes_Click(object sender, EventArgs e)
        {
            TileTypesTool tileScreen = new TileTypesTool();

            tileScreen.ShowDialog(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: Saving any changes that affect an object currently in use in a save file can corrupt the save. Please exercise caution.",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DataStorage.Save();
            }
        }
    }
}
