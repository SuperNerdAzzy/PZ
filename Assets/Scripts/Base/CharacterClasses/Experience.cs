using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make static?
public class Experience {

    int[] XPToLevel =
    {
        0, 100, 300, 900, 1800
    };
    int MaxLevel;
    int CurrentLevel;
    int CurrentXP;
    int XPToNextLevel;

    public Experience()
    {
        MaxLevel = 100;
        CurrentLevel = 1;
        CurrentXP = 0;
        XPToNextLevel = GetXPToNextLevel();
    }

    public void LevelUp()
    {
        CurrentLevel++;
        CurrentXP = XPToLevel[CurrentLevel - 1];
    }

    public void AddXP(int xp)
    {
        CurrentXP += xp;
        if (xp >= GetXPToNextLevel()) CurrentLevel++;   //TODO: Make a func for this
    }

    int GetXPToNextLevel()
    {
        return XPToLevel[CurrentLevel] - XPToLevel[CurrentLevel - 1];
    }
}
