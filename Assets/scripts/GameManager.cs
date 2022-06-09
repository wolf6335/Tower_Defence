using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool gameIsOver;

    public GameObject gameOverUI;

    public SceneFader sceneFader;

    public GameObject completeLevelUI;

    public WaveSpawner waveSpawner;

    private void Start()
    {
        gameIsOver = false;
    }

    void Update () {

        if (gameIsOver)
        {
            return;
        }

		if(PlayerStats.lives == 0)
        {
            Debug.Log("Ok Wavespawneer false");
            WaveSpawner Waves = GetComponent<WaveSpawner>();
            Waves.enabled = false;
            EndGame();
        }

	}

    void EndGame()
    {
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
