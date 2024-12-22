using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class VRtest1 : MonoBehaviour
{
    public GameObject cube;
    public void ClickButton()
    {
        cube.SetActive(!(cube.activeSelf));
    }
}