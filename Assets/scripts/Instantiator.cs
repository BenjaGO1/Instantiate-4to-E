using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text txtCloneAmount;
    public int cloneAmount;

    public void MultiInstantiate()
    {

        cloneAmount = int.Parse(txtCloneAmount.text);
        int counter = 0;
        for (counter = 0; counter < cloneAmount; counter++)
        {
            Instantiate(objectToClone);
        }
    }
}
