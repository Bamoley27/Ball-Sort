using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerIntoHouse : MonoBehaviour
{
    public Transform player;
    public float xhousePos;
    public float yhousePos;
    
    public float waitblackScreen;
    private void Start() {
        player = GetComponent<Transform>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")){
            ScenTran.isTrans = true;
            StartCoroutine(SwitchToHouseScene());
        }
            
            
    }

    IEnumerator SwitchToHouseScene(){
        yield return new WaitForSeconds(waitblackScreen);
        SceneManager.LoadScene("House");
        ScenTran.isTrans = false;
        
    }
}
