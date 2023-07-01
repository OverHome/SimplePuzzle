using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlBtnScript : MonoBehaviour
{
    public static GameObject LvlMode;
    public void LoadPuzzle(Image image)
    {
        LevelData.PuzzleImage = image;
        LvlMode.SetActive(true);
    }
}
