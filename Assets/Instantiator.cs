using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject objectToClone;
    public int cont;
    public void CloneObject()
    {
       
       while(cont > 0)
        {
            Instantiate(objectToClone);
            cont--;
        }
        
    }
}
