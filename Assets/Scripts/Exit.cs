using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    static int exitCount = 0;
    public int requiredExits = 2;

    void LoadNextLevel() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(currentScene + 1);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        exitCount++;

        if (exitCount == requiredExits ) {
            //TODO: fix this! counts the extra collider on other...
            //      make exits specific to each character?
            //      ignore other collider layer?
            LoadNextLevel();
            exitCount = 0;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        exitCount--;
    }
}
