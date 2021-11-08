using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseWall : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentHealth -= 10;
        }
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
