using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFile : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;
    public int Age;
    public float Salary;
    public string[] Childs;
    public List<string> FatherList;
    void Start()
    {


        GetComponentInParent<AudioSource>().mute = true;
       // all parent objcet mute



        Debug.Log("Hi");
        foreach (var child in Childs)
        {
            Debug.Log(child);
        }
        CapsuleCollider[] capsules=GetComponents<CapsuleCollider>();
        for (int i = 0; i < capsules.Length; i++)
        {
            capsules[i].enabled = false;
        }
        // if more than capsule colider useable;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
