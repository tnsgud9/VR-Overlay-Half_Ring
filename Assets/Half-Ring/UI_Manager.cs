using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class UI_Manager : MonoBehaviour
{
    public GameObject SettingManagerOBJ;

    public GameObject[] category;
    public GameObject[] contentsField;
    public GameObject[] HowtoForm;

    public GameObject[] image;
    public GameObject[] color;
    void Start()
    {
        ButtonNotSelect();
        category[0].transform.GetChild(0).GetComponent<Text>().color=new Color32(0,157,224,255);
        contentsField[0].SetActive(true);

        image[0].GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        color[2].GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        HowtoForm[0].GetComponent<Image>().color = new Color32(139, 139, 139, 255);
    }

    #region ContentsCommonsMethod
    public void ContentsNotSelect(GameObject[] element, int colorCode)
    {
        for (int i = 0; i < element.Length; i++)
            element[i].GetComponent<Image>().color = new Color32(Convert.ToByte(colorCode), Convert.ToByte(colorCode), Convert.ToByte(colorCode), 255);
    }

    #endregion ContentsCommonsMethod

    #region Category;
    //[ UI Category ]
    public void SelectButton(int index)
    {
        ButtonNotSelect();
        category[index].transform.GetChild(0).GetComponent<Text>().color = new Color32(0, 157, 224, 255);
        contentsField[index].SetActive(true);

    }

    void ButtonNotSelect()
    {
        for (int i = 0; i < category.Length; i++)
        {
            category[i].transform.GetChild(0).GetComponent<Text>().color = new Color32(231, 231, 231,255);
            contentsField[i].SetActive(false);
        }
    }
    #endregion Category;

    //[Overlay Active Toggle]
    //SettingManager.cs using overlayToggle boolean and use method SettingManager.OverayActive();

    #region Image;
    //[ Select Image ]

    public void SelectImage(int index)
    {
        ContentsNotSelect(image, 34);
        image[index].GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        SettingManager.ImageCode = index;
        SettingManagerOBJ.GetComponent<SettingManager>().OverlayChange();
        //SettingManager.OverlayChange();
    }

    #endregion Image;

    #region Color
    //[ Select Color ]

    public void SelectColor(int index)
    {
        ContentsNotSelect(color ,34);
        color[index].GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        SettingManager.ColorCode = index;
        SettingManagerOBJ.GetComponent<SettingManager>().OverlayChange();
        //SettingManager.OverlayChange();
    }

    #endregion Color;

    #region HowToUse
    //[ How to use ]

    public void SelectHowtoButton(int index)
    {

        for (int i = 0; i < HowtoForm.Length; i++)
        {
            HowtoForm[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            HowtoForm[i].transform.GetChild(0).gameObject.SetActive(false);
        }
        HowtoForm[index].GetComponent<Image>().color = new Color32(139, 139, 139, 255);
        HowtoForm[index].transform.GetChild(0).gameObject.SetActive(true);
        //SettingManager.OverlayChange();
    }



    #endregion HowToUse


    /*
    #region OverlayActiveToggle
    //[ Overlay Active Toggle ]
    //SettingManager.cs using overlayToggle boolean.
    public void OverlayActive()
    {
        GetComponent<SettingManager>().OverayActive();
        Debug.LogWarning("Overlay Status  : " + SettingManager.overlayToggle);
    }
    #endregion OverlayActiveToggle
    */



}
