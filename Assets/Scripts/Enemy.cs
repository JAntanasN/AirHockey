using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform pin;
    public Transform defencePoint;
    public float speed = 50;
    public float defenceSpeed = 15;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

   
    void Update()
    {
        Vector2 targetPos;
        if(pin.position.x < 0)
        {
            targetPos = Vector2.MoveTowards(transform.position, pin.position, speed * Time.deltaTime);
        }
        else
        {
            targetPos = Vector2.MoveTowards(transform.position, defencePoint.position, defenceSpeed * Time.deltaTime);
        }
        rb.MovePosition(targetPos);
    }
}
