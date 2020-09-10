using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedGetIntersection : MonoBehaviour
{
    public RaycastIntersection raycastIntersection;

    public float seconds = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimedIntersection());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TimedIntersection()
    {
        yield return new WaitForSeconds(seconds);
        Transform intersection = raycastIntersection.intersectionTransform;
        

    }
}
