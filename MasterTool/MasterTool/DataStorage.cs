using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool
{
    static class DataStorage
    {
        //List of information on all items
        public static IDictionary<string, ItemBase> ItemRegistry = new Dictionary<string, ItemBase>();
        //List of information on all movement types
        public static IDictionary<int, MovementType> MovementRegistry = new Dictionary<int, MovementType>();
        //List of information on all weapon types
        public static IDictionary<int, WeaponType> WeaponTypeRegistry = new Dictionary<int, WeaponType>();
        //List of information on all status effects
        public static IDictionary<Statuses, StatusEffectDefinition> StatusEffectRegistry = new Dictionary<Statuses, StatusEffectDefinition>();
        //List of all of the default effects a tile has. First is what happens when a pawn passes over the tile, Second is what happens when they are on it at the end of the turn
        public static IDictionary<int, TileEffects> DefaultTileEffects = new Dictionary<int, TileEffects>();

        public static void Load()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
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
