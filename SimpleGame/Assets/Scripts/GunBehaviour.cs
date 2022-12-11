using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private string name;
    [SerializeField] private string descryption;

    [SerializeField] private int _damage;

    public TakeDamage tD;

    void Update()
    {
        tD.Damage = _damage;
    }
}
