using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenTran : MonoBehaviour
{
    public Animator blackScreen;
    public static bool isTrans;

    private void Start()
    {
        blackScreen = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        IsSwitchScreen();
    }
    public void IsSwitchScreen(){
        blackScreen.SetBool("isCloseScene",isTrans);
    }
}
