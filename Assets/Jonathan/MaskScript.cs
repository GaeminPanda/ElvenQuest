using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskScript : MonoBehaviour
{


    public void MoveMask(int currentVal, int maxVal)
    {
        Debug.Log("Move mask");
        float percentToMove = (float)currentVal / (float)maxVal;
        transform.localPosition = new Vector3(percentToMove - 1, 0, 0);
    }
}
