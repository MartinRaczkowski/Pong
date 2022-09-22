using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical P2");

        Vector2 moveP2 = new Vector2(9f, movement * 3);

        transform.position = moveP2;
    }
}
