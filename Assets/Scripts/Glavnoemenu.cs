using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glavnoemenu : MonoBehaviour
{

    public GameObject ButtonsMenu;
    public GameObject ARGID;
    public GameObject Amurgosy;
    public GameObject Settings;
    public GameObject Profile;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowARGID()
    {
        ButtonsMenu.SetActive(false);
        ARGID.SetActive(true);

    }


    //public void PlanNavig ()
    //{
    //    PlanNavig.SetActive(true)

    //}

    public void ShowAMUR()
    {
        ButtonsMenu.SetActive(false);
        Amurgosy.SetActive(true);

    }

    public void OpenURLMap()
    {
        Application.OpenURL ("https://yandex.ru/maps/77/blagoveshchensk/?from=api-maps&ll=127.511175%2C50.300556&mode=usermaps&origin=jsapi_2_1_76&um=constructor%3ABcJaZlE8DRmYSfvjID2tcmgHwkNux3_r&z=16");
    }

    public void OpenURLEvents()
    {
        Application.OpenURL("https://www.amursu.ru/events/");
    }

    

    public void OpenURLHistory()
    {
        Application.OpenURL("https://www.amursu.ru/about/istoriya-universiteta/");
    }

    public void BackMenu()
    {
        ButtonsMenu.SetActive(true);
        ARGID.SetActive(false);
        Amurgosy.SetActive(false);
        Settings.SetActive(false);
        Profile.SetActive(false);

    }

}
