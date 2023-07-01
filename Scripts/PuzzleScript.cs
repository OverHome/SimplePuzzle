using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    [SerializeField] private GameObject puzzlePiece;
    [SerializeField] private GameObject puzzleGrid;
    [SerializeField] private int width;
    [SerializeField] private int height;

    private Texture2D _texture;

    void Start()
    {
        width = LevelData.Width;
        height = LevelData.Height;
        _texture = LevelData.PuzzleImage.sprite.texture;
        puzzleGrid.GetComponent<GridLayoutGroup>().cellSize = new Vector2(puzzleGrid.GetComponent<RectTransform>().rect.width/width, puzzleGrid.GetComponent<RectTransform>().rect.height/height);
        // _texture = Resources.Load<Texture2D>("PuzzleImgs/2");
        foreach (var pieceImg in  CropImg())
        {
            var obj = Instantiate(puzzlePiece, puzzleGrid.transform, true);
            obj.transform.localScale = new Vector3(1, 1, 1);
            obj.transform.rotation *= Quaternion.Euler(0, 0, -90*Random.Range(0, 4));
            obj.GetComponent<Image>().sprite = pieceImg;
        }
    }

    private List<Sprite> CropImg()
    {
        List<Sprite> texturePiece = new List<Sprite>();
        for (int y = width-1; y >= 0; y--)
        {
            for (int x = 0; x < height; x++)
            {
                var rect = new Rect(_texture.width / width * x, _texture.height / height * y,
                    _texture.width / width, _texture.height / height);
                texturePiece.Add(Sprite.Create(_texture, rect, Vector2.one * 0.5f));
            }
        }
        
        return texturePiece;
    }
}