using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephantMovement : MonoBehaviour

{
    public float vitesse = 5f; // Vitesse de déplacement de l'éléphant

    private Animator animator;

    void Start()
    {
        // Récupérer le composant Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Déplacer l'éléphant en avant
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);

        // Activer l'animation d'avancement
        animator.SetBool("Avancer", true);
    }
}
