using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyManager;
using PointControll;

public class NameSpaceMainFile : MonoBehaviour
{
    // Start is called before the first frame update
   Enemy enemy = new Enemy();
   PointControllClass point = new PointControllClass();
  
    void Start()
    {
        enemy.EnemyHealth(10);
        point.Controll("example");
    }
}
