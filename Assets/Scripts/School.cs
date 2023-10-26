using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : Teacher
{
    public void GetAllAndSchoolName( string schoolname,int old,float salary,string teacherName,string studentName)
    {
        GiveStudentAndTeacherName(teacherName, studentName);
        Debug.Log("School Name:"+schoolname+"Old: "+old+ "Salary:"+ salary);
    }

}
