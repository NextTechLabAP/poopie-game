using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    public float speed;
    public static bool canMove = true;
    public static bool winCond = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
