using UnityEngine;

public class failCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerExit2D(Collider2D strange)
    {
        Destroy(strange.gameObject);
    }
}