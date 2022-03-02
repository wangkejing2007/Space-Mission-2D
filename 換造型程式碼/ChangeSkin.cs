using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeSkin : MonoBehaviour //換造型程式碼
{
    public SpriteRenderer skin; //呼叫切換造型場景中的飛機
    public SpriteRenderer assetskin;//呼叫資料夾中飛機的共用物件
    public List<Sprite> skins = new List<Sprite>(); //創造切換造型的列表
    private int selectedSkin = 0;//決定造型的變數
    void Start()
    {

    }
    void Update()
    {

    }
    public void next()
    {
        selectedSkin = 0;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    }
    public void next2()
    {
        selectedSkin = 1;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    }
    public void next3()
    {
        selectedSkin = 2;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    } 
    public void next4()
    {
        selectedSkin = 3;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    }
    public void next5()
    {
        selectedSkin = 4;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    }
    public void next6()
    {
        selectedSkin = 5;
        skin.sprite = skins[selectedSkin];
        assetskin.sprite = skins[selectedSkin];
    }
}



