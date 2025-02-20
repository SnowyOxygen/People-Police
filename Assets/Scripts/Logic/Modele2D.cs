using UnityEngine;

public class Modele2D : MonoBehaviour
{
    [SerializeField] private Modele2DConfiguration _configuration;
    public Vector2 _direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(_configuration.Prefab, this.transform);

    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += new Vector3(_direction.x, _direction.y, 0) * (Time.deltaTime * _configuration.Speed);
        // transform.localScale += Vector3.one * (Time.deltaTime * _configuration.Speed);
        if (Input.GetKeyDown(KeyCode.Z)) {
            _onMove(Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            _onMove(Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            _onMove(Vector2.right);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            _onMove(Vector2.left);
        }
    }
    public void _onMove(Vector2 input)
    {
        _direction = input;
    }
}
