using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser1 : MonoBehaviour //子彈的程式碼
{
    private float time; //子彈向前移動的碼表
    public float firerate = 0.5f;//子彈向前移動的時間閘
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > firerate)
        {
            gameObject.transform.position += new Vector3(0, 1f, 0);
            time = 0f;
        }    
    }
    public void firerate1()
    {
        firerate = 0.5f;
    }
    public void firerate2()
    {
        firerate = 0.25f;
    }
    public void firerate3()
    {
        firerate = 0.16f;
    }
}
