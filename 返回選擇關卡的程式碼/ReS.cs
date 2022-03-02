using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReS : MonoBehaviour //返回選擇關卡的程式碼
{
   
   
   
    // Start is called before the first frame update
  public  void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            ClickEvent();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void ClickEvent()
    {

        SceneManager.LoadScene("start");
    }

}
