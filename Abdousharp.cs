using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abdousharp : MonoBehaviour
{
     public int A , B;
    int C;
    void start()
    {

        float C;
        C = A + B;
        Debug.Log ("the result is = " + C + " this is a");
        C = A - B;
        Debug.Log ("the result is = " + C + " this is b ");
        C = A * B;
        Debug.Log ("the result is = " + C + " this is c  ");
        C = A % B;
        Debug.Log ("the result is = " + C + " this is  d ");
    }
    // Update is called once per frame
    void Update()
    {

    }

}




