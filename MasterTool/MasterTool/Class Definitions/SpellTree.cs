﻿using System.ComponentModel;

public class SpellTree
{
    public string name { get; set; }

    public BindingList<Skill> spells;

    public SpellTree(string name, BindingList<Skill> spells)
    {
        this.name = name;
        this.spells = spells;
    }
}