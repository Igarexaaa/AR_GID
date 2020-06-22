using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPS : MonoBehaviour
{
    public static GPS Instance { set; get; }

    public float latitude;
    public float longitude;

    public Text GPS_debug;
    
    private void Start()
    {
        GPS_debug.text = "Start";
        Instance = this;
        GPS_debug.text = "Instantce";
        DontDestroyOnLoad(gameObject);
        GPS_debug.text = "Dont destroy";
        StartCoroutine(StartLocationService());

    }

    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            GPS_debug.text = "User has not enable GPS";
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            GPS_debug.text = "Time out";
            yield break;
        }
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            GPS_debug.text = "Unable to determin device location";
            yield break;
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        yield break;
    }

    void Update()
    {
        
    }

}
