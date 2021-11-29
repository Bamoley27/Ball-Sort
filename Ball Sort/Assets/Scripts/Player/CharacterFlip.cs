using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
    public Transform player;
    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.hAxis < 0 && facingRight){// if you press the left arrow and your facing right then you will be face left;
            flipCharacter();
        }
        else if (PlayerController.hAxis > 0 && !facingRight){// if you press the right arrow and your facing left then you will be face right;
            flipCharacter();
        }
    }

    void flipCharacter(){
        facingRight = !facingRight; // if facing right is true it will be false and if it is false it will be true
        player.Rotate(0f,180f,0f);
    }
}
