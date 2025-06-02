using UnityEngine;

public class NoteScript : MonoBehaviour
{
    [SerializeField]
    float noteSpeed = 2f;

    Vector2 direction = Vector2.left;

    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        body.AddForce(direction * noteSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
