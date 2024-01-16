using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    public float rotationSpeed = 2f; 

    private int currentWaypoint = 0;

    void Update()
    {
        MoveToWaypoint();
    }

    void MoveToWaypoint()
    {
        if (currentWaypoint < waypoints.Length)
        {
            Vector3 targetPosition = waypoints[currentWaypoint].position;
            Vector3 moveDirection = (targetPosition - transform.position).normalized;

            // Rotation vers la direction du waypoint
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Déplacement vers le waypoint
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Si la voiture atteint le waypoint actuel, passez au suivant
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                currentWaypoint++;
            }
        }
    }
}
