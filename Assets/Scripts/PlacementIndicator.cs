using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    public GameObject objectToPlace;
    public GameObject placementIndicator;

    private ARSessionOrigin _arOrigin;
    private Pose _placementPose;
    private bool _placementPoseIsValid = true;
    private bool _active_GIT_obj = false;

    List<ARRaycastHit> hitResults = null;
    void Start()
    {
        _arOrigin = FindObjectOfType<ARSessionOrigin>();

        //if (_arOrigin == null)
        //{
        //   // Debug.Log("AR Session Origin object not found!");
        //}
    }

    void Update()
    {
        //UpdatePlacementPose();
        UpdatePlacementIndticator();

        if ( Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            PlaceObject();
        }

    }
    public void SetObjectGid(GameObject _gid)
    {
        objectToPlace.SetActive(false);
        _gid.SetActive(true);
        objectToPlace = _gid;

    }

    private void PlaceObject()
    {
        
            //if (!_active_GIT_obj)
        {
            //objectToPlace.SetActive(true);
            objectToPlace.transform.position = _placementPose.position;
            objectToPlace.transform.rotation = Quaternion.Euler(_placementPose.rotation.eulerAngles.x, _placementPose.rotation.eulerAngles.y - 180, _placementPose.rotation.eulerAngles.z);
            //Instantiate(objectToPlace, _placementPose.position, Quaternion.Euler(_placementPose.rotation.eulerAngles.x, _placementPose.rotation.eulerAngles.y - 180, _placementPose.rotation.eulerAngles.z));
            //_active_GIT_obj = true;
        }
        //else
        //{
        //    Destroy(GameObject.FindGameObjectWithTag("GID"));
        //    _active_GIT_obj = false;
        //}
    }


    private void UpdatePlacementIndticator()
    {
        
        //UnityEngine.XR.ARSubsystems.TrackableType trackableTypeMask = UnityEngine.XR.ARSubsystems.TrackableType.All;
        //float pointCloudRaycastAngleInDegrees;
        //GetComponent<ARRaycastManager>().Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)), hitResults, trackableTypeMask);
        //if (_placementPoseIsValid) //&& !_active_GIT_obj)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(_placementPose.position, _placementPose.rotation);
        }
        //else
        {
            //placementIndicator.SetActive(false);
            // Debug.Log("Not found place for navigate!");
        }
    }

    //private void UpdatePlacementPose()
    //{
    //    var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
    //    var hits = new List<ARRaycastHit>();
    //    _arOrigin.camera.Ray  Raycast(screenCenter, hits, TrackableType.Planes);

    //    _placementPoseIsValid = hits.Count > 0;
    //    if (_placementPoseIsValid)
    //    {
    //        _placementPose = hits[0].pose;

    //        var cameraForward = Camera.current.transform.forward;
    //        var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
    //        _placementPose.rotation = Quaternion.LookRotation(cameraBearing);
    //    }
    //}
}
