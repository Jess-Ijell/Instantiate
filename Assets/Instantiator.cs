using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CantDeClones;

    public void CloneObject()
    {
        while (CantDeClones > 0)
        {
            Instantiate(objectToClone);
            CantDeClones--;
        }
    }
}
