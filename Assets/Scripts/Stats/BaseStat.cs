using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseStat
{
    public List<BonusStat> BaseModifiers { get; set; }
    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public int FinalValue { get; set; }

    public BaseStat(int baseValue, string statName, string statDescription)
    {
        this.BaseModifiers = new List<BonusStat>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDescription;
    }

    public void AddStatBonus(BonusStat bonusStat)
    {
        this.BaseModifiers.Add(bonusStat);
    }

    public void RemoveStatBonus(BonusStat bonusStat)
    {
        this.BaseModifiers.Remove(BaseModifiers.Find(x=>x.BonusValue==bonusStat.BonusValue));
    }

    public int GetCalculatedStatBonus()
    {
        FinalValue = 0;
        BaseModifiers.ForEach(x => this.FinalValue += x.BonusValue);
        FinalValue += BaseValue;
        return FinalValue;
    }
}
