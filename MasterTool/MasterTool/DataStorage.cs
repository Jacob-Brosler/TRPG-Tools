using System;
using System.Collections.Generic;
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
        public static List<ItemBase> BaseItemRegistry = new List<ItemBase>();
        //List of information on all battle items
        public static List<ItemBase> BattleItemRegistry = new List<ItemBase>();
        //List of information on all movement types
        public static List<MovementType> MovementRegistry = new List<MovementType>();
        //List of information on all weapon types
        public static List<WeaponType> WeaponTypeRegistry = new List<WeaponType>();
        //List of information on all status effects
        public static List<StatusEffectDefinition> StatusEffectRegistry = new List<StatusEffectDefinition>();
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
