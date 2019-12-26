using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpSpeed;
    public float moveSpeed;
    public float gravity;
    private bool canmove = true;

    public ParticleSystem explosion;

    public GameObject retryMenu;
    public GameObject winMenu;


    public moving mov;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;


        retryMenu.SetActive(false);
        winMenu.SetActive(false);

        gameplayCotroller.canPlayAudio = true;
        canmove = true;
        moving.canMove = true;
        StartCoroutine(startGame());

    }

    void Update()
    {
        if (canmove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * jumpSpeed;
                explosion.Play();
            }

        }

    }
    private void OnCollisionEnter2D(Collision2D tar)
    {
        if(tar.gameObject.tag == "gameOver")
        {
            canmove = false;
            moving.canMove = false;
            gameplayCotroller.canPlayAudio = false;
            retryMenu.SetActive(true);


        }

    }

    
   
    IEnumerator startGame()
    {
        canmove = false;
        yield return new WaitForSeconds(0.5f);
        rb.gravityScale = gravity;
        canmove = true;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Finish")
        {

            canmove = false;
            moving.canMove = false;
            retryMenu.SetActive(false);
            winMenu.SetActive(true);

        }
    }
}
