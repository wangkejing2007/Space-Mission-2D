using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class select : MonoBehaviour //換造型按鈕文字顯示的程式碼
{
    public Text selectText; //呼叫按鈕的文字框
    public Text NoselectText1; //呼叫按鈕的文字框
    public Text NoselectText2; //呼叫按鈕的文字框
    public Text NoselectText3; //呼叫按鈕的文字框
    public Text NoselectText4; //呼叫按鈕的文字框
    public Text NoselectText5; //呼叫按鈕的文字框
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            ClickEvent();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ClickEvent()
    {
        selectText.text = "selected";
        NoselectText1.text = "select";
        NoselectText2.text = "select";
        NoselectText3.text = "select";
        NoselectText4.text = "select";
        NoselectText5.text = "select";
    }
}
