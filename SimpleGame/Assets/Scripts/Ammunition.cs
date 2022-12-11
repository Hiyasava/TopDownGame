using UnityEngine;

public class Ammunition : MonoBehaviour
{
    public Ammo ammo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ammunition")
        {
            ammo.AmmoAmount += 15;
            Destroy(other);
        }
    }
}
