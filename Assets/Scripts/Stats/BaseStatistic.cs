using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseStat
{
    public List<BonusStatistic> BaseModifiers { get; set; }
    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public int FinalValue { get; set; }

    public BaseStat(int baseValue, string statName, string statDescription)
    {
        this.BaseModifiers = new List<BonusStatistic>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDescription;
    }

    public void AddStatBonus(BonusStatistic bonusStat)
    {
        this.BaseModifiers.Add(bonusStat);
    }

    public void RemoveStatBonus(BonusStatistic bonusStat)
    {
        this.BaseModifiers.Remove(bonusStat);
    }

    public int GetCalculatedStatBonus()
    {
        this.BaseModifiers.ForEach(x => this.FinalValue += x.BonusValue);
        FinalValue += BaseValue;
        return FinalValue;
    }
}
