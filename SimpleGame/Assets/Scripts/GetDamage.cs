using UnityEngine;

public class GetDamage : MonoBehaviour
{
    [SerializeField] PlayerHP plHP;

    int damage = 1;

    void getDamage()
    {
        plHP._playerHP = plHP._playerHP - damage;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            getDamage();
        }
    }
}
