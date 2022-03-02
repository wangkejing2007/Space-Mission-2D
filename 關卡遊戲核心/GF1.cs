using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GF1 : MonoBehaviour //遊戲核心
{
    public GameObject E1; //呼叫小怪物物件
    public GameObject E2; //呼叫中怪物物件
    public GameObject E3; //呼叫大怪物物件
    public float M1time;  //小怪物生成碼表
    public float M2time;  //中怪物生成碼表
    public float M3time;  //大怪物生成碼表
    public float Gameplaytime;  //遊戲遊玩時間
    public GameObject RestartButton;  //呼叫重新開始按鈕
    public bool IsPlaying = false;  //控制系統是否執行的布林函數
    public GameObject  Win;  //呼叫勝利文字框物件
    public GameObject GobackGobackButton; //回到選擇關卡按鈕
    public static GF1 Instance;  //公開程式碼引用權
    public  float Monster1; //小怪物生成時間閘
    public float Monster2;  //中怪物生成時間閘
    public float Monster3;  //大怪物生成時間閘
    public GameObject award;  //呼叫禮物盒物件
    public GameObject A1;  //呼叫獎勵物件1 麵包造型
    public GameObject A2;  //呼叫獎勵物件2 手機造型
    public GameObject A3;  //呼叫獎勵物件3 雷神槌造型
    public GameObject A4;  //呼叫獎勵物件4 計算機造型
    public GameObject A5;  //呼叫獎勵物件5 水壺造型
    public GameObject A6;  //呼叫獎勵物件6 錢
    public int a = 0;  //隨機獎勵變數
    public int Numaward = 10;  //獎勵總數
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        GobackGobackButton.SetActive(false);
        Win.SetActive(false);
        RestartButton.SetActive(false);
        award.SetActive(false);
        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A5.SetActive(false);
        A6.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        M2time += Time.deltaTime;
        M1time += Time.deltaTime;
        M3time += Time.deltaTime;
        Gameplaytime += Time.deltaTime;

        if (Gameplaytime >= 10f)
        {
            IsPlaying = false;
            M1.Instance.destroyM();
            Win.SetActive(true);
            award.SetActive(true);
            ShipControl1.Instance.IsplayingFalse();
            Instantiate(award, Vector2.zero, Quaternion.identity);
        }

       if (M1time > Monster1)
        {
            Vector3 pos = new Vector3(Random.Range(-3.5f, 3.5f), 4.5f, 0);
            Instantiate(E1, pos, transform.rotation);
            M1time = 0f;
        }
       
        if (M2time > Monster2)
            {
                Vector3 pos1 = new Vector3(Random.Range(-3.5f, 3.5f), 4.5f, 0);
                Instantiate(E2, pos1, transform.rotation);
                M2time = 0f;
            }

        if (M3time > Monster3)
            {
                Vector3 pos2 = new Vector3(Random.Range(-3.5f, 3.5f), 4.5f, 0);
                Instantiate(E3, pos2, transform.rotation);
                M3time = 0f;
            }
    }
   
    public void GameStart()

    {
        IsPlaying = true; 
        GobackGobackButton.SetActive(false); 
    }
    public void GameOver()
    {
        IsPlaying = false;
        GobackGobackButton.SetActive(true);
        RestartButton.SetActive(true);
    }
    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1f;
    }
   
    public void starttime()
    { 
        a = Random.Range(1, Numaward);
        if (a == 1)
        {
            A1.SetActive(true);
        }
        if (a == 2)
        {
            A2.SetActive(true);
        }
        if (a == 3)
        {
            A3.SetActive(true);
        }
        if (a == 4)
        {
            A4.SetActive(true);
        }
        if (a == 5)
        {
            A5.SetActive(true);
        }
        if (a == 6 || a == 7 || a == 8 ||  a == 9 || a == 10 )
        {
            A6.SetActive(true);
        }

    }
    
    public void victoryButton()
    {
        GobackGobackButton.SetActive(true);
        RestartButton.SetActive(true);
        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A5.SetActive(false);
        A6.SetActive(false);
    }
}

