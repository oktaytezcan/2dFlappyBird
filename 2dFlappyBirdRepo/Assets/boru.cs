using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru : MonoBehaviour
{
    // -0.6 da sil 0.1 de ekle 0.033 , 0.178

    [SerializeField] yonetici yonet;
    
    
    void Start()
    {
        
        float rast = Random.Range(0.33f, 0.120f);
        transform.position = new Vector3(0.1f, rast, transform.position.z);
      
        yonet = GameObject.Find("Yonetici").GetComponent<yonetici>();//yoneticideki deðer ve fonksiyon
    }


    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -0.6)
        {
            yonet.skor_arttýr(10);
            Destroy(gameObject);
        }
        transform.Translate(-0.2f*Time.deltaTime, 0, 0);
    }
}
