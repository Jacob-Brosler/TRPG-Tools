
public class StatChangePart : SkillPartBase{

    //Stat modifier
    public Stats affectedStat;
    public int flatChange;
    public float multiplier;
    public int duration;

    public StatChangePart() { }

    public StatChangePart(TargettingType target, Stats affectedStat, int flatChange, float multiplier, int duration, int chance = 100) : base(target, chance)
    {
        this.affectedStat = affectedStat;
        this.flatChange = flatChange;
        this.multiplier = multiplier;
        this.duration = duration;
    }
}
