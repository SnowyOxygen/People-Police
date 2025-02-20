using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Range(1, 100)] private float _speed;
    [SerializeField] private Camera _camera;

    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;

    private Vector2 movement = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if(movement != Vector2.zero)
        {
            Move();
        }

        PointAtCursor();
    }

    // Update is called once per frame
    void Update()
    {
        // TEMPORARY INPUT SCRIPT
        float x = Mathf.Round(Input.GetAxisRaw("Horizontal"));
        float y = Mathf.Round(Input.GetAxisRaw("Vertical"));
        movement = new Vector2(x, y);
    }

    private void Move()
    {
        Vector2 direction = movement.normalized;
        Vector2 force = direction * Time.deltaTime * _speed * 100;
        _rb.AddForce(force);
    }

    private void PointAtCursor()
    {
        // Get the mouse position in screen coordinates.
        Vector3 mousePosition = Input.mousePosition;

        // Convert the screen coordinates to world coordinates.
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Ensure the z-coordinate is the same as the sprite's z-coordinate.
        worldMousePosition.z = transform.position.z;

        // Calculate the direction from the sprite to the mouse.
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle in degrees.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the sprite to face the mouse.
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
