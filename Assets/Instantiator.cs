using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CantDeClones;

    public void CloneObject()
    {
        int cant = 0;
        while (CantDeClones > cant)
        {
            Instantiate(objectToClone);
            cant++;
        }
    }
}
