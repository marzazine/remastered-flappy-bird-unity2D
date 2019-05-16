using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;
    public bool isDead = false;

    private Rigidbody2D rb2d;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
    	// Initialisation des variables de RigidBody2D et des anim
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {	
    	// On vérifie toujours si le personnage n'est pas mort
        if (isDead) { return; }

        // Au click gauche de la souris, sauter et actionner l'animation "Flap"
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
            anim.SetTrigger("Flap");
        }
    }

    void OnCollisionEnter2D()
    {	
    	// Si une collision est détectée alors on est mort et on recommence le jeu
        isDead = true;
        rb2d.velocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameController.Instance.Die();
    }
}
