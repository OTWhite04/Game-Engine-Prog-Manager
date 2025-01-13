using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableandDisableScript : MonoBehaviour
{
    public Light light;
    //Method for enabling light.
    public void LightTurnOn()
    {
        //Enables the light.
        light.enabled = true;
        Invoke("LightTurnOff", 0.5f);
    }
    
    //Method for turning the light off.
    public void LightTurnOff()
    {
        light.enabled = false;
    }

    //Subscribing and Unsubscribing to the actions.
    public void OnEnable()
    {
        Actions.Spotlight += LightTurnOn;
    }

    public void OnDisable()
    {
        Actions.Spotlight -= LightTurnOn;
    }
}
