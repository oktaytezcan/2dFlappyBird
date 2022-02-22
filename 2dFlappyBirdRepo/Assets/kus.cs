using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//sahneyi tekrar yüklemek için bu kütüphanenin ekli olmasý lazým.
public class kus : MonoBehaviour
{


    Rigidbody2D rigi;//kuþa yukarý zýplamasý için güç uygulamamýz gerek ve bunun çin deðiþken oluþturduk.
    public float zýplamagucu;
    public float egilmehýzý;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);//tek sahnemiz oldugu için build settingste 0 yazdýk.
    }
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//space her bastýgýmýz da bu güç uygulansýn
        {
            rigi.velocity = Vector2.zero;//güç unsuru olduðu için burda sýfýrladýk.
            rigi.velocity = Vector2.up * zýplamagucu * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);//kuþu zýplattýðýmýzda yukarý bakmasýný istediðimiz için euhlerangles tanýmladýk vector 3 türünde açý girmemizi saðlar.
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilmehýzý);//space e basmadýgýmýzda aþaðý düþcegi için kafasý yavaþ yqavaþ eðilsin istedik.
        }
    }
}
