using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanger : MonoBehaviour
{
    public Player2Controller player2;
    public PlayerController player;
    public bool hasone = false;
    public List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(player2.pscore >= 3 && hasone == false)
        {
            hasone = true;
            SceneManager.LoadScene("Game Over(blue won)", LoadSceneMode.Additive);
            Destroy(player.gameObject);
            Destroy(player2.gameObject);
            foreach (GameObject l in list)
            {
                Destroy(l.gameObject);
            }
        }
        else if(player.pscore >= 3 && hasone == false)
            {
            hasone = true;
            SceneManager.LoadScene("Game Over(red won)", LoadSceneMode.Additive);
            Destroy(player.gameObject);
            Destroy(player2.gameObject);
            foreach (GameObject l in list)
            {
                Destroy(l.gameObject);
            }
        }
    }
}
