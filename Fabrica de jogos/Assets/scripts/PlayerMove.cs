using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector2 move;
    public float speed;

    private float inputx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputLogic();
    }

    private void FixedUpdate()
    {
        Movelogic();
    }

    public void InputLogic()
    {
        inputx = Input.GetAxisRaw("Horizontal");
    }

    public void Movelogic()
    {
        move = new Vector2(inputx * speed, rb.velocity.y);
        rb.velocity = move;
    }








}
