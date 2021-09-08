using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    CharacterStats characterStats;
    IWeapon IEquippedWeapon;
    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();
    }
    public void Equip(Item itemToEquip)
    {
        if (EquippedWeapon != null)
        {
            characterStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }
        else
        {
            EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/"+itemToEquip.ItemName),
                playerHand.transform.position,
                playerHand.transform.rotation);

            IEquippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
            IEquippedWeapon.Stats = itemToEquip.ItemStats;
            EquippedWeapon.transform.SetParent(playerHand.transform);
            characterStats.AddStatBonus(itemToEquip.ItemStats);
            Debug.Log(IEquippedWeapon.Stats);

        }
    }
    //try to reduce usage of GetComponent
    public void Attack()
    {
        IEquippedWeapon.Attack();
    }
}
