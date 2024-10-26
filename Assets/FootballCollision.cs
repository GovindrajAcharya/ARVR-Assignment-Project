using UnityEngine;

public class FootballCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager script

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FootballNet"))
        {
            scoreManager.IncreaseScore(100); // Increase score by 100
        }
    }
}
