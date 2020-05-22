using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;
using System.Linq;
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
        //List of information on all basic items
        public static BindingList<ItemBase> BaseItemRegistry = new BindingList<ItemBase>();
        //List of information on all battle items
        public static BindingList<BattleItemBase> BattleItemRegistry = new BindingList<BattleItemBase>();
        //List of information on all weapon types
        public static BindingList<WeaponType> WeaponTypeRegistry = new BindingList<WeaponType>();
        //List of information on all basic items
        public static BindingList<EquippableBase> WeaponRegistry = new BindingList<EquippableBase>();
        //List of information on all basic items
        public static BindingList<EquippableBase> EquipmentRegistry = new BindingList<EquippableBase>();
        //List of information on all status effects
        public static BindingList<StatusEffectDefinition> StatusEffectRegistry = new BindingList<StatusEffectDefinition>();
        //List of information on all spell trees
        public static BindingList<SpellTree> SpellTreeRegistry = new BindingList<SpellTree>();
        //List of all of the tile types and their effects
        public static BindingList<TileType> TileEffectsRegistry = new BindingList<TileType>();
        //List of information on all movement types
        public static BindingList<MovementType> MovementRegistry = new BindingList<MovementType>();
        //List of information on all player templates ?????????? NEEDS TO BE REPLACED ONCE PLAYER TOOL IS DONE
        public static BindingList<EnemyType> PlayerRegistry = new BindingList<EnemyType>();
        //List of information on all enemy type templates
        public static BindingList<EnemyType> EnemyTypeRegistry = new BindingList<EnemyType>();

        public static void Load()
        {
            using (var fileSelect = new OpenFileDialog())
            {
                fileSelect.Filter = "json files (*.json)|*.json";
                fileSelect.CheckPathExists = true;
                fileSelect.CheckFileExists = true;
                fileSelect.DefaultExt = "json";
                fileSelect.Title = "Load";
                DialogResult result = fileSelect.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileSelect.FileName))
                {
                    using (StreamReader reader = new StreamReader(fileSelect.FileName))
                    {
                        var dataDumpType = new
                        {
                            BaseItems = new ItemBase[] { },
                            BattleItems = new BattleItemBase[] { },
                            WeaponTypes = new WeaponType[] { },
                            Weapons = new EquippableBase[] { },
                            Equipment = new EquippableBase[] { },
                            StatusEffects = new StatusEffectDefinition[] { },
                            SpellTrees = new SpellTree[] { },
                            TileEffects = new TileType[] { },
                            MoveTypes = new MovementType[] { },
                            PlayerDefs = new EnemyType[] { },
                            EnemyDefs = new EnemyType[] { }
                        };

                        var settings = new JsonSerializerSettings();
                        settings.Converters.Add(new SkillPartJsonConverter());

                        var dataDump = JsonConvert.DeserializeAnonymousType(reader.ReadToEnd(), dataDumpType, settings);
                        foreach (ItemBase item in dataDump.BaseItems) { BaseItemRegistry.Add(item); }
                        foreach (BattleItemBase item in dataDump.BattleItems) { BattleItemRegistry.Add(item); }
                        foreach (WeaponType item in dataDump.WeaponTypes) { WeaponTypeRegistry.Add(item); }
                        foreach (EquippableBase item in dataDump.Weapons) { WeaponRegistry.Add(item); }
                        foreach (EquippableBase item in dataDump.Equipment) { EquipmentRegistry.Add(item); }
                        foreach (StatusEffectDefinition item in dataDump.StatusEffects) { StatusEffectRegistry.Add(item); }
                        foreach (SpellTree item in dataDump.SpellTrees) { SpellTreeRegistry.Add(item); }
                        foreach (TileType item in dataDump.TileEffects) { TileEffectsRegistry.Add(item); }
                        foreach (MovementType item in dataDump.MoveTypes) { MovementRegistry.Add(item); }
                        foreach (EnemyType item in dataDump.PlayerDefs) { PlayerRegistry.Add(item); }
                        foreach (EnemyType item in dataDump.EnemyDefs) { EnemyTypeRegistry.Add(item); }
                    }
                }
            }
        }

        public static void Save()
        {
            using (SaveFileDialog fileSelect = new SaveFileDialog())
            {
                fileSelect.Filter = "json files (*.json)|*.json";
                fileSelect.CheckPathExists = true;
                fileSelect.DefaultExt = "json";
                fileSelect.Title = "Save";
                DialogResult result = fileSelect.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileSelect.FileName))
                {
                    var savingData = new
                    {
                        BaseItems = BaseItemRegistry.ToArray(),
                        BattleItems = BattleItemRegistry.ToArray(),
                        WeaponTypes = WeaponTypeRegistry.ToArray(),
                        Weapons = WeaponRegistry.ToArray(),
                        Equipment = EquipmentRegistry.ToArray(),
                        StatusEffects = StatusEffectRegistry.ToArray(),
                        SpellTrees = SpellTreeRegistry.ToArray(),
                        TileEffects = TileEffectsRegistry.ToArray(),
                        MoveTypes = MovementRegistry.ToArray(),
                        PlayerDefs = PlayerRegistry.ToArray(),
                        EnemyDefs = EnemyTypeRegistry.ToArray()
                    };

                    using (StreamWriter writer = new StreamWriter(fileSelect.FileName))
                    {
                        writer.WriteLine(JsonConvert.SerializeObject(savingData));

                        MessageBox.Show("File written.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
