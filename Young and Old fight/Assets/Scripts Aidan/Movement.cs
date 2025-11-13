using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    private float speed = 5f; //temporary
    private Rigidbody2D rb;
    private bool canJump = true;
    public bool inAir = false; // extra bool for other scripts, don't want to expose my grounded check.
    private enum player 
    {
        player1, player2
    }
    [SerializeField] private player chosenplayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chosenplayer == player.player1)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
            }
            if (Input.GetKeyDown(KeyCode.W) && canJump)
            {
               StartCoroutine(jump()); 
            }
        }
        else if (chosenplayer == player.player2)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && canJump)
            {
                StartCoroutine(jump());
            }
        }
    }
    private IEnumerator jump()
    {
        canJump = false;
        inAir = true;
        int i = 0;
        float y = 0f;
        rb.gravityScale = 0;
        while (i < 90)
        {
            transform.position += Vector3.up * Time.deltaTime * (25-y);
            i++;
            y += (0.25f + (i / 90)); //make sure the first number is 1/100th of the speed scale you're using in transform position, for a smoother jump
            yield return new WaitForEndOfFrame();
        }
        rb.gravityScale = 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
            inAir = true;
        }
    }
}
