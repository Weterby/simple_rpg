using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueController : MonoBehaviour
{
    public static DialogueController Instance { get; set; }
    public List<string> dialogueLines = new List<string>();

    private string npcName;

    [SerializeField]
    private GameObject dialoguePanel;
    private Button continueButton;
    private Text dialogueText, nameText;
    private int dialogueIndex;
    void Awake()
    {
        continueButton = dialoguePanel.transform.Find("ContinueButton").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("DialogueText").GetComponent<Text>();
        nameText = dialoguePanel.transform.Find("NamePanel").GetChild(0).GetComponent<Text>();

        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });

        dialoguePanel.SetActive(false);

        if(Instance!=null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[0];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }

    public void AddNewDialogue(string[] sentences, string npcName)
    {
        dialogueIndex = 0;
        this.npcName = npcName;
        dialogueLines = new List<string>(sentences.Length);
        dialogueLines.AddRange(sentences);

        CreateDialogue();
    }
    
    public void ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count-1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
