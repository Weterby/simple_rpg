using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public List<BaseStat> Stats { get; set; }

    private void Start()
    {
        Stats = new List<BaseStat>();
        Stats.Add(new BaseStat(10, "Strength", "Determines the character's attack power"));
        Stats.Add(new BaseStat(20, "Vitality", "Determines the character's health points"));

        Debug.Log(Stats[0].GetCalculatedStatBonus());

    }

    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat stat in statBonuses)
        {
            Stats.Find(x => x.StatName == stat.StatName).AddStatBonus(new BonusStat(stat.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat stat in statBonuses)
        {
            Stats.Find(x => x.StatName == stat.StatName).RemoveStatBonus(new BonusStat(stat.BaseValue));
        }
    }
}
