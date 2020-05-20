using System.Collections.Generic;

public class WeaponType
{
    public string name { get; set; }
    //List of special effects acivated at certain ranges
    public List<WeaponStatsAtRange> ranges;
    public List<WeaponStatsAtRange> diagonalRanges;
    public WeaponType(string n, List<WeaponStatsAtRange> orthoRanges, List<WeaponStatsAtRange> diagRanges)
    {
        name = n;
        ranges = orthoRanges;
        diagonalRanges = diagRanges;
    }
}