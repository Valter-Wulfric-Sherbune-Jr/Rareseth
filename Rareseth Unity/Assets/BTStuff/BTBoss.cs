﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTBoss : MonoBehaviour {
    int health = 500;
    int chargeDamage = 25;
    int missileDamage = 5;
    int meleeDamage = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = transform.position;

        float x, y;

        if(Random.value > 0.5f)
        {
            x = Random.value;
        }else
        {
            x = -Random.value;
        }

        if(Random.value > 0.5f)
        {
            y = Random.value;
        }
        else
        {
            y = -Random.value;
        }

        Vector3 vel = new Vector3(x, y, 0);
        newPos += vel * Time.deltaTime;
        
        if(newPos.x > 10)
        {
            newPos.x = 10;
        }
        if(newPos.x < 0)
        {
            newPos.x = 0;
        }
        if(newPos.y < -5)
        {
            newPos.y = -5;
        }
        if (newPos.y > 5)
        {
            newPos.y = 5;
        }

        transform.position = newPos;
    }

    void attack()
    {
        System.Random rand = new System.Random();
        int num = rand.Next(0,100);
        
        if(num <= 80)
        {
            missile();
        }
        else
        {
            charge();
        }
    }

    void missile()
    {
        //launches a magic missile
    }
    void charge()
    {
        //charges at the player
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //hurts the player with a melee attack, conditions apply
    }
}
