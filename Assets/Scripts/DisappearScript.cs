using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{
    public GameObject Disappear;
   

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Actions.Disappear?.Invoke();
        }
    }
}
