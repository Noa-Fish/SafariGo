using UnityEngine;

public class WhiteTigerTerrain : MonoBehaviour
{
    public float rotationSpeed = 20f; // Vitesse de rotation de l'éléphant
    public float moveSpeed = 5f; // Vitesse de déplacement de l'éléphant
    private Transform terrainTransform; // Référence au transform du terrain

    private void Start()
    {
        // Récupérer le transform du terrain
        GameObject terrainObject = GameObject.FindGameObjectWithTag("WhiteTigerTerrain");
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
            // Calculer la direction vers laquelle l'éléphant doit faire face
            Vector3 targetDirection = terrainTransform.position - transform.position;
            targetDirection.y = 0f; // Ignorer la composante Y pour éviter l'inclinaison

            // Calculer la rotation vers la direction cible
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

            // Tourner l'éléphant progressivement vers la direction cible
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);

            // Déplacer l'éléphant vers l'avant dans sa propre direction (direction locale de l'axe Z)
            transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
