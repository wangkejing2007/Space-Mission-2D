using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour //暫停介面的程式碼
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnEnable()
    {
        Time.timeScale = 0f;
        ShipControl1.Instance.IsplayingFalse();
    }
    void OnDisable()
    {
        Time.timeScale = 1f;
        ShipControl1.Instance.IsplayingTrue();
    }
}
