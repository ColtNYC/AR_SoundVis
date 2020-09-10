using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RaycastIntersection : MonoBehaviour
{
    private ARRaycastManager aRRaycastManager;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private Transform hitTransform;

    public Transform intersectionTransform
    {
        get { return hitTransform; }
        
    }

    public bool TryGetTouchPosition()
    {
        if (Input.touchCount > 0)
        {
            return true;
        }
        return false;
    }

    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aRRaycastManager.Raycast(Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2)), hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            hitTransform.position = hitPose.position;
            hitTransform.rotation = hitPose.rotation;

        }
    }
}
