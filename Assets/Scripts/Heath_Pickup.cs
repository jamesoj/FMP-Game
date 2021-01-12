using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath_Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<Player>().Heal();
            Destroy(this.gameObject);
        }
    }
}
