//主程式開始
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//呼叫物件
public class GF1 : MonoBehaviour
{
    public GameObject E1; //解釋E1物件是什麼？
    public GameObject E2; //解釋E2物件是什麼？
    public GameObject E3; //解釋E3物件是什麼？
    public float M1time;
    public float M2time;
    public float M3time;
    public float Gameplaytime;
    public GameObject RestartButton;
    public bool IsPlaying = false;
    public GameObject  Win;
    public GameObject GobackGobackButton;
    public static GF1 Instance;
    public  float Monster1;
    public float Monster2;
    public float Monster3;
    public GameObject award;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        GobackGobackButton.SetActive(false);
        Win.SetActive(false);
        RestartButton.SetActive(false);
        award.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        M2time += Time.deltaTime;
        M1time += Time.deltaTime;
        M3time += Time.deltaTime;
        Gameplaytime += Time.deltaTime;

        if (Gameplaytime >= 30f)
        {
            IsPlaying = false;
            M1.Instance.destroyM();
            Win.SetActive(true);
            award.SetActive(true);
            Time.timeScale = 0f;
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
}
