using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class money : MonoBehaviour //錢的程式碼
{
    
    public int Score = 0; //設置錢的變數
    public Text ScoreText; //呼叫錢的文字框
    public static money Instance; //公開程式碼引用權
    public int M1money=2; //擊殺小怪物獲得的錢的變數
    public int M2money=5; //擊殺中怪物獲得的錢的變數
    public int M3money=10;//擊殺大怪物獲得的錢的變數

    // Start is called before the first frame update
    void Start()
    {
        Instance= this;
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void AddM1Score()

    {
        Score += M1money;

        ScoreText.text = "x" + Score;
    }

    
    public void AddM2Score()

    {
        Score += M2money;

        ScoreText.text = "x" + Score;
    }

    public void AddM3Score()

    {
        Score += M3money;

        ScoreText.text = "x" + Score;
    }
    public void Addzero()
    {
        Score = 0;
        ScoreText.text = "x" + Score;


    }
}
