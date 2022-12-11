using UnityEngine;
using System.Collections;

public class WeaponSound : MonoBehaviour
{
    public AudioSource Shot;
    public AudioSource EmptyMagazine;
    private Ammo ammo;

    void Start()
    {
        Shot = GetComponent<AudioSource>();
        ammo = GetComponent<Ammo>();
    }

    public void StartPlaying()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammo.CurAmmo > 0)
        {
            Shot.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammo.CurAmmo == 0)
        {
            EmptyMagazine.Play();
        }
    }

    void Update()
    {
        StartPlaying();
    }
}
