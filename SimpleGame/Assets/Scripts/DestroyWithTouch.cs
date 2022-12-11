using UnityEngine;

public class DestroyWithTouch : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Gun")
        {
            Destroy(gameObject);
        }
    }
}
