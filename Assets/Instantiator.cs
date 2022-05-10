using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject objectToClone;
    public int cont;
    public void CloneObject()
    {
        int num = cont;
       while(num > 0)
        {
            Instantiate(objectToClone);
            num--;
        }
        
    }
}
