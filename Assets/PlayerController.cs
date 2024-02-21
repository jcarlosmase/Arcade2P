using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private Vector2 movementInput;

    private void Update()
    {
        transform.Translate(new Vector3(movementInput.x, 0, movementInput.y) * speed * Time.deltaTime);
    }

    //public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();
    public void OnMove(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        //Debug.Log(ctx.control.ToString());
    } 
    public void boton1_1(InputAction.CallbackContext ctx)
    {
        if(ctx.control.ToString().Contains("Joystick  1"))
        {
            Debug.Log("Has pulsado el boton 1 del 1P");
        }
    }
    public void boton2_1(InputAction.CallbackContext ctx)
    {
        if (!ctx.control.ToString().Contains("Joystick  1"))
        {
            Debug.Log("Has pulsado el boton 1 del 2P");
        }
    }
}
