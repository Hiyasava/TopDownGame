using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int Damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent <EnemyHP>()._enemyHP -= Damage;
            Destroy(gameObject);
        }
    }
}
