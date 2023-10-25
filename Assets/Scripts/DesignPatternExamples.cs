using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPatternExamples : MonoBehaviour
{
    // Start is called before the first frame update
    string deger1 = "Kag�t";
    string deger2 = "Makas";

    string HouseType;
    string BlokType;
    int PercentageofRent=2;

    private int _gold;

    private int _diamond { get; set;}
    // bu iki method ayn�d�r 
    public int Diamond
    {
        get
        {
                return _diamond;
        }
        set
        {

            _diamond = value;
        }
    }

    public int Gold
    {
        // buralara private ekleyerek get ve seti k�s�tlayabliriz 
        get
        {
            if(_gold <= 50)
                 return _gold;
            else
                return _diamond;
        }
        set
        {
            _diamond = _diamond + 2;
            _gold = value+AddValue(3);
        }
    }
    int AddValue(int value)
    {
        return 3*value;
    }
    void Start()
    {
        #region Chain Arrays
        string[][] cars = new string[3][];
        cars[0]=new string[] {"Bmw","Audi","Seat"};
        cars[1] = new string[] { "2010", "2011", "2005","2031"};
        cars[2] = new string[] { "140hp", "300hp", "90hp" };
        Debug.Log(cars[0][1]);
        Debug.Log(cars[1][1]);
        Debug.Log(cars[2][2]);
        // burada sonus audi , 2011 ,90hp c�k�cak
        #endregion
        #region Tas Kag�t Makas Pattern Example
      
        #region Tas Kag�t Makas Yanl�� Kullan�m
        if (deger1 == "Tas" && deger2 == "Kag�t")
            Debug.Log("Kag�t kazand�");
        else if (deger1 == "Tas" && deger2 == "Makas")
            Debug.Log("Tas kazand�");
        else if (deger1 == "Kag�t" && deger2 == "Tas")
            Debug.Log("Ka��t kazand�");
        else if (deger1 == "Kag�t" && deger2 == "Makas")
            Debug.Log("Makas kazand�");
        else if (deger1 == "Makas" && deger2 == "Kag�t")
            Debug.Log("Makas kazand�");
        else if (deger1 == "Makas" && deger2 == "Tas")
            Debug.Log("Tas kazand�");
        else
            Debug.Log("draw");
        #endregion
        #region Tas Kag�t Makas Avarage Kullan�m
        switch (deger1)
        {
            case "Tas":
                if (deger2 == "Kag�t")
                    Debug.Log("Kag�t win");
                if (deger2 == "Makas")
                    Debug.Log("Tas win");
                break;
            case "Kag�t":
                if (deger2 == "Tas")
                    Debug.Log("Kag�t win");
                if (deger2 == "Makas")
                    Debug.Log("Makas win");
                break;
            case "Makas":
                if (deger2 == "Tas")
                    Debug.Log("Tas win");
                if (deger2 == "Kag�t")
                    Debug.Log("Makas win");
                break;
            default:
                Debug.Log("draw");
                break;


        }
        #endregion
        #region Tas Kag�t Makas Dogru Kullan�m
        string taskag�tmakas(string deger1, string deger2) => (deger1, deger2) switch
        {
            ("Tas", "Kag�t") => "Kag�t win",
            ("Kag�t", "Tas") => "Kag�t win",
            ("Kag�t", "Makas") => "Makas win",
            ("Makas", "Kag�t") => "Makas win",
            ("Makas","Tas") => "Tas win",
            ("Tas","Makas") => "Tas win",
            ("Tas", "Tas") => "draw",
            ("Makas", "Makas") => "draw",
            ("Kag�t", "Kag�t") => "draw",
            (_,_)=> "Degerler hatal�"
        };
        Debug.Log(taskag�tmakas("Kag�t", "Makas"));
        #endregion
        #endregion
        #region Property Pattern Example

        #region HouseRent Wrong Method

        HouseType = "Villa";

        if (HouseType == "Apartment")
            Debug.Log(PercentageofRent * 1.5f);
        else if (HouseType == "Villa")
            Debug.Log(PercentageofRent * 2.5f);
        else if (HouseType == "Residence")
            Debug.Log(PercentageofRent * 3.5f);
        else
            Debug.Log("incorrect writing");
        #endregion
        #region HouseRent Avarage Method
        
        switch(HouseType)
        {
            case "Apartment":
                Debug.Log(PercentageofRent * 1.5f);
                break;
            case "Villa":
                Debug.Log(PercentageofRent * 2.5f);
                break;
            case "Residence":
                Debug.Log(PercentageofRent * 3.5f);
                break;
            default:
                Debug.Log("incorrect writing");
                break;
        }
        #endregion
        #region HouseRent True Method
        int HouseRentCalculator(DesignPatternExamples myMethod,int PercentageofRent)
            => myMethod switch
            {
                { HouseType:"Apartment",BlokType:"A"} =>PercentageofRent * (int)1.5,
                { HouseType:"Villa", BlokType: "B" } => PercentageofRent * (int)2.5,
                { HouseType:"Residence", BlokType: "D" } => PercentageofRent * (int)3.5,
                _=> 0
            };
        HouseType = "Villa";
        BlokType = "B";
        Debug.Log(HouseRentCalculator(this, 2));

        #endregion

        #endregion
        #region Get & Set Gold Example

        Gold=20; // set 
       Debug.Log(Gold); // get


        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
