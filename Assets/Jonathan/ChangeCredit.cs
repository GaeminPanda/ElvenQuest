using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCredit : MonoBehaviour
{

    public GameObject ActiveCanvas;
    public GameObject SetActiveCanvas;


    public void OnClickName()
    {
        ActiveCanvas.SetActive(false);
        SetActiveCanvas.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
