using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool gameIsOver;

    public GameObject gameOverUI;

    public SceneFader sceneFader;

    public GameObject completeLevelUI;

    private WaveSpawner waveSpawner;
    public AudioSource Audio;

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
            Audio.enabled = false;
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
