using System.Collections;
using System.Collections.Generic;

public interface IWeapon
{
    List<BaseStat> Stats { get; set; }
    void Attack();
}
