using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ball = new Rigidbody2D();
    GameObject playerObject;

    float startingPositionOffset = 0f;
    bool launchBallFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        playerObject = GameObject.FindGameObjectWithTag("Player");

        startingPositionOffset = ball.transform.localScale.x / 2;

        Debug.Log($"{playerObject.transform.position}");
    }

    // Update is called once per frame
    void Update()
    {
        if(!launchBallFlag)
        {
            ball.position = new Vector2(playerObject.transform.position.x + startingPositionOffset, playerObject.transform.position.y);
        }

        if(Input.GetButtonDown("Jump"))
        {
            launchBallFlag = true;
            ball.velocity = new Vector2(1, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{ball.transform.position}");
    }
}
