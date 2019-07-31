using MasterTool.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool
{
    public enum MoveTriggers
    {
        StartOfTurn,
        PassOver,
        StopOnTile,
        EndOfTurn
    }

    static class DataStorage
    {
        private static string savePoint;

        //List of information on all basic items
        public static BindingList<ItemBase> BaseItemRegistry = new BindingList<ItemBase>();
        //List of information on all battle items
        public static BindingList<ItemBase> BattleItemRegistry = new BindingList<ItemBase>();
        //List of information on all movement types
        public static BindingList<MovementType> MovementRegistry = new BindingList<MovementType>();
        //List of information on all weapon types
        public static BindingList<WeaponType> WeaponTypeRegistry = new BindingList<WeaponType>();
        //List of information on all status effects
        public static BindingList<StatusEffectDefinition> StatusEffectRegistry = new BindingList<StatusEffectDefinition>();
        //List of information on all spell trees
        public static BindingList<SpellTree> spellTreeRegistry = new BindingList<SpellTree>(); 
        //List of all of the default effects a tile has. First is what happens when a pawn passes over the tile, Second is what happens when they are on it at the end of the turn
        public static IDictionary<string, Dictionary<MoveTriggers, SkillPartBase>> DefaultTileEffects = new Dictionary<string, Dictionary<MoveTriggers, SkillPartBase>>();

        public static void Load()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    savePoint = fbd.SelectedPath;
                    string[] files = System.IO.Directory.GetFiles(fbd.SelectedPath);
                }
                else
                {
                    Load();
                }
            }
        }

        public static void Save()
        {

        }
    }
}
