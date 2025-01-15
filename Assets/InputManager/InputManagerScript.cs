using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerScript : MonoBehaviour, InputController.IGameplayActions
{
    public InputController gameInput;
    
   
    void Start()
    {
        
        gameInput = new InputController();
        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);

    }

    //Mehtod for the jump with the spacebar.
    public void OnJump(InputAction.CallbackContext context)
    {
        
        if(context.performed)
        {
            Debug.Log("Jump Button was pressed!");
            InputActions.Jump?.Invoke();
        }
        else if(context.started)
        {
            Debug.Log("The Jump has started!");
            InputActions.Jump?.Invoke();
        }
        else if(context.canceled)
        {
            Debug.Log("Canceled Jump!");
            InputActions.Jump?.Invoke();
        }
    
    }
    
    public void OnCubeColor(InputAction.CallbackContext context)
    {
        

        if(context.started)
        {
            
            Debug.Log("Sound has Started!");
            InputActions.CubeColor?.Invoke();
        }

        if(context.performed)
        {
            Debug.Log("Cube starts and plays a noise!");
            InputActions.CubeColor?.Invoke();
        }
    
    
    
    
    }
    //Method for the light event, writes to the console that it turns off and remains turned off.
    public void OnLight(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Debug.Log("Light has turned off!");
            InputActions.Spotlight?.Invoke();
        }
        else if(context.performed)
        {
            Debug.Log("Light remains turned off!");
            InputActions.Spotlight.Invoke();
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
