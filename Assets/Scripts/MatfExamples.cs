using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MatfExamples : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Mathf.Abs(-2.5f));
        //// =2.5f;
        //Debug.Log(Mathf.Ceil(5.0f));
        //// 5.0
        //Debug.Log(Mathf.Ceil(5.2f));
        //// 6.0
        //Debug.Log(Mathf.Ceil(5.7f));
        ////6.0
        //Debug.Log(Mathf.Ceil(-5.0f));
        ////-5.0
        //Debug.Log(Mathf.Ceil(-5.2f));
        ////-5.0

        ////it always rounds to the higher number

        //Debug.Log(Mathf.Floor(5.0f));
        //// 5.0
        //Debug.Log(Mathf.Floor(5.2f));
        //// 5.0
        //Debug.Log(Mathf.Floor(5.7f));
        ////5.0
        //Debug.Log(Mathf.Floor(-5.0f));
        ////-5.0
        //Debug.Log(Mathf.Floor(-5.2f));
        ////-6.0

        ////it always rounds to the lower number

        //Debug.Log(Mathf.Round(5.0f));
        //// 5.0
        //Debug.Log(Mathf.Round(5.2f));
        //// 5.0
        //Debug.Log(Mathf.Round(5.7f));
        ////6.0
        //Debug.Log(Mathf.Round(-5.0f));
        ////-5.0
        //Debug.Log(Mathf.Round(-5.2f));
        ////-5.0


        //it always rounds to the near number
        Debug.Log(Mathf.Round(5.5f));
        //6.0
        Debug.Log(Mathf.Round(-5.5f));
        //-6.0
        // if the value after the comma is 0.5, it rounds to the nearest even number
        float health = -5;
        print(Mathf.Clamp(health,1,100));
        //1
        health = 105;
        //100
        //limits of number values



        health = -5;
        print(Mathf.Clamp01(health));
        //0
        health = 44;
        //1

        //if the value is negative, 0 gives the result 1 if it is positive

        print(Mathf.Max(3.1f, 4.8f, -3.5f));
        //4.8f
        //  Decrypts the largest of the given values

        print(Mathf.Min(3.1f, 4.8f, -3.5f));
        //-3.5f
        // Decrypts the smallest  of the given values
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
