using System;
using UnityEngine;

public class EnnemyController : MonoBehaviour
{
    [SerializeField] private int life = 5;

    private UIController ui;

    private void Start()
    {
        ui = UIController.instance;
        ui.IterateMuskratCount(1);
    }

    private void OnDestroy()
    {
        ui.IterateMuskratCount(-1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ow!!!!");

        life -= 1;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
