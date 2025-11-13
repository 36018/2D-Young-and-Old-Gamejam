using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumppower = 5f;
    [SerializeField] private GameObject Projectileprefab;
    [SerializeField] private bool Floored;
    private SpriteRenderer spriteRenderer;
    Animator m_Animator;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            Floored = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            Floored = false;
        }
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            GameObject bullet = Instantiate(Projectileprefab);
            bullet.transform.position = transform.position;
            bullet.GetComponent<OldmanProjectile>().velocity = spriteRenderer.flipX ? -30 : 30;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right * Time.deltaTime * speed;
            m_Animator.Play("walkies");
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = true;
            }

        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            m_Animator.Play("walkies");
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Floored == true)
        {
            transform.position += transform.up * Time.deltaTime * jumppower;
            m_Animator.Play("jump");
        } else
        {
            m_Animator.Play("idle");
        }


    }
}
