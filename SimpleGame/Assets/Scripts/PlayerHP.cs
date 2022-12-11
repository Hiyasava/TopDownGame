using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private int playerHP = 100;


    public int _playerHP;

    public GameObject dieMenu;

    void Start()
    {
        _playerHP = playerHP;
    }

    void Update()
    {
        if(playerHP < 0)
        {
            _playerHP = 0;
        }
        playerHP = _playerHP;
        Death();
    }

    void Death()
    {
        if(playerHP == 0)
        {
            dieMenu.SetActive(true);
        }
    }
}
