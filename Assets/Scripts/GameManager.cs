using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [HeaderAttribute(" score variables")]
    int score;
    public Text scoreText;

    [HeaderAttribute(" life variables")]
    public Image greenLifeBar;
    public float currentLife = 100;
    public float maxLife= 100;
    public float minLife= 0;

    void LifeInGame()
    {
       greenLifeBar.fillAmount = currentLife / maxLife;
    }
    void Update()
    {
        LifeInGame();
        State();
    }
    public void CurrentScore(int numb)
    {
        score = score + numb;
        scoreText.text = "Score: " + score;
        
    }
    public void  CurrentLifeInGame(float numb)
    {
        currentLife = currentLife - numb;
        
    }
    public void State()
    {
        if (currentLife <= 0)
        {
            SceneManager.LoadScene("Lose");
            //print("has muerto");
        }
    }
    

}
