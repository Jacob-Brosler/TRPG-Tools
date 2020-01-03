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
        public ToolHub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemDefinitions_Click(object sender, EventArgs e)
        {
            BasicItemTool itemScreen = new BasicItemTool();

            if (!itemScreen.IsDisposed)
                itemScreen.ShowDialog(this);
        }

        private void BattleItems_Click(object sender, EventArgs e)
        {
            BattleItemTool battleItemScreen = new BattleItemTool();

            if (!battleItemScreen.IsDisposed)
                battleItemScreen.ShowDialog(this);
        }

        private void PlayerTemplates_Click(object sender, EventArgs e)
        {
            PlayerTemplatesTool playerScreen = new PlayerTemplatesTool();

            if (!playerScreen.IsDisposed)
                playerScreen.ShowDialog(this);
        }

        private void EnemyDefinitions_Click(object sender, EventArgs e)
        {
            EnemyDefinitionsTool enemyScreen = new EnemyDefinitionsTool();

            if (!enemyScreen.IsDisposed)
                enemyScreen.ShowDialog(this);
        }

        private void WeaponTypes_Click(object sender, EventArgs e)
        {
            WeaponTypesTool weaponScreen = new WeaponTypesTool();

            if (!weaponScreen.IsDisposed)
                weaponScreen.ShowDialog(this);
        }

        private void TileTypes_Click(object sender, EventArgs e)
        {
            TileTypesTool tileScreen = new TileTypesTool();

            if (!tileScreen.IsDisposed)
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

        private void spellTrees_Click(object sender, EventArgs e)
        {
            SpellTreeTool spellScreen = new SpellTreeTool();

            if (!spellScreen.IsDisposed)
                spellScreen.ShowDialog(this);
        }

        private void Weapons_Click(object sender, EventArgs e)
        {
            WeaponTool weaponScreen = new WeaponTool();

            if(!weaponScreen.IsDisposed)
                weaponScreen.ShowDialog(this);
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            EquipmentTool equipmentScreen = new EquipmentTool();

            if (!equipmentScreen.IsDisposed)
                equipmentScreen.ShowDialog(this);
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            DataStorage.Load();
        }
    }
}
