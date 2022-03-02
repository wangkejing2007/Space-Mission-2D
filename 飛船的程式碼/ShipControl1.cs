using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShipControl1 : MonoBehaviour //飛船程式碼
{
    public GameObject Bullet; //呼叫子彈物件
    public Text HpText; //呼叫血量的文字框
    private float time; //子彈生成的碼表
    public float Hps; //血量的變數
    public float firerateS = 0.5f; //子彈生成的時間閘
    public int pipe = 1; //子彈槍管數的變數
    private bool IsPlaying = true; //控制飛船能否移動的布林函數
    public static ShipControl1 Instance; //公開程式碼引用權
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        HpText.text = "x" + Hps.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if( IsPlaying==true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.position += new Vector3(0.025f, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.position += new Vector3(-0.025f, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position += new Vector3(0, 0.025f, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.position += new Vector3(0, -0.025f, 0);
            }
        }
       
        time += Time.deltaTime;
        if ( pipe==1)
        {
            if (time > firerateS)
            {
                Vector3 pos = gameObject.transform.position + new Vector3(0f, 1.5f, 0);
                Instantiate(Bullet, pos, gameObject.transform.rotation);
                time = 0f;
            }
        }
       if ( pipe==2)
      {
            if (time > firerateS)
            {
                Vector3 pos = gameObject.transform.position + new Vector3(-0.3f, 0.7f, 0);
                Instantiate(Bullet, pos, gameObject.transform.rotation);
                Vector3 pos2 = gameObject.transform.position + new Vector3(0.3f, 0.7f, 0);
                Instantiate(Bullet, pos2, gameObject.transform.rotation);
                time = 0f;
            }
       }
        if (pipe==3)
        {
            if (time > firerateS)
            {
                Vector3 pos = gameObject.transform.position + new Vector3(-0.3f, 0.7f, 0);
                Instantiate(Bullet, pos, gameObject.transform.rotation);
                Vector3 pos2 = gameObject.transform.position + new Vector3(0.3f, 0.7f, 0);
                Instantiate(Bullet, pos2, gameObject.transform.rotation);
                Vector3 pos3 = gameObject.transform.position + new Vector3(0f, 1f, 0);
                Instantiate(Bullet, pos3, gameObject.transform.rotation);
                time = 0f;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
         if (col.tag == "E1")
        {

            Hps = Hps - 1f;
            HpText.text = "x" + Hps.ToString();
             if (Hps == 0)
            {
                 
                Destroy(gameObject);
                money.Instance.Addzero();
                GF1.Instance.GameOver();
            }
        }
    }
   public void pipe1 ()
    {
        pipe = 1;

    }
  public  void pipe2()
    {
        pipe = 2;

    }
  public  void pipe3()
    {
        pipe = 3;

    }
    public void rate1()
    {
        firerateS = 0.5f;
    }
    public void rate2()
    {
        firerateS = 0.25f;
    }
    public void rate3()
    {
        firerateS = 0.16f;
    }
    public void Hp1()
    {
       
        Hps = 3;
        if (Hps == 3)
        {
            Debug.Log("test");
        }
    }
    public void Hp2()
    {
        
        Hps = 5;
        if (Hps==5)
        {
            Debug.Log("test1");
        }
       
    }
    public void Hp3()
    {
        Hps = 7;
        if (Hps == 7)
        {
            Debug.Log("test2");
        }
    }
    public void IsplayingTrue()
    {
        IsPlaying = true;
    }
    public void IsplayingFalse()
    {
        IsPlaying = false;
    }
}
