using UnityEngine;

public class BasketballCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager script

    private void OnTriggerEnter(Collider other)  // Changed parameter type to Collider
    {
        // Check if the basketball touches the capsule (net)
        if (other.CompareTag("BasketballNet"))
        {
            scoreManager.IncreaseScore(100); // Increase score by 100
        }
    }
}
