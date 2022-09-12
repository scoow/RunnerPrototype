using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedmove = 8f;
    [SerializeField] float forceJamp = 8f;
    [SerializeField] bool onGround = false;
    Rigidbody rb;

    public static Player instance;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        PlayerControl();
    }

    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }

    private bool IsFalling()
    {
        return (transform.position.y < -3);
    }


    void PlayerControl()
    {
        transform.Translate(speedmove * Time.deltaTime * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speedmove * Time.deltaTime * Vector3.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speedmove * Time.deltaTime * Vector3.left);
        }

        if (IsFalling())
            GameManager.instance.GameOver();

        if (transform.position.x > 7f)
            transform.position = new Vector3(7f, transform.position.y, transform.position.z);
        if (transform.position.x < -7f)
            transform.position = new Vector3(-7f, transform.position.y, transform.position.z);
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * forceJamp, ForceMode.VelocityChange);
    }
}