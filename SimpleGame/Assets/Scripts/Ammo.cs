using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private int MagCapacity = 7;
    [SerializeField] public int CurAmmo = 7;
    [SerializeField] public int AmmoAmount = 42;


    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            --CurAmmo;
        }
    }

    void ZeroBullets()
    {
        if(CurAmmo <= 0)
        {
            CurAmmo = 0;
        }

        if(AmmoAmount < 0)
        {
            AmmoAmount = 0; 
        }
    }

    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R) && AmmoAmount > 0)
        {
            AmmoAmount = AmmoAmount - (MagCapacity - CurAmmo);
            CurAmmo += MagCapacity - CurAmmo;
        }
    }

    void Update()
    {
        Shoot();
        Reload();
        ZeroBullets();
    }
}
