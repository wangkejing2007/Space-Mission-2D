using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boss : MonoBehaviour //魔王怪物的程式碼
{

    public float time;//魔王移動時間的碼表
    public float hp = 500f;//魔王血量變數
    public GameObject Win;//呼叫勝利文字框物件
    public GameObject endplot;//呼叫結尾劇情按鈕
    public static Boss Instance;//公開程式碼引用權
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Win.SetActive(false);
        endplot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        
           
        if (time > 1)
        {
            gameObject.transform.position += new Vector3(-0.025f, 0, 0);
            if(time>2)
            {
                time = 0;
            }
            
        }
        else
        {
            gameObject.transform.position += new Vector3(0.025f, 0, 0);
        }
        
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(col.gameObject);
            hp = hp - 1f;
            if (hp == 0f)
            {
                Destroy(gameObject);
                Win.SetActive(true);
                endplot.SetActive(true);
                ShipControl1.Instance.IsplayingFalse();
            }
        }
        if (col.tag == "ship")
        {
            Destroy(col.gameObject);

        }
    }
   

}
