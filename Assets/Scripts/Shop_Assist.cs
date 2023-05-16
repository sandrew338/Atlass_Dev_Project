using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shop_Assist : MonoBehaviour
{

    
    public Button Buybtn, Activatebtn, BuybtnVolley, ActivatebtnVolley;
  
    public int money;
    public Text moneytext;
    public bool chek0, chek1 = false ;
    private void Start()
    {

       

        money = PlayerPrefs.GetInt("Money");
    }
    private void Update()
    {
        moneytext.text = money.ToString();

    }
    public void multi()
    {
        if (money >= 4)
        {       
            money -= 4;
            PlayerPrefs.SetInt("Money", money);
        
        }
        Buybtn.gameObject.SetActive(false);
       
    }

        public void multi1()
        {
            if (money >= 5)
            {
               
                money -= 5;
                PlayerPrefs.SetInt("Money", money);
            BuybtnVolley.gameObject.SetActive(false);

        }

        }
 public void ClickActivate()
    {
       Activatebtn.gameObject.SetActive(false);

            chek0 = true; 
         PlayerPrefs.SetInt("chek0", chek0 ? 1 : 0);

        
       

    }
    public void ClickActivate1()
    {
        ActivatebtnVolley.gameObject.SetActive(false);
        if (chek1 == false)
        {
            chek1 = true;
            PlayerPrefs.SetInt("chek1", chek1 ? 1 : 0);
        }


    }

        public void ExitScene()
        {
            SceneManager.LoadScene(0);
        }

    }
