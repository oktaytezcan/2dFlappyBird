using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//text dosays� i�in.

public class yonetici : MonoBehaviour
{
    public GameObject boru;
    int skor=0;
    public Text skor_txt;
    void Start()
    {
        InvokeRepeating("boru_ekle", 0.0f, 3.0f);
        skor_txt.text = skor.ToString();
    }

void boru_ekle()
    {


        GameObject yeniboru = Instantiate(boru);
    }
 
public void skor_artt�r(int deger)//her boru yeniden sahneye eklendiginde diger boruyu ge�tigimiz i�in skora ekleme yap�yoruz.
    {
        skor += deger;
        skor_txt.text = skor.ToString();
    }



}
