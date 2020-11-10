using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    //修飾詞 類別 名稱
    //None 空直-程式錯誤
    public GameObject Final;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們了");

        if (collision.name == "傳送們")
        {
            Final.SetActive(true);
        }

        if (collision.tag == "gem")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = count + "/999";
        }

    }

}
