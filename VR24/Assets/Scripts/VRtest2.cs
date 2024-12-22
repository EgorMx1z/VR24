using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VRtest2 : MonoBehaviour
{
    public int z = 7;
    public Text Mytxt;
    public void OnCollisionEnter(Collision collision)
    {
        z--;
        Mytxt.text = z.ToString();
    }
}
