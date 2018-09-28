using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    public bool ifbool;
    public int Value;

    // != inte lika med
    // == lika med
    // > större än
    // < mindre än
    // >= större eller lika med
    // <= mindre eller lika med
    // && och (shift 6)
    // || eller (altgr <)
    
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //print("Du vidrörde knappen");
            Value = Random.Range(0, 10);
            print("egentligen varför lever människor");
        }


        //if (ifbool == true)
        //{
        //    print("ja");
        //}
        //else
        //{
        //    print("Nej");
        //}

        //if (Value == 4)
        //{
        //    print("GODKÄNN");
        //}
        //else if (Value == 3)
        //{
        //    print("tjena");
        //}
        //else
        //{
        //    print("gud");
        //}

        //if (ifbool == true && Value != 100)
        //{
        //    print("why though?");
        //}
    }
}
