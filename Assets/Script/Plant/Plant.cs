using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum PlantState { SearchTarget, AttackTarget,}

public class Plant : MonoBehaviour
{

    
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    private Animator animator;


    private int hp;
    private int maxHP;
    private float range;
    private int damage;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }







}
