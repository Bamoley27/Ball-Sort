using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoGamePlay : MonoBehaviour
{
    public float waitblackScreen;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")){
            ScenTran.isTrans = true;
            StartCoroutine(SwitchToBaseScene());
        }         
    }

    IEnumerator SwitchToBaseScene(){
        yield return new WaitForSeconds(waitblackScreen);
        SceneManager.LoadScene("Play");
        ScenTran.isTrans = false;
    }
    
}
