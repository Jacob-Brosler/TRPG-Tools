using System.Collections;
using System.Collections.Generic;

public enum EffectTriggers
{
    FallBelow25Percent,
    FallBelow50Percent,
    RiseAbove25Percent,
    RiseAbove50Percent,
    TakeDamage,
    DealDamage,
    TakePhysicalDamage,
    DealPhysicalDamage,
    TakeMagicDamage,
    DealMagicDamage,
    BasicAttack,
    HitWithBasicAttack,
    SpellCast,
    DealSpellDamage,
    HealWithSpell,
    KillAnEnemy,
    Die,
    GettingHealed,
    Healing,
    StartOfMatch,
    StartOfTurn,
    EndOfTurn,
    EndOfMatch
}

public class TriggeredEffect
{
    //What event triggers this set of effects
    public EffectTriggers trigger;
    //The effects
    public List<SkillPartBase> effects = new List<SkillPartBase>();

    public TriggeredEffect(EffectTriggers trigger, SkillPartBase effect = null)
    {
        this.trigger = trigger;
        if (effect != null)
            AddEffect(effect);
    }

    public void AddEffect(SkillPartBase effect)
    {
        effects.Add(effect);
    }
}
