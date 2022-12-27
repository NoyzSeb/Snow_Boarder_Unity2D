using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartTrigger : MonoBehaviour
{  
    [SerializeField] AudioClip CrushSFX;
    [SerializeField] ParticleSystem CrushParticle;
    bool restarted = true;
    private void OnTriggerEnter2D(Collider2D other) {
       if (other.tag =="Respawn" & restarted==true)
       {  
          restarted = false;
          //CrushSFX.Play();(1) //İf CrushSFX created as "AudioSource" and plugged to "AudioSource", this method can be used like the following method.
          GetComponent<AudioSource>().PlayOneShot(CrushSFX);// Differents from ".Play()" is developer can controll the SFX volume by AudioSource component volume.
          CrushParticle.Play();
          Invoke("ReloadScene",0.5f);
       }
          
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        restarted=true;
    }
}
