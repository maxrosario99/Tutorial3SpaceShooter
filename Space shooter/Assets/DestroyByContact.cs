using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    public AudioClip Asteroid;

    public AudioSource musicSource;


    void OnTriggerEnter(Collider other) {
        if (other.tag == "boundary")
        {
            return;
        }
    Instantiate(explosion, transform.position, transform.rotation);
          if (other.tag == "player") {
              Instantiate(playerExplosion, transform.position, transform.rotation);}
        Destroy(other.gameObject);
        Destroy(gameObject); 
         musicSource.clip = Asteroid;
              musicSource.Play();
    }
}
