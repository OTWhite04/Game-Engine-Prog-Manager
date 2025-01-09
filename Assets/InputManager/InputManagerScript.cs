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

    #region Public Actions
    
    private Action JumpEvent;

    #endregion

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Test");
        if(context.performed)
        {
            Debug.Log("Jump Button was pressed!");
            JumpEvent?.Invoke();
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
