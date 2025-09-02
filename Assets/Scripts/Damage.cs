using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerLives playerHealt = collision.gameObject.GetComponent<PlayerLives>();

        if (playerHealt == null)
        {

        }
        else
        {
            playerHealt.damagePlayer(damage);
        }
    }
}
