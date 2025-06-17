using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class DefenseColiider : MonoBehaviour
{
    public Enemy enemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
 
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            enemy.dealAttack(-(enemy.Forca / 2));
            Destroy(collision.gameObject);
            enemy.dealAttack((enemy.Forca));
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        enemy.dealAttack(-enemy.Forca);
        Destroy(collision.gameObject);
    }
    


}
