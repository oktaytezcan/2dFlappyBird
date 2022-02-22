using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulut : MonoBehaviour
{
    //bulutu -0.4 -0.4 baþa alcaz.random yükseklik 0.5 ile 0
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -0.4f)
        {
            float y = Random.Range(0.0f, 0.5f);//random yüksekliklerde bulutun doðmasý için
            transform.position = new Vector3(0.5f, y, transform.position.z);//z ekseniyle iþimzi yok random y ve belirledimiz x in hangi aralýðýnda hareketr etceðini belirledik.
        
        
        
        }
        transform.Translate(-0.1f * Time.deltaTime, 0, 0);//hareket etmesini ayarladýk.
    }
}
