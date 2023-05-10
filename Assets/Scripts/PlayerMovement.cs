using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d = new Rigidbody2D();
    float x = 0f;
    float y = 0f;
    float moveSpeed = 80f;

    Vector2 maxVerticalMoveSpeed = new Vector2(0, 1);
    Vector2 minVerticalMoveSpeed = new Vector2(0, -1);

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxisRaw("Horizontal");

        if(((y == 1) && (rb2d.velocity.y < 0)) || ((y == -1) && (rb2d.velocity.y > 0)))
        {
            rb2d.velocity = Vector2.zero;
        }

        rb2d.AddForce(new Vector2(x, y * moveSpeed * Time.deltaTime), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
    }
}
