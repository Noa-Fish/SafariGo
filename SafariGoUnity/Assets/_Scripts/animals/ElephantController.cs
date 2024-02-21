using UnityEngine;

public class ElephantController : MonoBehaviour
{
    public float rotationSpeed = 20f; // Vitesse de rotation de l'éléphant
    public float moveSpeed = 5f; // Vitesse de déplacement de l'éléphant
    private Transform terrainTransform; // Référence au transform du terrain

    private void Start()
    {
        // Récupérer le transform du terrain
        GameObject terrainObject = GameObject.FindGameObjectWithTag("Terrain");
        if (terrainObject != null)
        {
            terrainTransform = terrainObject.transform;
        }
        else
        {
            Debug.LogError("Terrain object not found. Make sure an object with the tag 'terrain' exists in the scene.");
        }
    }

    private void FixedUpdate()
    {
        if (terrainTransform != null)
        {
        
            transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime);

           
            Vector3 terrainDirection = terrainTransform.position - transform.position;
            terrainDirection.y = 0f; 

            
            Quaternion targetRotation = Quaternion.LookRotation(terrainDirection);

            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
