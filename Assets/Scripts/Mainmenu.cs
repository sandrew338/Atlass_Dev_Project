using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Mainmenu : MonoBehaviour
{
  
    public Text MoneyText;
    public int money;
    public int earndmoney;
    public bool chek0, chek1 = false;
    public void Start()
    {

        chek0 = PlayerPrefs.GetInt("chek0") == 1 ? false : true;
        chek1 = PlayerPrefs.GetInt("chek1") == 1 ? false : true;

        money = PlayerPrefs.GetInt("Money");
        earndmoney = PlayerPrefs.GetInt("Score");
        money += earndmoney;
        PlayerPrefs.SetInt("Money", money);
        MoneyText.text = money.ToString();
        earndmoney = 0;
        PlayerPrefs.SetInt("Score", earndmoney);
    }
    public void StartGame()

    {
        SceneManager.LoadScene(1);
    }
    public void GoToShop()
    {
        SceneManager.LoadScene(3);
        
    }
   
}
