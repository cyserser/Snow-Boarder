using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float timeDelay = 0.2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool playEffect = true;
    

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Ground"){
            if(playEffect){
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
            }

            playEffect = false;
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("LoadScene", timeDelay);
        }
    }

    private void LoadScene(){

        SceneManager.LoadScene(0);
    }
}
