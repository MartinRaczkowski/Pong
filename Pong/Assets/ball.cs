using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedY;

    public int score1 = 0;
    public int score2 = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bar p2")
            moveSpeedX = moveSpeedX * (-1);
        if (collision.gameObject.name == "bar p1")
            moveSpeedX = moveSpeedX * (-1);
        if (collision.gameObject.name == "border top")
            moveSpeedY = moveSpeedY * (-1);
        if (collision.gameObject.name == "border bottom")
            moveSpeedY = moveSpeedY * (-1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeedX, transform.position.y + moveSpeedY);

        if (transform.position.x > 10)
        {
            transform.position = new Vector2(0,0);
            score1++;
            Debug.Log("score is " + score1 + ":" + score2);
        }
        if (transform.position.x < -10)
        {
            transform.position = new Vector2(0, 0);
            score2++;
            Debug.Log("score is " + score1 + ":" + score2);
        }
    }

    void FixedUpdate()
    {

    }

    
}
