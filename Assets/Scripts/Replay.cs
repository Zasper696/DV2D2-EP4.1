using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public string sceneToLoad = "Level 1"; // Nombre de la escena de nivel 1

    // Reinicia el juego
    public void ReplayGame()
    {
        if (string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.LogError("Scene to load is not set.");
            return;
        }

        // Reinicia los valores necesarios en los managers
        LevelManager.Instance.SetCurrentLevelIndex(0);
        LevelManager.Instance.SetCurrentWaveIndex(0);

        // Reinicia el GameManager
        GameManager.Instance.RestartGame();

        // Carga la escena especificada
        SceneManager.LoadScene(sceneToLoad);
    }
}
