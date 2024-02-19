using UnityEngine;

public class StayInTerrain : MonoBehaviour
{
    private Collider terrainCollider;

    private void Start()
    {
        // Récupérer le collider du terrain
        terrainCollider = GameObject.FindGameObjectWithTag("Terrain").GetComponent<Collider>();
    }

    private void Update()
    {
        // Vérifier si l'objet est en dehors du terrain
        if (!terrainCollider.bounds.Contains(transform.position))
        {
            // Si c'est le cas, ajuster la position de l'objet pour qu'il reste dans le terrain

            // Récupérer la position actuelle de l'objet
            Vector3 currentPosition = transform.position;

            // Récupérer les limites du terrain
            Vector3 minBounds = terrainCollider.bounds.min;
            Vector3 maxBounds = terrainCollider.bounds.max;

            // Ajuster la position de l'objet pour qu'il reste dans le terrain
            currentPosition.x = Mathf.Clamp(currentPosition.x, minBounds.x, maxBounds.x);
            currentPosition.z = Mathf.Clamp(currentPosition.z, minBounds.z, maxBounds.z);

            // Si l'objet touche le bord du terrain, le faire rebondir dans la direction opposée
            if (currentPosition.x == minBounds.x || currentPosition.x == maxBounds.x)
            {
                // Inverser la direction en x
                transform.forward = -transform.forward;
            }

            if (currentPosition.z == minBounds.z || currentPosition.z == maxBounds.z)
            {
                // Inverser la direction en z
                transform.forward = -transform.forward;
            }

            // Définir la nouvelle position de l'objet
            transform.position = currentPosition;
        }
    }
}
