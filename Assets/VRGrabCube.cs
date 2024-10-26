using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRGrabCube : MonoBehaviour
{
    private ScoreManager scoreManager;
    
    void Start()
    {
        // Find the ScoreManager object in the scene and get the ScoreManager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // This function will be triggered when the object is grabbed by the interactor (controller)
    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        // Add score when grabbed
        scoreManager.IncreaseScore(100);
    }
}
