using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectCoin : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle(); //create a new variable
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnGUI()
    {
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(40, 20, 500, 40), " Score: " + points, guiStyle);
        if (points >= 4)
        {
            GUI.Label(new Rect(80, 80, 1000,80), "You Win!",guiStyle);
        }
       
    }
}
