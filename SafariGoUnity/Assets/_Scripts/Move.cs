using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Collider terrainCollider; 
    // Start is called before the first frame update
    void Start()
    {
        if (terrainCollider == null)
        {
            Debug.LogError("Terrain Collider not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithinTerrain();
    }

    void MoveWithinTerrain()
    {
        // Logique de déplacement de votre éléphant
        // Par exemple, vous pouvez utiliser des waypoints ou d'autres méthodes de déplacement

        // Assurez-vous que l'éléphant reste à l'intérieur du terrain
        Vector3 elephantPosition = transform.position;
        Vector3 closestPointOnTerrain = terrainCollider.ClosestPoint(elephantPosition);
        transform.position = new Vector3(closestPointOnTerrain.x, elephantPosition.y, closestPointOnTerrain.z);
    }
}
