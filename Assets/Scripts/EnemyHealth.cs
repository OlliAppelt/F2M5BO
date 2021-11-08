using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objective")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "DefenseWall")
        {
            Destroy(gameObject);
        }
    }
}