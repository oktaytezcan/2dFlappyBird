using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//sahneyi tekrar y�klemek i�in bu k�t�phanenin ekli olmas� laz�m.
public class kus : MonoBehaviour
{


    Rigidbody2D rigi;//ku�a yukar� z�plamas� i�in g�� uygulamam�z gerek ve bunun �in de�i�ken olu�turduk.
    public float z�plamagucu;
    public float egilmeh�z�;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);//tek sahnemiz oldugu i�in build settingste 0 yazd�k.
    }
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//space her bast�g�m�z da bu g�� uygulans�n
        {
            rigi.velocity = Vector2.zero;//g�� unsuru oldu�u i�in burda s�f�rlad�k.
            rigi.velocity = Vector2.up * z�plamagucu * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);//ku�u z�platt���m�zda yukar� bakmas�n� istedi�imiz i�in euhlerangles tan�mlad�k vector 3 t�r�nde a�� girmemizi sa�lar.
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilmeh�z�);//space e basmad�g�m�zda a�a�� d��cegi i�in kafas� yava� yqava� e�ilsin istedik.
        }
    }
}
