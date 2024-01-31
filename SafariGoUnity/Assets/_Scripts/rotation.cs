using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Vitesse de rotation de la tête du lion.

    // Mettez à jour est appelée une fois par frame.
    void Update()
    {
        // Obtenez l'entrée utilisateur pour la rotation (ici, nous utilisons les touches horizontales).
        float rotationInput = Input.GetAxis("Horizontal");

        // Calculez la rotation en fonction de l'entrée utilisateur et de la vitesse de rotation.
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        // Appliquez la rotation à la tête du lion uniquement sur l'axe Y (vertical).
        transform.Rotate(Vector3.up, rotationAmount);
    }
}
