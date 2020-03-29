using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class FGUITester : MonoBehaviour
{
    public UIPanel myPanel;

    //private GComponent sceneBS;

    // Start is called before the first frame update
    void Start()
    {
        //sceneBS = myPanel.ui;

        //abced is key frame
        //sceneBS.GetTransition("t0").SetHook("abced", abcdeFunction);        
        //private void abcdeFunction()
        //{do something});

        //sceneBS.GetTransition("t0").SetHook("abced", ()=> 
        //{do something});

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string sceneName,string transName = "t0")
    {
        myPanel.ui.Dispose();
        myPanel.componentName = sceneName;
        myPanel.CreateUI();
        myPanel.ui.GetTransition(transName).Play();
    }

}
