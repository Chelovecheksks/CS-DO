using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    void Start()
    {
        GetComponentInChildren<MeshRenderer>().gameObject.SetActive(false);
    }
}
