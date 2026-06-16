using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuel : MonoBehaviour
{
    public gasoline gas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gas.AddFuel();
            Destroy(gameObject);
        }
    }
}
