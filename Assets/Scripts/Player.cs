using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player currentPlayer;

    [SerializeField] private float _speedmove = 8f;
    [SerializeField] private float _forceJamp = 8f;
    private bool _onGround = false;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        currentPlayer = this;
    }

    void Update()
    {
        PlayerControl();
        if (IsFalling())
            GameManager.instance.GameOver();
        FixIfOutOfBounds();
    }
    private bool IsFalling()
    {
        return (transform.position.y < -3);
    }
    protected virtual void PlayerControl()
    {
        transform.Translate(_speedmove * Time.deltaTime * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speedmove * Time.deltaTime * Vector3.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speedmove * Time.deltaTime * Vector3.left);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        _onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _onGround = false;
    }

    private void FixIfOutOfBounds()
    {
        if (transform.position.x > 7f)
            transform.position = new Vector3(7f, transform.position.y, transform.position.z);
        if (transform.position.x < -7f)
            transform.position = new Vector3(-7f, transform.position.y, transform.position.z);
    }

    private void Jump()
    {
        _rb.AddForce(Vector3.up * _forceJamp, ForceMode.VelocityChange);
    }

    public void ThrowUp(float force)
    {
        _rb.AddForce(Vector3.up * force, ForceMode.VelocityChange);
    }

    public void ThrowBack(float force)
    {
        _rb.AddForce(Vector3.back * force, ForceMode.VelocityChange);
    }
    public void IncreasePlayerSpeed(float seconds)
    {
        _speedmove += seconds;
    }
}