using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoBase : MonoBehaviour
{
    public float waitblackScreen;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")){
            ScenTran.isTrans = true;
            StartCoroutine(SwitchToBaseScene());
        }         
    }

    IEnumerator SwitchToBaseScene(){
        yield return new WaitForSeconds(waitblackScreen);
        SceneManager.LoadScene("worldscene");
        ScenTran.isTrans = false;
    }
}
