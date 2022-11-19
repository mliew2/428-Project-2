using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObj : MonoBehaviour
{
    public GameObject obj;

    void Start() {
        obj.SetActive(false);
    }

    IEnumerator OnTriggerEnter(Collider other){
        obj.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        obj.SetActive(false);
    }
}
