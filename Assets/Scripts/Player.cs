using UnityEngine;

namespace TopEngineTeam
{
    /*
    Движение игрока
    */
    public class Player : MonoBehaviour
    {
        public static Player currentPlayer;

        public float _speedmove = 8f;
        [SerializeField] private float _forceJump = 8f;
        public bool _onGround = false;
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
            AlwaysMoveForward();
            if (IsFalling())
                GameManager.instance.GameOver();
            FixIfOutOfBounds();
        }
        private bool IsFalling()
        {
            return (transform.position.y < -3);
        }

        public void MoveLeftOrRight(float direction)
        {
            transform.Translate(_speedmove * Time.deltaTime * direction * Vector3.right);
        }

        public void AlwaysMoveForward()
        {
            transform.Translate(_speedmove * Time.deltaTime * Vector3.forward);
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
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7, 7), transform.position.y, transform.position.z);
        }

        public void Jump()
        {
            if (_onGround)
                _rb.AddForce(Vector3.up * _forceJump, ForceMode.VelocityChange);
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

        public void MoveForward() => transform.Translate(_speedmove * Time.deltaTime * Vector3.forward);
    }
}