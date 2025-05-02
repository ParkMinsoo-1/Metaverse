using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    private Camera camera;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
    }
    
    //protected override void HandleAction()
    //{
    //    float horizontal = Input.GetAxisRaw("Horizontal");
    //    float vertical = Input.GetAxisRaw("Vertical");
    //    movementDirection = new Vector2(horizontal, vertical).normalized;

    //    Vector2 mousePosition = Input.mousePosition;
    //    Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
    //    lookDirection = (worldPos - (Vector2)transform.position);

    //    if (lookDirection.magnitude < .9f)
    //    {
    //        lookDirection = Vector2.zero;
    //    }
    //    else
    //    {
    //        lookDirection = lookDirection.normalized;
    //    }
    //}

    void OnMove(InputValue inputValue)
    {
        movementDirection = inputValue.Get<Vector2>();
        movementDirection = movementDirection.normalized;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        if (lookDirection.magnitude < 0.9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }
    }

    void OnFire(InputValue inputValue)
    {
        //isAttacking = inputValue.isPressed;
    }

}
