using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class M3 : MonoBehaviour //大怪物的程式碼
{
    public static M3 Instance;//公開程式碼引用權
    public float hp = 10f;//大怪物血量變數
    private float time;//怪物移動時間碼表
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.001)
        {
            gameObject.transform.position += new Vector3(0, -0.005f, 0);
            time = 0f;
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
                money.Instance.AddM3Score();
            }
        }
        if (col.tag == "ship")
        {
            Destroy(gameObject);
            money.Instance.AddM3Score();
        }
    }
    public void destroyM3()
    {
        Destroy(gameObject);
    }
}
