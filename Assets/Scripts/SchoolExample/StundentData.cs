using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StundentData : MonoBehaviour
{
    School SchoolClass= new School();
    void Start()
    {
        SchoolClass.GetAllAndSchoolName("Odt�",47,1500f,"Jessy","Jack");
    }
   
}
