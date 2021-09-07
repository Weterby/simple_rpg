using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatistics : MonoBehaviour
{
    public List<BaseStat> Stats { get; set; }

    private void Start()
    {
        Stats.Add(new BaseStat(10, "Strength", "Determines the character's attack power"));
        Stats[0].AddStatBonus(new BonusStatistic(5));
        Debug.Log(Stats[0].GetCalculatedStatBonus());

    }
}
