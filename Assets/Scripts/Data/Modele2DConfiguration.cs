using UnityEngine;

[CreateAssetMenu(fileName = "Modele2DConfiguration", menuName = "Scriptable Objects/Modele2DConfiguration")]

public class Modele2DConfiguration : ScriptableObject
{
    [SerializeField] private Vector3 _size;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _prefab;
    
    public GameObject Prefab => _prefab;
    public Vector3 Size => _size;
    public float Speed => _speed;

}
