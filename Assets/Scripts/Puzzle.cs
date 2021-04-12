using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    [SerializeField]
    private Vector3 RightPosition;
    
    private bool InRightPosition;
    
    private bool Selected;
    
    public bool GetInRightPosition() { return InRightPosition; }
    public void SetInRightPosition(bool InRightPosition) 
    { 
        this.InRightPosition = InRightPosition; 
    }

    public bool GetSelected() { return Selected; }
    public void SetSelected(bool Selected)
    {
        this.Selected = Selected;
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if(!Selected)
            {
                if(InRightPosition == false)
                {
                    FindObjectOfType<LevelLoader>().AddElementInRightPosition();
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    FindObjectOfType<Points>().AddPoints(2);
                }
            }
        }
    }

    public void MixPuzzles()
    {
        RightPosition = transform.position;
        InRightPosition = false;
        transform.position = new Vector3(Random.Range(1f, 8f), Random.Range(-3f, 2f));
    }

    public void SetPhotoInPuzzle(Image Photo)
    {
        transform.Find("Background").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        MixPuzzles();
    }
}
