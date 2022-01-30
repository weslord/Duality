using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetListener : MonoBehaviour
{
    void Awake() {
        ResetListener[] listeners = GameObject.FindObjectsOfType<ResetListener>();
        if (listeners.Length > 1) {
            Destroy(this.gameObject);
        } else {
            DontDestroyOnLoad(this);
        }
    }

    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            Scene currentScene = SceneManager.GetActiveScene();

            if (currentScene.name == "Win Screen") {
                // Restart entire game
                SceneManager.LoadScene(0);
            } else {
                // Reset just this level
                SceneManager.LoadScene(currentScene.buildIndex);
            }
        }

        if (Input.GetKeyDown(".")) {
            Scene currentScene = SceneManager.GetActiveScene();

            if (currentScene.buildIndex < SceneManager.sceneCountInBuildSettings - 1) {
                SceneManager.LoadScene(currentScene.buildIndex + 1);
            }
        }

        if (Input.GetKeyDown(",")) {
            Scene currentScene = SceneManager.GetActiveScene();

            if (currentScene.buildIndex > 0) {
                SceneManager.LoadScene(currentScene.buildIndex - 1);
            }
        }
    }
}
