using UnityEngine;
using UnityEngine;
using System;
using System.Collections.Generic;

public class AutoDrive : MonoBehaviour
{
    public enum Axel
    {
        Front,
        Rear
    }

    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;
    }
    public List<Wheel> wheels;



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
        /*  if (currentWaypoint < waypoints.Length)
       {
           Vector3 targetPosition = waypoints[currentWaypoint].position;*/

        // Rotation vers la direction du waypoint


        // Appliquer une force pour faire avancer le véhicule
        foreach (var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = 600 * speed;
        }

        // Si la voiture atteint le waypoint actuel, passez au suivant
        /*  if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
          {
              currentWaypoint++;
          }*/
        /* }
         else
         {
             currentWaypoint = 0;
         }*/
    }

}