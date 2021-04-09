using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapSelect : MonoBehaviour
{
    public GameObject StartPanel;

    public void SetMapPhoto(Image Photo)
    {
        for(int i = 0; i < 16; i++)
        {
            GameObject.Find("/Foreground/puzzle " + i).transform.Find("Background").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
    }
}
