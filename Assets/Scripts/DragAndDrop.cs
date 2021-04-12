using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject SelectedPiece;
    private int OIL = 1;

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit && hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<Puzzle>().GetInRightPosition())
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<Puzzle>().SetSelected(true);
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                } 
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<Puzzle>().SetSelected(false);
                SelectedPiece = null;
            }
        }
        if(SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
