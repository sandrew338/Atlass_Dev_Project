using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement   ;
public class LoseScene : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString(); 
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
  
}
