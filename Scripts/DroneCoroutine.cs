using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCoroutine : MonoBehaviour
{
    [SerializeField]
    private int FreezTime;

    private void Start()
    {
        StartCoroutine(DroneFly());
    }

   IEnumerator DroneFly()
    {
        yield return new WaitForSeconds(FreezTime);
        GetComponent<Animation>().Play("Drone fly back");
    }
}
