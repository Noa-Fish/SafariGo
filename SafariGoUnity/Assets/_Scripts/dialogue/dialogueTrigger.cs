/*
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager; // Assurez-vous d'attribuer le gestionnaire de dialogue dans l'éditeur Unity


     void OnTriggerEnter(Collider other)
    {
   
    
        Debug.Log("Collision détectée avec : " + other.gameObject.name);
        // Vous pouvez ajouter d'autres actions ici si nécessaire
    
       
        if (other.CompareTag("Player"))
        {   dialogueManager.StartDialogue();
            Debug.Log("Collision détectée avec : " + other.gameObject.name);
           
            

         
            Debug.Log("Collision détectée avec le joueur ! Affichage du dialogue...");
        }
    }
}
*/