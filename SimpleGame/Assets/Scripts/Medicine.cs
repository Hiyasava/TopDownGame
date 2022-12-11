using UnityEngine;

public class Medicine : MonoBehaviour
{
    public PlayerHP playerHP;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Medicine")
        {
            playerHP._playerHP += 50;
        }
    }
}
