using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript_ : MonoBehaviour
{
    public void PlayGame(int LevelNumber)
    {
        PlayerPrefs.SetInt("Level", LevelNumber);
        SceneManager.LoadScene("Game");
    }
}
