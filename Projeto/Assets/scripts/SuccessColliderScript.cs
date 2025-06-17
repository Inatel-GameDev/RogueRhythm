using Mono.Cecil;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SuccessColliderScript : MonoBehaviour
{

    Collider2D body;

    public InputActionReference attack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        attack.action.started += Attack;
    }

    private void OnDisable()
    {
        attack.action.started -= Attack;
    }

    private void Attack(InputAction.CallbackContext context)
    {
        body.enabled = true;
        Debug.Log("Attacked Successfully");
    }

    void OnTriggerStay2D(Collider2D strange)
    {
        Debug.Log("GameObject2 collided with " + strange.name);
        body.enabled = false;
    }
}
