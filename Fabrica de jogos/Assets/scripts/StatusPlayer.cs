using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPlayer : MonoBehaviour
{
    [SerializeField] private int maxLife;
    [SerializeField] private int life;

    [SerializeField] private int coins;
    // Start is called before the first frame update
    void Start()
    {
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int MaxLifeValue
    {
        get { return maxLife;}
        set { maxLife = value;}
    }

    public int LifeValue 
    {
        get {return life;}
        set { life = value;}
    }
    
    public int CoinsValue
    {
        get { return coins; }
        set { coins = value; }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Enemy"))
        {
            life -= 1;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coins"))
        {
            coins += 1;
            Destroy(collision.gameObject);
        }
    }
}


















