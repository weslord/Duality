using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetListener : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this);
    }

    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            Scene currentScene = SceneManager.GetActiveScene();

            if (currentScene.name == "Win Screen") {
                // Restart entire game
                SceneManager.LoadSceneAsync(0);
            } else {
                // Reset just this level
                SceneManager.LoadSceneAsync(currentScene.buildIndex);
            }
        }
    }
}
