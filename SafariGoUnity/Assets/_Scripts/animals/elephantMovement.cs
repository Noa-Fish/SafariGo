using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephantMovement : MonoBehaviour
{
    public float vitesse = 10f;
    public float rayonDetection = 1f; // Distance à laquelle l'éléphant détecte le bord du terrain
    private Animator animator;
    private Collider terrainCollider;

    void Start()
    {
        animator = GetComponent<Animator>();
        terrainCollider = GameObject.FindGameObjectWithTag("Terrain").GetComponent<Collider>();
    }

    void Update()
    {
        // Déplacement de l'éléphant
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);

      
            // Tourner l'éléphant dans la direction opposée
        transform.Rotate(Vector3.up, 180f);
       
        if (Mathf.Abs(vitesse) > 0)
        {
            // animator.SetBool("Avancer", true);
        }
        else
        {
            // animator.SetBool("Avancer", false);
        }
    }

}
