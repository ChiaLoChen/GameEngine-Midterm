using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void onCollisionEnter2D(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
