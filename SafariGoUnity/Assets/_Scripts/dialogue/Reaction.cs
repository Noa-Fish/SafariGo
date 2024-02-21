using UnityEngine;
using DialogueEditor;

public class Reaction : MonoBehaviour
{
    [SerializeField] private NPCConversation npcConversation;
    [SerializeField] private NPCConversation GoodAnswerConversation; 
    [SerializeField] private NPCConversation BadAnswerConversation;

    private void OnTriggerEnter(Collider aliment)
    {
        if (aliment.CompareTag("Herbe") ||
            aliment.CompareTag("Viande"))
            //other.CompareTag("WhiteTiger") ||
            //other.CompareTag("Crocodile") ||
            //other.CompareTag("Leopard") ||
            //other.CompareTag("Lion"))
        {
            string tagDeCeGameObject = gameObject.tag;

            if (npcConversation == null)
            {
                npcConversation = GetComponent<NPCConversation>();
            }

            if (npcConversation != null)
            {
                CheckFoodForAnimal(tagDeCeGameObject, aliment.tag, GoodAnswerConversation, BadAnswerConversation);
                Debug.Log("Start of the conversation.");
            }
            else
            {
                Debug.LogError("NPCConversation not found or not attached to the object.");
            }
        }
        else
        {
            Debug.Log(aliment.tag);
            Debug.Log(aliment);
            Debug.LogWarning("Unknown animal detected.");
        }
    }


    private void CheckFoodForAnimal( string animalTag, string foodTag, NPCConversation GoodAnswerConversation, NPCConversation BadAnswerConversation) 
    {
        // Récupérer tous les GameObjects avec le tag de l'animal
        GameObject[] animals = GameObject.FindGameObjectsWithTag(animalTag);

      
        foreach (GameObject animal in animals)
        {
            Debug.Log(animal);
            // Vérifier quel est l'animal et vérifier si la nourriture est appropriée
            if (animal.CompareTag("Elephant") && foodTag == "Herbe")
            {
                Debug.Log("Herbe est bonne pour l'éléphant!");
                ConversationManager.Instance.StartConversation(GoodAnswerConversation);
            }
            else if (animal.CompareTag("Girafe") && foodTag == "Herbe")
            {
                ConversationManager.Instance.StartConversation(GoodAnswerConversation);
            }
            else if (animal.CompareTag("WhiteTiger") && foodTag == "Viande")
            {
                ConversationManager.Instance.StartConversation(GoodAnswerConversation);
            }
            else if (animal.CompareTag("Crocodile") && foodTag == "Viande")
            {
                ConversationManager.Instance.StartConversation(GoodAnswerConversation);
            }
            else if (animal.CompareTag("Lion") && foodTag == "Viande")
            {
                ConversationManager.Instance.StartConversation(GoodAnswerConversation);
            }
            else
            {
                ConversationManager.Instance.StartConversation(BadAnswerConversation);
            }
        }
    }
}
