using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Template for an enemy
/// </summary>
public class EnemyType
{
    public string name;
    
    public int level1Atk;
    public int level1MAtk;
    public int level1Def;
    public int level1MDef;
    public int level1Health;
    
    //Average stat growth per level, slightly randomized per level for variation
    public int atkGrowth;
    public int mAtkGrowth;
    public int defGrowth;
    public int mDefGrowth;
    public int healthGrowth;

    public int aggroMean;
    public float aggroDist;
    public int packMean;
    public float packDist;

    //Add equipment and skills
}