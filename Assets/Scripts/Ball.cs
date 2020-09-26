using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    Vector2 paddleToBall;
    bool isStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBall = transform.position - paddle.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted) {
            lockBallToPaddle();
            launchOnMouseClick();
        }
    }

    private void launchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0)) {
            isStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void lockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePosition + paddleToBall;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isStarted) {
            GetComponent<AudioSource>().Play();
        }
    }
}
