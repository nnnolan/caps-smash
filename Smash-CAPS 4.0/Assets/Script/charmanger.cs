using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class charmanger : MonoBehaviour
{
    bool playerone = false;
    public Button conf;
    public Button deni;
    public Sprite op1;
    public Sprite op2;
    public Sprite op3;
    public Sprite op4;
    public Sprite op5;
    public Sprite op6;
    public Sprite op7;
    public Sprite op8;
    public Sprite p1s;
    public Sprite p2s;
    bool ispicking;
    public float picked;
    public List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setcharge()
    {
        
    }
    public void cop1()
    {
        picked = 1;
    }
    public void cop2()
    {
        picked = 2;
    }
    public void cop3()
    {
        picked = 3;
    }
    public void cop4()
    {
        picked = 4;
    }
    public void cop5()
    {
        picked = 5;
    }
    public void cop6()
    {
        picked = 6;
    }
    public void cop7()
    {
        picked = 7;
    }
    public void cop8()
    {
        picked = 8;
    }
    public void clickedfirst()
    {
        if(ispicking == false)
        {
            ispicking = true;
            conf.gameObject.SetActive(true);
            deni.gameObject.SetActive(true);
        }
    }
    public void cdeni()
    {
        conf.gameObject.SetActive(false);
        deni.gameObject.SetActive(false);
        ispicking = false;
        picked = 0;
    }
    public void confm()
    {
        switch(picked)
        {
            case 1:
                if (playerone == false)
                { p1s = op1; playerone = true;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    ispicking = false;
                }
                else
                {
                    p2s = op1;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    ispicking = false;

                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;
            case 2:
                if (playerone == false)
                {
                    p1s = op2; playerone = true;
                    ispicking = false;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                }
                else
                {
                    p2s = op2;
                    conf.gameObject.SetActive(false);
                    ispicking = false;
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;

            case 3:
                if (playerone == false)
                {
                    p1s = op3; playerone = true;
                    ispicking = false;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                }
                else
                {
                    p2s = op3;
                    ispicking = false;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;
            case 4:
                if (playerone == false)
                {
                    ispicking = false;
                    p1s = op4; playerone = true;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                }
                else
                {
                    p2s = op4;
                    ispicking = false;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;
            case 5:
                if (playerone == false)
                {
                    p1s = op5; playerone = true;
                    ispicking = false;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                }
                else
                {
                    p2s = op5;
                    conf.gameObject.SetActive(false);
                    ispicking = false;
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;

            case 6:
                if (playerone == false)
                {
                    p1s = op6; playerone = true;
                    conf.gameObject.SetActive(false);
                    ispicking = false;
                    deni.gameObject.SetActive(false);
                }
                else
                {
                    p2s = op6;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    ispicking = false;
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;
            case 7:
                if (playerone == false)
                {
                    p1s = op7; playerone = true;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    ispicking = false;
                }
                else
                {
                    p2s = op7;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    ispicking = false;
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;

            case 8:
                if (playerone == false)
                {
                    p1s = op8; playerone = true;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    ispicking = false;
                }
                else
                {
                    p2s = op8;
                    conf.gameObject.SetActive(false);
                    deni.gameObject.SetActive(false);
                    SceneManager.LoadScene("fight", LoadSceneMode.Additive);
                    ispicking = false;
                    foreach (GameObject l in list)
                    {
                        Destroy(l.gameObject);
                    }
                }
                return;
        }

    }
}
