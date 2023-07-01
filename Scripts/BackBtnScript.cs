using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtnScript : MonoBehaviour
{
    public void LoadLvlMenu()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
