using Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : monobehavior{


    public string newGameScene;

    void initalize() {


    }


    void update(){


    }

    public void NewGame(){

        SceneManager.LoadScene(newGameScene);

    }

    public void QuitGame() {

        Application.Quit();

    }

}