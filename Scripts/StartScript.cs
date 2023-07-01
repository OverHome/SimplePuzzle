using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void GoToLevelScene()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
