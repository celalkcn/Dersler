using System;

namespace Odev3;

public class Manager : Calısan
{
    public Manager(string name, int ıd, int salary, int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams = numberOfTeams;
    }
    public int NumberOfTeams { get; set; }

}
