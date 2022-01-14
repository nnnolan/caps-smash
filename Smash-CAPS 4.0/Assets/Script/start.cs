using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void clicked()
    {
        SceneManager.LoadScene("Character Select", LoadSceneMode.Additive);
        foreach (GameObject l in list)
        {
            Destroy(l.gameObject);
        }
    }
    public void clickedmenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Additive);
        foreach (GameObject l in list)
        {
            Destroy(l.gameObject);
        }
    }
    public void quit2()
    {
        Application.Quit();
    }
}
