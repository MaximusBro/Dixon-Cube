using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour

{
    public Rigidbody2D rb;
    public float BoxSize;
    public LayerMask whatisGround;
    public bool canMove;

    public float speed;
    public float minX, maxX;
    public float colider;

    public Vector2 targetPose;
    public Vector2 size;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        canMove = Physics2D.OverlapBox(transform.position, size, BoxSize, whatisGround);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX && canMove)
        {
            targetPose = new Vector2(minX, transform.position.y);
            
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX && canMove)
        {
            targetPose = new Vector2(maxX, transform.position.y);
            
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPose, speed * Time.deltaTime);
    }
        
    
}

