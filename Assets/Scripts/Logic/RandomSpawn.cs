using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private Vector4 _range;
    [SerializeField] private GameObject _prefab;

    private float timer = 0;
    private float delay = 500;


    public void Update()
    {
        timer += 1;

        if (timer > delay)
        {
            InitialiseSpawnPoint();
            timer = 0;
        }
    }

    public void InitialiseSpawnPoint()
    {
        Vector2 point = GetRandomSpawnPoint();
        GameObject SpawnPointInstance = Instantiate(_prefab, point, Quaternion.identity);
        
    }


    public Vector2 GetRandomSpawnPoint()
    {
        return new Vector2(UnityEngine.Random.Range(_range[0], _range[1]), UnityEngine.Random.Range(_range[2], _range[3]));
    }
}