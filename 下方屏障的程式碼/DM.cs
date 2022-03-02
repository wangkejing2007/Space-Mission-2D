using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM : MonoBehaviour //下方屏障的程式碼
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "E1")
        {
            Destroy(col.gameObject);
        }
    }
}
