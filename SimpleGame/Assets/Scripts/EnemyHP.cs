using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    private int enemyHP = 100;

    public DropFromEnemy dropFromEnemy;

    public int _enemyHP;

    void Start()
    {
        _enemyHP = enemyHP;
    }

    void Update()
    {
        if (enemyHP < 0)
        {
            _enemyHP = 0;
        }
        enemyHP = _enemyHP;
        Death();
    }

    void Death()
    {
        if (enemyHP == 0)
        {
            dropFromEnemy.Drop();
            Destroy(gameObject);
        }
    }
}
