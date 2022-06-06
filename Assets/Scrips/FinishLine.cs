using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeDelay = 1f;
    [SerializeField] ParticleSystem particleEffect;
   private void OnTriggerEnter2D(Collider2D other) {
    
       if(other.tag == "Player"){
           particleEffect.Play();
           GetComponent<AudioSource>().Play();
           Invoke("LoadScene", timeDelay);
       }
   }

   public void LoadScene(){

        SceneManager.LoadScene(0);      
   }
}
