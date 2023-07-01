using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    [SerializeField] private GameObject lvlBtn;
    [SerializeField] private GameObject gridBtn;
    [SerializeField] private GameObject lvlMode;

    private void Start()
    {
        var textures = Resources.LoadAll<Texture2D>("PuzzleImgs").ToArray();
        LvlBtnScript.LvlMode = lvlMode;
        foreach (var texture in textures)
        {
            var obj = Instantiate(lvlBtn, gridBtn.transform, true);
            obj.transform.localScale = new Vector3(1, 1, 1);
            obj.GetComponent<Image>().sprite = ConvertToSprite(texture);
        }
    }
    

    private Sprite ConvertToSprite(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
}