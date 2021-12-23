using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hangar : MonoBehaviour
{
    public int number = 0;

    public TextMeshPro HangarNumberDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetNumberInTextMesh()
    {
        HangarNumberDisplay.text = number.ToString();
    }
}
