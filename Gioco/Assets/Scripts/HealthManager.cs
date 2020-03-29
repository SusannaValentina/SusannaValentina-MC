﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;    
    }

    public void Heal(int amount)
    {
        Damage(-amount);
    }

    public void Damage(int damageTaken)
    {
        health -= damageTaken;
        if(health < 1)
        {
            Debug.LogError("YOU DEAD");
        }
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        Debug.Log("Adesso hai: " + health + "punti vita");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
