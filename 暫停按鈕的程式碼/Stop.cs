using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stop : MonoBehaviour //暫停按鈕的程式碼
{
    public GameObject canvasPrefab; //呼叫暫停畫面
    // Start is called before the first frame update
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
        Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);
    }
}
