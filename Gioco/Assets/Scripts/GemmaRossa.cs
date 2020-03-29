﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemmaRossa : Gemma
{
    public int healAmount = 10;

    protected override void OnPicked(Collider other)
    {
        base.OnPicked(other);
        HealthManager healthManager = other.GetComponent<HealthManager>();
        if (!healthManager) { return; }

        healthManager.Heal(healAmount);
        Destroy(gameObject);
    }
}
