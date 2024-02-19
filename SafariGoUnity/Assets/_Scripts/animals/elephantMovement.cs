using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephantMovement : MonoBehaviour
{
    public float vitesse = 10f;
    public float vitesseRotation = 100f; // Vitesse de rotation en degrés par seconde
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");

        // Déplacement de l'éléphant
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);

        // Rotation de l'éléphant vers la gauche ou la droite
        transform.Rotate(Vector3.up * deplacementHorizontal * vitesseRotation * Time.deltaTime);

        // Activer l'animation d'avancement si l'éléphant bouge
        if (Mathf.Abs(deplacementHorizontal) > 0 || Mathf.Abs(vitesse) > 0)
        {
            animator.SetBool("Avancer", true);
        }
        else
        {
            animator.SetBool("Avancer", false);
        }
    }
}
