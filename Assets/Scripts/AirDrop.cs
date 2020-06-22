using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop : MonoBehaviour
{
    public GameObject placedPrefab;
    public GameObject Camera;
    bool _spawned = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (_spawned == false)
        {
            if (Application.isEditor)
            {
                if (Input.GetMouseButton(0))
                {
                    SpawnPrefab();
                    _spawned = true;
                    StartCoroutine("Pause");
                }

            }
            else
            {
                if (Input.touchCount > 0)
                {
                    SpawnPrefab();
                    _spawned = true;
                    StartCoroutine("Pause");
                }

            }

        }
}

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(5);
        _spawned = false;
        Debug.Log("_spawned = false");
    }

    public void SpawnPrefab()
    {
        float spawnDistance = Random.Range(0.1f,1f);
        Vector3 camPos = Camera.transform.position;
        Vector3 camForward = Camera.transform.forward;
        Vector3 spawnPos = camPos + camForward * spawnDistance;
        GameObject spawnedObject = Instantiate(placedPrefab, spawnPos, Camera.transform.rotation);
        
    }
}
