using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barP1 : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(-9f, movement * 3);

        transform.position = move;
    }
}
