using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MetodsForScriptBall0 : MonoBehaviour
{
    
    
    public GameObject BonusEffect;
    public int score;
    [SerializeField] Text scoretext;
    public bool chek0, chek1;
    public void Awake()
    {
        if (chek0 = PlayerPrefs.GetInt("chek0") == 0)
            chek0 = true;
        else if (chek0 = PlayerPrefs.GetInt("chek0") == 1)
            chek0 = false;

        chek1 = PlayerPrefs.GetInt("chek1") == 1 ? true : false;
    }
    public void Start()
    {
   /*    skins[0].HideSkin();
        skins[1].HideSkin();
        if (chek0 == true) {
            //skins[1].ShowSkin();
            objtest.SetActive(true); 
    
    }
        else
        {
            skins[0].ShowSkin();
        }
        */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.tag == "Bonus")
        {


            Destroy(collision.gameObject);
            Instantiate(BonusEffect, transform.position, Quaternion.identity);
            if (chek0 == true)
            {
               
                score = score + 5;
            }

            else if (chek1 == true)
            {
                score = score + 10;
            }
            else
            {
                score++;
            }

        }
    }
    private void Update()
    {
        scoretext.text = score.ToString();
    }

    private void OnTriggerExit2D(Collider2D collision1)
    {
        if (collision1.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);

        }
    }

   
    
}
