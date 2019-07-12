using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WeaponType
{
    string name;
    //List of special effects acivated at certain ranges
    public List<WeaponStatsAtRange> ranges;
    public List<WeaponStatsAtRange> diagonalRanges;
    public WeaponType(string n)
    {
        name = n;
        ranges = new List<WeaponStatsAtRange>();
        diagonalRanges = new List<WeaponStatsAtRange>();
    }
}