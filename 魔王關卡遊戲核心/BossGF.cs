using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossGF : MonoBehaviour //魔王關卡遊戲核心
{
    public GameObject E1; //呼叫小怪物
    public GameObject E2; //呼叫中怪物
    public GameObject E3; //呼叫大怪物
    public bool IsPlaying = false; //控制系統是否執行的布林函數
    public static BossGF Instance; //公開程式碼引用權
    public float Monster1; //小怪物生成時間閘
    public float Monster2; //中怪物生成時間閘
    public float Monster3; //大怪物生成時間閘
    public float M1time; //小怪物生成碼表
    public float M2time; //中怪物生成碼表
    public float M3time; //大怪物生成碼表
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        M2time += Time.deltaTime;
        M1time += Time.deltaTime;
        M3time += Time.deltaTime;
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
}
