using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator housedoorani;
    public GameObject doorinColider;
    public float waitToOpenDoor;
    private bool openHouseDoor;

    // Start is called before the first frame update
    void Start()
    {
        housedoorani = GetComponent<Animator>();
        openHouseDoor = false;
    }

    void Update() {
        housedoorani.SetBool("isOpen",openHouseDoor);
        StartCoroutine(Wait2OpenDoorIn());
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            openHouseDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player"){
            housedoorani.SetTrigger("isClose");
            openHouseDoor = false;
        }
    }
    IEnumerator Wait2OpenDoorIn(){
        yield return new WaitForSeconds(waitToOpenDoor);
        doorinColider.SetActive(!openHouseDoor);
    }
}
