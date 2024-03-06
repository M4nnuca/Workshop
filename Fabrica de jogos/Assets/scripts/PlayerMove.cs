using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector2 move;
    public float speed;

    private float inputx;
    private bool inputJump;

    [SerializeField] private Transform checkGround;
    [SerializeField] private LayerMask layerMask;

   
    [SerializeField] private float forceJump;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputLogic();
        JumpLogic();
    }

    private void FixedUpdate()
    {
        Movelogic();
    }

    public Vector2 MoveValue 
    {
        get { return move; }
        set { move = value;}
    }
    
    public bool InGround()
    {
        return Physics2D.OverlapCircle(checkGround.position, 0.3f, LayerMask.GetMask("Ground"));
    }
    public void InputLogic()
    {
        inputx = Input.GetAxisRaw("Horizontal");
        inputJump = Input.GetKeyDown(KeyCode.Space);
    }

    public void Movelogic()
    {
        move = new Vector2(inputx * speed, rb.velocity.y);
        rb.velocity = move;
    }

    public void JumpLogic()
    {
        if (inputJump == true && InGround() == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, forceJump);
        }
    }
}







