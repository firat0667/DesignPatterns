using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObejctCatch : MonoBehaviour
{
    GameObject my;
    GameObject[] multiObject;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Mother").GetComponent<FirstFile>().Age = 15;
        GameObject.Find("Mother/Child").GetComponent<FirstFile>().Age=9;
        // mother  childobject child age = 9 //
      transform.Find("Child").GetComponent<AudioSource>().mute=true;
        // this only search child   but dont search grandchild
        multiObject = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject obj in multiObject)
        {
            obj.GetComponent<FirstFile>().Age = 15;
        }
        // all player tags object  age component 15;
    CapsuleCollider mycapsule=gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        if (gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
            gameObject.name = "Change Name";
      // if gameobject contain capsule collider change name
      Camera camera=(Camera)FindAnyObjectByType(typeof(Camera));
        if (camera)
            Debug.Log("Yes camera here");
        else
            Debug.Log("camera empty");
        if (gameObject.activeSelf)
            Debug.Log("true");
        // if gameobject settactive=true  console writes true


    Rigidbody rigidbody= gameObject.AddComponent<Rigidbody>() as Rigidbody;
        rigidbody.isKinematic = true;
        // add rigidbody and iskinematik value true  object  dont impressed by physic

        gameObject.SendMessage("TouchScene","John",SendMessageOptions.DontRequireReceiver);
        // DontRequireReceiver uses when we want send error masage
        gameObject.BroadcastMessage("TouchScene2");
        // send to message child object;
        // if child object contains TouchScene2 method runnig now;
        Destroy(this);
        // destroy this script but not destroy object;
        Destroy(GetComponent<Rigidbody>());
        // destroy thýs gameobject rigidbody component;
    }
    void TouchScene(string name)
    {
        Debug.Log("Touched the scene"+name);
        // writing touched the scene John
    }
    void TouchScene2(string name)
    {
        Debug.Log("I am coming parent object" + name);
        // writing touched the scene John
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
