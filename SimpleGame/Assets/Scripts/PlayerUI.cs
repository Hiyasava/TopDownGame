using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Ammo ammo;
    public PlayerHP playerHP;

    public Text HP;
    public Text Bullets;

    void Update()
    {
        Bullets.text = ammo.CurAmmo.ToString() + "/" + ammo.AmmoAmount.ToString();
        HP.text = playerHP._playerHP.ToString();
    }
}
