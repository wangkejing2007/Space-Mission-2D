using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class award : MonoBehaviour //禮物物件的程式碼
{
   
    public GameObject prize1; //呼叫禮物物件
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            Destroy(prize1);
        });
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
