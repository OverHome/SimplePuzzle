using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlModeScript: MonoBehaviour
{
    public void StartLevel(int pieceCount)
    {
        LevelData.Height = LevelData.Width = pieceCount;
        SceneManager.LoadScene("PuzzleScene");
    }
}
