using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishTrigger : MonoBehaviour
{
    [SerializeField] ParticleSystem FinishParticle;
    private void OnTriggerEnter2D(Collider2D other) {
        
        GetComponent<AudioSource>().Play();
        FinishParticle.Play();
        Invoke("ReloadScene", 1f);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
