﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpellDamage : MonoBehaviour {

    
    public float damage;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().Hurt(damage);
            Destroy(gameObject);

        }

       

    }
}
