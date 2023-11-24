using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TransFormObjects : MonoBehaviour
{
    // Start is called before the first frame update
    //  public Vector3 a; // usually  use shadow effect 
    // static methods
    public Transform Target;
    public Transform Target2;
    private float _timer;
    public Transform Parent;
    public GameObject Child;
    void Start()
    {
        ////Vector3 distance=Target.position - Target2.position;
        ////float angle=Vector3.Angle(distance, transform.forward);
        ////Debug.Log(angle);
        //_timer = Time.time;
        //// this method give game play time timer
        //_timer = Time.deltaTime;
        //// this method run per frame time
        //Vector3 firstPos = new Vector3(4f, 2f, 5f);
        //Vector3 secandPos = new Vector3(2f, 5f, 1f);
        //Debug.Log(Vector3.Min(firstPos, secandPos));
        //// 2f,2f,1f
        //Debug.Log(Vector3.Max(firstPos, secandPos));
        //// 4f,5f,5f
        //Debug.Log(Vector3.Scale(firstPos, secandPos));
        //// multi two vector 3
        ///

        //Target.transform.Rotate(90f, 0f, 0f, Space.Self);
        //Target2.transform.Rotate(90f, 0f, 0f, Space.World);
        //Debug.Log(transform.childCount);
        //// if have 2 child  : 2
        //Debug.Log(transform.hierarchyCount);
        // if have 2 child : 3 ;
        transform.rotation=Quaternion.Euler(90f,0,0);
        // first rotate x than y than z
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
        // self rotation 
       // Quaternion.identity;
        // if rotate is active this method run and deactive new vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0f,0f,-1f)*Time.deltaTime);
        //// EQUALS 
        //transform.Translate(Vector3.back * Time.deltaTime);
        // if dont write time deltatime this object so fast move;
        //this method should use with update
        //   Debug.Log(Vector3.Magnitude(transform.position));
        // X,Y,Z CORDÝNANTsum  example x 5 y 2  z 4  magnitude: 11
        //   Debug.Log(Vector3.SqrMagnitude(transform.position));
        // example  vector 3 (0,2,0) = 4
        //  Debug.Log(transform.position.normalized);
        // returns all values between 1 and 0
        //if (Equals(a, Vector3.zero))
        //    // 2 object value control equals?
        //    // equals this method
        //  //  if(a==Vector3.zero)

        //    Debug.Log("yes");
        //else
        //    Debug.Log("no");


        //Vector3 distance = Target.position - Target2.position;
        //float angle = Vector3.Angle(distance, transform.up);
        //Debug.Log(angle);


        //float a= Vector3.Distance(Target2.position, Target.position);
        //   Debug.Log(a);
        //   // distance witch to objects
        // Time.timeScale = 0.5f;
        // game slowly;
        //  transform.position = Vector3.Lerp(Target.position, Target2.position,(Time.time-_timer)*.4f);
        // object  start tarnget position and slowly move target2 position

        //Target.transform.Rotate(2f, 4f, 1f, Space.Self);
        //Target2.transform.Rotate(2f, 4f, 1f, Space.World);
        //Target.transform.LookAt(Target2);
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    Debug.Log(transform.GetChild(i).name);
        //}
        //Child.transform.SetParent(Parent,false);
        //// false child cordinat not chancing 
        ////
        ///

        Vector3 distance = Target.position - Target2.position;
      Target2.transform.rotation = Quaternion.LookRotation(distance, Vector3.up);
        float angle=Quaternion.Angle(Target2.rotation, Target.rotation);
        print(angle);
        // this method look like looak at method bu this method correctly than

        Target2.rotation = Quaternion.Inverse(Target.rotation);
        // target2 rotation = tartget rotation  *-1 this method mirror

    }
}
