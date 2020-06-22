using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Provider;


[RequireComponent(typeof(ARSessionOrigin))]
public class PlaceObjectOnGround : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Копия объекта размещается на плоскости в месте прикосновения")]
    GameObject m_PlacedPrefab;

    public GameObject placedPrefab
    {
        get { return m_PlacedPrefab; }
        set { m_PlacedPrefab = value; }
    }

    public GameObject spawnedObject { get; private set; }

    ARSessionOrigin m_SessionOrigin;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();
    bool _spawned = false;
    void Awake()
    {
        m_SessionOrigin = GetComponent<ARSessionOrigin>();
    }

    void Update()
    {
        if (_spawned == false)
        {
            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);

                //if (m_SessionOrigin.Raycast(touch.position, s_Hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = s_Hits[0].pose;

                    if (spawnedObject == null)
                    {
                        spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
                    }
                    else
                    {
                        //Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
                    }
                }
                _spawned = true;
                StartCoroutine("Pause");
            }
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(5);
        _spawned = false;
        Debug.Log("_spawned = false");
    }
}
