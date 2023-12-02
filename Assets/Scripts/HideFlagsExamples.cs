using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[AddComponentMenu("Event/MyComponent")]
// this content uses add component menu  settings  under event class under
[AddComponentMenu("HideFlags/MyComponent")]


[RequireComponent(typeof(Rigidbody))]
//to add an extra component
public class HideFlagsExamples : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;

    [Range(1, 6)]
    public int RangeExample;
    // clamp 1 to 6 
    [Min(5)]
    public int RangeExample2;
    // if write lower than 5 its write 5
    [Multiline(7)]
    public string NameSevenLane;
    // 7 line inspector
    [Tooltip("This is my note")]
    public bool Note;
    // ýf mouse on dis  variable show this note

    [Header("PlayerSettings")]
    public string Health;
    public string Money;
    public string Level;
    [Header("EnemySettings")]
    public string Enemy_Health;
    public string Enemy_Money;
    public string Enemy_Level;

    [ContextMenu("My Menu",false,1)]
    [ContextMenu("My Menu",false,2)]
    void MyMenu()
    {
        print("ý am coming from settings");
    }
    // 3 dot clilck and  write  ý am coming from settings
    //false default call   1 or 2 order 

    void Start()
    {
        gameObject.hideFlags = HideFlags.HideInHierarchy;
        // this gameobject hide on start
         gameObject.hideFlags = HideFlags.HideInInspector;
        // this gameobject Inspector hide on start
        gameObject.hideFlags = HideFlags.NotEditable;
        // this gameobject Inspector not edit with start
        gameObject.hideFlags = HideFlags.DontSave;
        // this gameobject dont save changiest bt instiate new gameobject

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
