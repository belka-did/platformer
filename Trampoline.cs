using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
        //повышение силы прышка// 
    {other.GetComponent<Jump>().jumpStrength=11; 
        
    }

    void OnTriggerExit(Collider other)
    //уменшение прышка// 
    {

     other.GetComponent<Jump>().jumpStrength=2;   
    }
}
