using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _horizontalDirection;
    [SerializeField] private Rigidbody2D _RB2D;
    [SerializeField] public float speed;
    [SerializeField] public float fallspeed;

    void Start()
    {
        _RB2D = GetComponent<Rigidbody2D>();
        _RB2D.gravityScale = 0;
    }

    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        transform.position = new Vector2(transform.position.x + _horizontalDirection * speed * Time.deltaTime, transform.position.y);
        _RB2D.linearVelocityX = _horizontalDirection * speed;
    }
    private void FixedUpdate()
    {
        _RB2D.linearVelocity = new Vector3(_RB2D.linearVelocityX, - fallspeed);
    }

}
