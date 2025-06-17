using Mono.Cecil;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections;

public class SuccessColliderScript : MonoBehaviour
{

    public Player player;
    Collider2D body;
    public InputActionReference attack;
    Queue<GameObject> Notes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Collider2D>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        Notes = new Queue<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Notes.Count != 0 && body.enabled == false)
        {
            player.dealAttack();
            Destroy(Notes.Dequeue());
            Notes.Clear();
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        body.enabled = false;
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
        StartCoroutine(delay());
    }

    void OnTriggerEnter2D(Collider2D strange)
    {
        Debug.Log("GameObject2 collided with " + strange.name);
        Notes.Enqueue(strange.gameObject);
        body.enabled = false;
    }
    
}
