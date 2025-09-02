using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int lives;
    

    public void damagePlayer(int damage)
    {
        lives = lives - damage;

        
    }

    private void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("nivel");
        }
    }
}
