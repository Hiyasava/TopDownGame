using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform bullet;
    [SerializeField] private Transform point;

    public Ammo ammo;

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammo.CurAmmo > 0)
        {
            Instantiate(bullet, point.position, Quaternion.identity);
        }
    }

    void Update()
    {
        Shoot();
    }
}
