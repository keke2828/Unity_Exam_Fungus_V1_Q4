using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public Camera ca;
    public Vector3[] po;

    public void moveca(int i)
    {
        ca.transform.position = po[i];
    }

}
