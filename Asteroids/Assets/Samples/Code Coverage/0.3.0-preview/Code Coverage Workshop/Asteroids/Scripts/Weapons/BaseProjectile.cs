﻿using UnityEngine;

public class BaseProjectile : MonoBehaviour
{
    public bool destroyOnCollision = true;
    //Line that cannot be covered
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AsteroidController asteroidController = collision.gameObject.GetComponent<AsteroidController>();

        if (asteroidController)
        {
            if (collision.isActiveAndEnabled)
                asteroidController.Split();

            if (destroyOnCollision)
                Destroy(gameObject);
        }
    }
}
