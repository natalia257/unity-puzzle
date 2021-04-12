using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelect : MonoBehaviour
{
    public GameObject StartPanel;

    public void SetMapPhoto(Image Photo)
    {
        Puzzle[] puzzles = FindObjectsOfType<Puzzle>();
        foreach (Puzzle puzzle in puzzles) {
            puzzle.SetPhotoInPuzzle(Photo);
        }
        FindObjectOfType<LevelLoader>().ResetGame();
    }
}
