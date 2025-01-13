using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audiosource;
    
    //Enable and Disable methods for subscribing and unsubscribing to the event.
    public void OnEnable()
    {
        Actions.Spotlight += PlaySound;
    }

    public void OnDisable()
    {
        Actions.Spotlight -= PlaySound;
    }


    //Method for playing the sound.
    void PlaySound()
    {
        audiosource.Play();
    }



}
