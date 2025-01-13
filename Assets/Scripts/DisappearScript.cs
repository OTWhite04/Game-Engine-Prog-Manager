using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{
    public Light Spotlight;
   

    void Update()
    {
        //Key Code for the F key.
        if(Input.GetKeyDown(KeyCode.F))
        {
            //Signal that other scripts pick up.
            Actions.Spotlight?.Invoke();
        }
    }
}
