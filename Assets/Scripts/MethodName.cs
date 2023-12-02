using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodName : MonoBehaviour
{
    // Start is called before the first frame update
    private string Name = "Fýrat";
    private string Name2 = "Akif";
   // ctrl +d copy paste 
    void Start()
    {
        print(Name.GetType());
        // give type  which variable

        string Copy=(string)Name.Clone();
        // Copy="Fýrat";

        if(Name.Equals("Akif"))
            print("yes");
        else
            print("no");
        // no   
        //We checked whether the string expression contains
        if (Name.EndsWith("at"))
            print("yes");
        else
            print("no");
        // yes 
        //The string that says controls how the expression ends.
        if (Name.StartsWith("at"))
            print("yes");
        else
            print("no");
        // no
        //The string that says controls how the expression start.

        string letter = "have a nice day";
        print(letter.ToUpper());
        // prints all letters in uppercase
        print(letter.ToUpper());
        string letter2 = "    have a nice day";
        // prints all letters in Lowercase
        print(letter2.Replace(" ", "."));
        //"have.a.nice.day"
        // chance  space to dot
        print(letter2.Trim());
        //"have a nice day"
        //removes spaces at the beginning and end of text
        print(letter2.TrimStart());
        //removes spaces at the beginning of text
        print(letter2.TrimEnd());
        //removes spaces at the end of text
        print(letter2.Substring(2,5));
        //ve a ni
        string[] separate= letter.Split(' ');
        foreach(string s in separate)
        {
            print(s);
        }
        //have
        //a
        //nice
        //day

        // We divided the sentence into words starting from the spaces
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
