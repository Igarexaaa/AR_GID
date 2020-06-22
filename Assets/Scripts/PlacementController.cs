using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARRaycastManager))]
public class PlacementController : MonoBehaviour
{

    [SerializeField]
    private GameObject placedPrefab;
    [SerializeField]
    private GameObject placementIndicator;
    public GameObject PlacedPrefab
    {
        get
        {
            return placedPrefab;
        }
        set
        {
            placedPrefab = value;
        }
    }

    private ARRaycastManager arRaycastManager;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;

        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;
 
            //var hitPose = hits[0].pose;
            //placementIndicator.transform.position = hitPose.position;
            //placementIndicator.transform.rotation = hitPose.rotation;
        
        if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;
            placedPrefab.transform.position = hitPose.position;
            placedPrefab.transform.rotation = Quaternion.Euler(hitPose.rotation.eulerAngles.x, hitPose.rotation.eulerAngles.y - 180, hitPose.rotation.eulerAngles.z);
            placedPrefab.GetComponent<AudioSource>().enabled = true;
        }
    }


    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}