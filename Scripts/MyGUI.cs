using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGUI : MonoBehaviour {
    public static int state = 0;
    private float maxwidth, maxheight, width, height;
    GUIStyle gs;
    float last;
    public static string winner;
    // Use this for initialization
    void Start () {
        maxwidth = Screen.width;
        maxheight = Screen.height;
        width = 100;
        height = 100;
        gs = new GUIStyle();
        gs.fontSize = 36;
        gs.alignment = TextAnchor.LowerCenter;
        //FontStyle fs = new FontStyle();
        last = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if(state == 1)
        {
            if(last == 0)last = Time.time;
            GUI.Label(new Rect(maxwidth / 2 - width / 2, maxheight / 2 - height / 2, width, height), "<color=#00FF00>3</color>", gs);
            if (Time.time - last > 1) state++;
        }
        else if(state == 2)
        {
            GUI.Label(new Rect(maxwidth / 2 - width / 2, maxheight / 2 - height / 2, width, height), "<color=#00FF00>2</color>", gs);
            if (Time.time - last > 2) state++;
        }
        else if (state == 3)
        {
            GUI.Label(new Rect(maxwidth / 2 - width / 2, maxheight / 2 - height / 2, width, height), "<color=#00FF00>1</color>", gs);
            if (Time.time - last > 3) state++;
        }
        else if(state == 4)
        {
            GUI.Label(new Rect(maxwidth / 2 - width / 2, maxheight / 2 - height / 2, width, height), "<color=#00FF00>GO!</color>", gs);
            if (Time.time - last > 4) state++;
        }
        else if(state == 5)
        {

        }
        else if(state > 5)
        {
            GUI.Label(new Rect(maxwidth / 2 - width / 2, maxheight / 2 - height / 2, width, height), "<color=#00FF00>Gameover!</color>", gs);
        }
    }
}
