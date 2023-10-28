using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeMetod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WriteWord", 3f);
        // 3 secand wait than run
        InvokeRepeating("WriteWord",3f,0.8f);
        //3 secand wait than  repeat all 0.8f run;
    }

    void WriteWord()
    {
        Debug.Log("ý coming this function");
    }
    private void Update()
    {
       if (IsInvoking("WriteWord"))   
            Debug.Log("write something");
       // this method controlled by writeMethod run or  not run 
        else
            Debug.Log("dont write anything");

        if (Input.GetKeyUp(KeyCode.Space)) 
        { 
            CancelInvoke();
            // stop all Invoke;
        }
    }

}
