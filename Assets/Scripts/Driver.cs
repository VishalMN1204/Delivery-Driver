using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // in unity editor click on the image assets change the pixel per unity units (small squares in the scenes 1small square per unity unit)
    // less the pixel larger will be the image and vice versa

    [SerializeField]
    private float steerSpeed = 0.1f;

    [SerializeField]
    private float moveSpeed = 20f;

    [SerializeField]
    private float slowSpeed = 15f;

    [SerializeField]
    private float boostSpeed = 30f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxisRaw("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
}
