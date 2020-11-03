
using UnityEngine;

public class Player : MonoBehaviour
{
    //修飾詞 類別 名稱
    //None 空直-程式錯誤
    public GameObject Final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們了");
        Final.SetActive(true);


    }

}
