using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IteamChooser : MonoBehaviour
{

    public Sprite[] gallery;
    public GameObject displayImage;
    public Button nextImg;
    public Button prevImg;
    public int i = 0;
    //[SerializeField] private RectTransform defultPosition;

    private void Start()
    {
        //RectTransform rectTransform = GetComponent<RectTransform>();
    }
    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    public void BtnPrev()
    {
        if (i - 1 >= 0)
        {
            i--;
        }
    }

    void Update()
    {
        Sprite ina = displayImage.GetComponent<Image>().sprite;
        ina = gallery[i];
        

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BtnNext();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BtnPrev();
        }
    }
}
