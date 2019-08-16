using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public GameObject[] category;
    public GameObject[] contents;

    void Start()
    {
        ButtonNotSelect();
        category[0].transform.GetChild(0).GetComponent<Text>().color=new Color32(0,157,224,255);
        contents[0].SetActive(true);
    }

    #region Category;
    //[ UI Category ]
    public void SelectButton(int index)
    {
        ButtonNotSelect();
        category[index].transform.GetChild(0).GetComponent<Text>().color = new Color32(0, 157, 224, 255);
        contents[index].SetActive(true);

    }

    void ButtonNotSelect()
    {
        for (int i = 0; i < category.Length; i++)
        {
            category[i].transform.GetChild(0).GetComponent<Text>().color = new Color32(231, 231, 231,255);
            contents[i].SetActive(false);
        }
    }
    #endregion Category;




    #region OverlayActiveToggle
    //[ Overlay Active Toggle ]
    //SettingManager.cs using overlayToggle boolean.
    public void OverlayActive()
    {
        if(SettingManager.overlayToggle==true)
        {

        }
        else
        {

        }
        
        
    }



    #endregion OverlayActiveToggle
}
