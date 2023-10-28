using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicMethod : MonoBehaviour
{
    // Start is called before the first frame update
    private IEnumerator firstCont;
    void Start()
    {
        firstCont = TimeExample(3);
        StartCoroutine(firstCont);
    }
    IEnumerator LastCoroutine()
    {
        Debug.Log("last cont");
        yield return null;
    }
    // Coroutines works when our request
    IEnumerator TimeExample(float time)
    {
        // it works forever
        while (true)
        {

            //codes
            Debug.Log("1. write");
            // waiting time 
            yield return new WaitForSeconds(time); //  1 frame wait 
            yield return new WaitForFixedUpdate(); // if all update functions will be worked than this method work
            StartCoroutine(LastCoroutine());
            Debug.Log("3 secand wait than  write");
            // other code
        }

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            StopCoroutine(firstCont);

            StopAllCoroutines();
            // all coroutines stopped


            // this code will be used  char health regration;
        }
    }
}
