using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JEEP : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    public GameObject frontRightWheel;
    public GameObject frontLeftWheel;
    public GameObject rearRightWheel;
    public GameObject rearLeftWheel;

    // Update is called once per frame
    void Update()
    {
        MoveAndRotateCar();
    }

    void MoveAndRotateCar()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;


        // Déplacement avant/arrière
        float forwardMovement = verticalInput * speed * Time.deltaTime;
        transform.Translate(Vector3.left * forwardMovement);

        // Rotation des roues droites autour de leur axe local Z
        Quaternion frontRightRotation = frontRightWheel.transform.localRotation * Quaternion.Euler(0, 0, -verticalInput);
        frontRightWheel.transform.localRotation = frontRightRotation;

        Quaternion rearRightRotation = rearRightWheel.transform.localRotation * Quaternion.Euler(0, 0, -verticalInput);
        rearRightWheel.transform.localRotation = rearRightRotation;

        // Rotation des roues gauches autour de leur axe local Z avec le sens inverse
        Quaternion frontLeftRotation = frontLeftWheel.transform.localRotation * Quaternion.Euler(0, 0, verticalInput);
        frontLeftWheel.transform.localRotation = frontLeftRotation;

        Quaternion rearLeftRotation = rearLeftWheel.transform.localRotation * Quaternion.Euler(0, 0, verticalInput);
        rearLeftWheel.transform.localRotation = rearLeftRotation;

        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            // Rotation des roues avant autour de leur axe local Y
            float targetRotation = 45f * Mathf.Sign(horizontalInput);
            frontRightWheel.transform.localRotation = Quaternion.Euler(0, targetRotation, 0);
            frontLeftWheel.transform.localRotation = Quaternion.Euler(0, targetRotation, 0);

            // Pivote la voiture dans la direction des roues
            transform.Rotate(Vector3.up * rotation);
        }
        else
        {
            // Remettre les roues droites si la touche horizontale n'est pas enfoncée
            frontRightWheel.transform.localRotation = Quaternion.Euler(0, 0, 0);
            frontLeftWheel.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        // Si les roues sont tournées, faire pivoter la Jeep et avancer
        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            // Calculer la direction de déplacement en fonction de la rotation des roues
            Vector3 movementDirection = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * Vector3.forward;
            transform.Translate(movementDirection * forwardMovement, Space.World);
        }
        else
        {
            // Avancer normalement si les roues sont droites
            transform.Translate(Vector3.left * forwardMovement);
        }

    }
}
