using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class start : MonoBehaviour //繼續遊戲按鈕的程式碼
{
    public GameObject canvas; //呼叫暫停畫面
   

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            ClickEvent();
        });
    }
    void Update()
    {
        
    }
    void ClickEvent()
    {
        Destroy(canvas);
    }
}
