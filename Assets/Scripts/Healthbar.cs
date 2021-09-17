using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public bool takeDamage; 

    public GameObject healthbarUI;
    public Slider slider;

    private void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if (takeDamage == true)
        {
            health = -5;
        }
        else
        {
            takeDamage = false;
        }
            
        if(health < maxHealth)
        {
            healthbarUI.SetActive(true);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
}
