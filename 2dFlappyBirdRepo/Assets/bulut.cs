using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulut : MonoBehaviour
{
    //bulutu -0.4 -0.4 ba�a alcaz.random y�kseklik 0.5 ile 0
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -0.4f)
        {
            float y = Random.Range(0.0f, 0.5f);//random y�ksekliklerde bulutun do�mas� i�in
            transform.position = new Vector3(0.5f, y, transform.position.z);//z ekseniyle i�imzi yok random y ve belirledimiz x in hangi aral���nda hareketr etce�ini belirledik.
        
        
        
        }
        transform.Translate(-0.1f * Time.deltaTime, 0, 0);//hareket etmesini ayarlad�k.
    }
}
