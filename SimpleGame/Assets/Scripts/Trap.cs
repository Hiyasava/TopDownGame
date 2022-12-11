using UnityEngine;

public class Trap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Trap")
        {
            Destroy(gameObject);
        }
    }
}
