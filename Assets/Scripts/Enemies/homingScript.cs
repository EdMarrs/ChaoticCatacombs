using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 5f;
    public float rotateSpeed = 200f;
    private Rigidbody2D rb;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.up * speed;
        
    }
    
}
