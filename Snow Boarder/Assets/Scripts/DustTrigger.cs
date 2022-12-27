using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrigger : MonoBehaviour
{

    [SerializeField] ParticleSystem dust;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Respawn"){
            dust.Play();
            Debug.Log("kayak zemine değiyor.");
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Respawn"){
            dust.Stop();
            Debug.Log("kayak zemine değmiyor.");
        }
    }
}
