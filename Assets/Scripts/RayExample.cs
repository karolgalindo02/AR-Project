using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class RayExample : MonoBehaviour
{
    RaycastHit hit;
    public PlayerInput controls;
    private void Start()
    {
        controls = GetComponent<PlayerInput>();
    }
    void Update()
    {
        if(controls.actions["Fire"].triggered && RayOut())
        {
            Debug.Log(hit.collider.name);
        }

    }
    /// <summary>
    /// This return a bool to check if ray collided with an object (object needs a collider)
    /// </summary>
    public bool RayOut()
    {
        LayerMask mask = LayerMask.GetMask("Objects");
        return Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out hit, Mathf.Infinity, mask);
    }
}

