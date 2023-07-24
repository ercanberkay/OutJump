using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameManager gameManager;
    [SerializeField] float _moveSpeed;
    [SerializeField] float _jumpPower;
    void Start()
    {
        
    }

    
    void Update()
    {
        Mover();
        Jump();
    }

    void Mover()
    {
        transform.Translate(_moveSpeed * Time.deltaTime, 0f, 0f);
    }

    void Jump()
    {
        if (Input.GetMouseButtonDown(0) && rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * _jumpPower;
            gameManager._isStart = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Short Tag"))
        {
            _moveSpeed *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            gameManager._starCount++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Flag"))
        {
            Time.timeScale = 0;
            Debug.Log("You Win!!!");
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            gameManager.GameOver();
        }
    }
}
