using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Range(1, 100)] private float _speed;

    private Rigidbody2D _rb;

    private Vector2 movement = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(movement != Vector2.zero)
        {
            Move();
        }
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
}
