using System;
using System.Collections;
using System.Collections.Generic;

public enum Stats
{
    MaxHealth,
    Attack,
    Defense,
    MagicAttack,
    MagicDefense,
    CritChance,
    MaxMove,
    BasicAttackLifesteal,
    SpellLifesteal,
    BasicAttackEffectiveness,
    BasicAttackReceptiveness,
    SpellDamageEffectiveness,
    SpellDamageReceptiveness,
    HealingEffectiveness,
    HealingReceptiveness
}

/// <summary>
/// A basic item
/// </summary>
public class ItemBase
{
    public string Name
    {
        get
        {
            return name;
        }
    }

    public string name;
    //Max amount the player can hold
    public int maxStack;
    //How much one of this item sells for
    public int sellAmount;
    public string flavorText;

    public ItemBase(string name, int maxstack, int sell, string flavor = "")
    {
        this.name = name;
        maxStack = maxstack;
        sellAmount = sell;
        flavorText = flavor;
    }
}

/// <summary>
/// An item that can be equipped to a pawn
/// </summary>
public class EquippableBase : ItemBase
{
    public Dictionary<Stats, int> stats = new Dictionary<Stats, int>();

    //0 = weapon, 1 = helmet, 2 = chestplate, 3 = legs, 4 = boots, 5 = gloves, 6 = accessory
    public int equipSlot;

    /// <summary>
    /// Weapon: ID of it's weapon type
    /// Armor: Heavy, medium, light
    /// </summary>
    public int subType;

    /// <summary>
    /// Keeps track of the battle-mutable effect limiters for each triggerable effect
    /// The TemporaryEffectData here should never be modified
    /// </summary>
    public List<Tuple<TriggeredEffect, TemporaryEffectData>> effects = new List<Tuple<TriggeredEffect, TemporaryEffectData>>();
    
    public EquippableBase(string name, int slot, int subtype, int sellPrice, string flavor, Dictionary<Stats, int> stats) : base(name, 1, sellPrice, flavor)
    {
        equipSlot = slot;
        subType = subtype;
        this.stats = stats;
    }

    public void AddEffect(TriggeredEffect effect, int maxTimesThisBattle = -1, int turnCooldown = -1, int maxActiveTurns = -1)
    {
        effects.Add(new Tuple<TriggeredEffect, TemporaryEffectData>(effect, new TemporaryEffectData(maxTimesThisBattle, turnCooldown, maxActiveTurns)));
    }
}

/// <summary>
/// An item that has an effect when used during battle
/// </summary>
public class BattleItemBase : ItemBase
{
    public TargettingType targetType;

    //Is this item can be used outside of battle
    public bool usableOutOfBattle;

    public List<SkillPartBase> partList = new List<SkillPartBase>();

    public BattleItemBase(string name, TargettingType targetType, bool outOfBattleUse, List<SkillPartBase> effects, int maxStack, int sellPrice, string flavor = "") : base(name, maxStack, sellPrice, flavor)
    {
        this.targetType = targetType;
        usableOutOfBattle = outOfBattleUse;
        partList.AddRange(effects);
    }
}