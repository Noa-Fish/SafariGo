using UnityEngine;
using DialogueEditor;

public class SphereTrigger : MonoBehaviour
{
    // Référence à la conversation à démarrer
    [SerializeField] private NPCConversation myConversation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Démarre la conversation lorsque le joueur entre dans le déclencheur
            ConversationManager.Instance.StartConversation(myConversation);
            
            // Affiche un message pour indiquer le début de la conversation
            Debug.Log("Début de la conversation.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CheckAnswerAndDisplayMessage();
            // Affiche un message pour indiquer la fin de la conversation lorsque le joueur quitte le déclencheur
            Debug.Log("Fin de la conversation.");
            //CheckAnswerAndDisplayMessage();
            
        }
    }

    // Méthode appelée pour vérifier la réponse de l'utilisateur et afficher un message en conséquence
    private void CheckAnswerAndDisplayMessage()
    {
         Debug.Log("test.");
        // Vérifie si la réponse de l'utilisateur est correcte
        bool isCorrectAnswer = ConversationManager.Instance.GetBool("CorrectAnswer");

        if (!isCorrectAnswer)
        {
            // Affiche un message car la réponse est incorrecte
            Debug.Log("Votre réponse est incorrecte. Veuillez réessayer !");
        }
        else
        {
           
            Debug.Log("Bravo, vous avez donné la bonne réponse !");
        }
    }

   
}
