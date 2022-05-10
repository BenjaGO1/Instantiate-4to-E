using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text txtCloneAmount;
    public int cloneAmount;
    GameObject clon;
    public void MultiInstantiate()
    {

        cloneAmount = int.Parse(txtCloneAmount.text);
        int counter = 0;
        for (counter = 0; counter < cloneAmount; counter++)
        {
            clon=Instantiate(objectToClone);
            Destroy(clon, 1);
        }
    }
}
