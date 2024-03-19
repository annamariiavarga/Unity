using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vectorA = new Vector3(1, -3, 7);
        Vector3 vectorB = new Vector3(2, 8, -6);
        float scalarProduct = Vector3.Dot(vectorA, vectorB);
        Debug.Log("—кал€рний добуток вектор≥в: " + scalarProduct);

    }

    // Update is called once per frame








}