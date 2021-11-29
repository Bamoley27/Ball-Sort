using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIn : MonoBehaviour
{
    public Animator doorani;
    public GameObject doorinColider;
    public float waitToOpenDoor;
    private bool openDoor;

    // Start is called before the first frame update
    void Start()
    {
        doorani = GetComponent<Animator>();
        openDoor = false;
    }

    void Update() {
        doorani.SetBool("doorin",openDoor);
        StartCoroutine(Wait2OpenDoorIn());
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            openDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player"){
            doorani.SetTrigger("closedoorin");
            openDoor = false;
        }
    }
    IEnumerator Wait2OpenDoorIn(){
        yield return new WaitForSeconds(waitToOpenDoor);
        doorinColider.SetActive(!openDoor);
    }
}
