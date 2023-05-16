using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<Skin> skins;
    public GameObject objtest;
    public bool chek0, chek1;

    public void Awake()
    {
        chek0 = PlayerPrefs.GetInt("chek0") == 1 ? false : true;
        chek1 = PlayerPrefs.GetInt("chek1") == 1 ? false : true;
    }
    private void Start()
    {
        //objtest.SetActive(true);

            skins[0].HideSkin();
      skins[1].HideSkin();
        if (chek0 == true)
        {
            skins[0].HideSkin();
            skins[2].HideSkin();
            skins[1].ShowSkin();
        }
        else if (chek1 == true)
        {
            skins[0].HideSkin();
            skins[1].HideSkin();
            skins[2].ShowSkin();
            // objtest.SetActive(true); 

        }
        else
        {
            skins[1].HideSkin();
            skins[2].HideSkin();
            skins[0].ShowSkin();
        }
      

    }

}
