using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform levelPaneli;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    // Start is called before the first frame update
    void Start()
    {
        if      (LevelScript.kacinciLevel == 1) Instantiate(level1, levelPaneli);
        else if (LevelScript.kacinciLevel == 2) Instantiate(level2, levelPaneli);
        else if (LevelScript.kacinciLevel == 3) Instantiate(level3, levelPaneli);
        else if (LevelScript.kacinciLevel == 4) Instantiate(level4, levelPaneli);
        else if (LevelScript.kacinciLevel == 5) Instantiate(level5, levelPaneli);
        else if (LevelScript.kacinciLevel == 6) Instantiate(level6, levelPaneli);
        else if (LevelScript.kacinciLevel == 7) Instantiate(level7, levelPaneli);
        else if (LevelScript.kacinciLevel == 8) Instantiate(level8, levelPaneli);
        else if (LevelScript.kacinciLevel == 9) Instantiate(level9, levelPaneli);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
