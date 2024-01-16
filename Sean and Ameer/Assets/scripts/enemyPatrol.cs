using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{

    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position; 
        if(currentPoint = pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0); 
        }else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 10f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform; 
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 10f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }
}
