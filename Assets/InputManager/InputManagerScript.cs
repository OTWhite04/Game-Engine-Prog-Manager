using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerScript : MonoBehaviour, InputController.IGameplayActions
{
    public InputController gameInput;
    public GameObject light;
    public AudioSource audiosource;
   
    void Start()
    {
        
        gameInput = new InputController();
        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);

    }

    #region Public Actions
    
    private Action JumpEvent;
    private Action SoundCubeEvent;
    private Action LightEvent;

    #endregion
    //Mehtod for the jump with the spacebar.
    public void OnJump(InputAction.CallbackContext context)
    {
        
        if(context.performed)
        {
            Debug.Log("Jump Button was pressed!");
            JumpEvent?.Invoke();
        }
        else if(context.started)
        {
            Debug.Log("The Jump has started!");
            JumpEvent?.Invoke();
        }
        else if(context.canceled)
        {
            Debug.Log("Canceled Jump!");
            JumpEvent?.Invoke();
        }
    
    }
    //Method that plays a beep sound on the cube.
    public void OnSoundCube(InputAction.CallbackContext context)
    {
        

        if(context.started)
        {
            
            Debug.Log("Sound has Started!");
            SoundCubeEvent?.Invoke();
        }

        if(context.performed)
        {
            Debug.Log("Cube starts and plays a noise!");
            SoundCubeEvent?.Invoke();
        }
    
    
    
    
    }
    //Method for the light event, writes to the console that it turns off and remains turned off.
    public void OnLight(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Debug.Log("Light has turned off!");
            LightEvent?.Invoke();
        }
        else if(context.performed)
        {
            Debug.Log("Light remains turned off!");
            LightEvent.Invoke();
        }
    }
    
    
    
    
    
    
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        gameInput.Gameplay.Enable();
    }


}
