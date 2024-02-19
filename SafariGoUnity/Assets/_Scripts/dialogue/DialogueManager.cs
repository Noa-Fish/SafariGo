/*
using System.Collections;
using TMPro;
using UnityEngine;
using System;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject dialogueTextObject;

   public void Start()
    {
       dialogueTextObject.SetActive(false);
    }

    public void StartDialogue()
    {
        dialogueTextObject.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }

   

   public IEnumerator TypeLine()
{
    textComponent.text = string.Empty; // Efface le texte précédent avant de commencer à taper la nouvelle ligne
    foreach (char c in lines[index].ToCharArray())
    {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
    }
}


    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Utilisation de GetMouseButtonDown avec une majuscule sur Input
        {
            if (textComponent.text == lines[index]) // Utilisation de == pour comparer l'égalité des chaînes
            {
                //NextLine();
                 StopAllCoroutines();
               
            }
            else
            {
                StopAllCoroutines(); // Utilisation de StopAllCoroutines pour arrêter toutes les coroutines en cours
                textComponent.text = lines[index];
            }
        }
    }
}
*/