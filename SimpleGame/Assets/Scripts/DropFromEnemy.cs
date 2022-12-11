using UnityEngine;

public class DropFromEnemy : MonoBehaviour
{
    [SerializeField] private EnemyHP EnemyHP;
    [SerializeField] private Transform EnemyObject;
    [SerializeField] private GameObject[] RandDrop;

    private int Drops;

    public void Drop()
    {
        if (EnemyHP._enemyHP <= 0)
        {
            RandomDrop();

            Instantiate(RandDrop[Drops],EnemyObject.position, Quaternion.identity);
        }
    }

    void RandomDrop()
    {
        Drops = Random.Range(0, RandDrop.Length);
    }
}
