using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonHit : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<Player>().TakeDamage(20);
        }
    }
}
