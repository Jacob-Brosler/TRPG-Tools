public class StatMod
{
    public Stats affectedStat;
    public int flatChange;
    public float multiplier;
    public int duration;
    public StatMod(Stats affectedStat, int flatChange, float multiplier, int duration)
    {
        this.affectedStat = affectedStat;
        this.flatChange = flatChange;
        this.multiplier = multiplier;
        this.duration = duration;
    }
}

public class StatChangePart : SkillPartBase
{
    //Stat modifier
    public StatMod statMod;

    public StatChangePart() { }

    public StatChangePart(TargettingType target, Stats affectedStat, int flatChange, float multiplier, int duration, int chance = 100) : base(target, chance)
    {
        this.statMod = new StatMod(affectedStat, flatChange, multiplier, duration);
    }
}
