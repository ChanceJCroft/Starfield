using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour

{

    [SerializeField] int damage = 100;
    [SerializeField] GameObject explosion;
    [SerializeField] float explosionTime;
    [SerializeField] AudioClip soundFX;
    [SerializeField] float volume = 1;
    
    int delay = 2;


    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
        GameObject explosionParticles = Instantiate
                   (explosion,
                   transform.position,
                   Quaternion.identity) as GameObject;
        GameObject.Destroy(gameObject, 2.0f);
        AudioSource.PlayClipAtPoint(soundFX, transform.position, volume);

    }

}
