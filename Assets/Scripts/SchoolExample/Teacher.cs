using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : Student
{
    public string Name;
    protected void GiveStudentAndTeacherName(string teacherName , string studentName)
    {
        GiveStudentName(studentName);
        Debug.Log("Teacher Name: "+teacherName);
    }
}
