using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
    List<GameObject> gameObjects = new List<GameObject>();

    public float fireRate =  1f;
    private float fireCountdown = 0f;

    public GameObject bulletPrefab;
    public Transform bulletOrigin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObjects.Add(other.gameObject);
        }
    }
    void Update()
    {
        if (gameObjects.Count > 0)
        {
            if (gameObjects[0] == null)
            {
                gameObjects.RemoveAt(0);
                return;
            }
                
            if (gameObjects[0] != null)
                transform.LookAt(gameObjects[0].transform, Vector3.up);
            
            if (fireCountdown <= 0)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
            fireCountdown -= Time.deltaTime;
        }
        //fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObjects.Remove(other.gameObject);
            Debug.Log("Removed!");
        }
    }
}
