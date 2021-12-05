using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningToProgram : MonoBehaviour
{
    // Start is called before the first frame updat
    Player warrior;
    Player archer;

    private void Start()
    {
        Warrior warrior = new Warrior();
        warrior.Info();

    }

}
