using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    [SerializeField]
    private string[] dialogue;
    public string npcName;
    public override void Interact()
    {
        DialogueController.Instance.AddNewDialogue(dialogue, npcName);
        Debug.Log("Interacting with npc");
    }
}
