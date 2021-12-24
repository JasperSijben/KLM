using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hangar : MonoBehaviour
{
    public int number = 0;

    public TextMeshPro HangarNumberDisplay;

    public void SetNumberInTextMesh()
    {
        HangarNumberDisplay.text = number.ToString();
    }
}
