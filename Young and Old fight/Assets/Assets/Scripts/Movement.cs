using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 6f;
    [SerializeField] float jumpForce = 12f;
    [SerializeField] Animator anim;        // sleep je Animator hier in
    [SerializeField] SpriteRenderer sr;    // sleep je SpriteRenderer hier in

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Links/rechts met A/D of pijltjes
        float x = Input.GetAxisRaw("Horizontal");

        // Beweeg alleen X; Y wordt door gravity gedaan
        rb.velocity = new Vector2(x * speed, rb.velocity.y);

        // W = springen (alleen als je praktisch op de grond staat)
        bool grounded = Mathf.Abs(rb.velocity.y) < 0.05f;
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            if (anim) anim.SetTrigger("JumpTrigger");
        }

        // Flip sprite naar de looprichting
        if (sr && x != 0) sr.flipX = x < 0f;

        // Animator parameters updaten
        if (anim)
        {
            anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
            anim.SetBool("Grounded", grounded);
            anim.SetFloat("FacingX", x); // handig als je met states/blend wil werken
        }
    }
}