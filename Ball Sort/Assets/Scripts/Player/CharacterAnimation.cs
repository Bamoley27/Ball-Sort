using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterAni();
    }
    public void CharacterAni(){
        ani.SetFloat("run",Mathf.Abs(PlayerController.hAxis)); 
        
    }
}
