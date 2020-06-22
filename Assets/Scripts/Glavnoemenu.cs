using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glavnoemenu : MonoBehaviour
{

    public GameObject GlMenu;
    public GameObject GGlMenuEn;
    public GameObject ARGID;
    public GameObject AARGIDEn;
    public GameObject Amurgosy;
    public GameObject AAmurgosyEn;
    public GameObject En;
    public GameObject Ru;
    public GameObject Chi;
    public GameObject Profile;
    public GameObject amursu;



    public void ShowARGID()
    {
        GlMenu.SetActive(false);
        ARGID.SetActive(true);

    }
    public void ShowARGIDEN()
    {
        GGlMenuEn.SetActive(false);
        AARGIDEn.SetActive(true);

    }

    public void GlmenuRu()
    {
        GlMenu.SetActive(true);
        En.SetActive(true);
        GGlMenuEn.SetActive(false);
        ARGID.SetActive(false);
        Amurgosy.SetActive(false);        
        Ru.SetActive(false);
        Chi.SetActive(false);
        Profile.SetActive(false);
        GGlMenuEn.SetActive(false);
        AARGIDEn.SetActive(false);
        AAmurgosyEn.SetActive(false);

    }

    public void GlmenuEn()
    {
        GGlMenuEn.SetActive(true);
        GlMenu.SetActive(false);               
        ARGID.SetActive(false);
        Amurgosy.SetActive(false);
        En.SetActive(false);
        Ru.SetActive(true);
        Chi.SetActive(true);
        Profile.SetActive(false);        
        AARGIDEn.SetActive(false);
        AAmurgosyEn.SetActive(false);
    }


    public void ShowAMUR()
    {
        GlMenu.SetActive(false);
        Amurgosy.SetActive(true);

    }
    public void ShowAMUREN()
    {
        GGlMenuEn.SetActive(false);
        AAmurgosyEn.SetActive(true);

    }

    public void OpenURLAmursu()
    {
        Application.OpenURL("https://www.amursu.ru/");
    }

    public void OpenURLHistory()
                {
                    Application.OpenURL("https://www.amursu.ru/about/istoriya-universiteta/");
                }
                public void OpenURLMesto()
                {
                    Application.OpenURL ("https://yandex.ru/maps/77/blagoveshchensk/?from=api-maps&ll=127.511175%2C50.300556&mode=usermaps&origin=jsapi_2_1_76&um=constructor%3ABcJaZlE8DRmYSfvjID2tcmgHwkNux3_r&z=16");
                }

                public void OpenURLEvent()
                {
                    Application.OpenURL("https://www.amursu.ru/events/");
                }

    
                public void OpenURLHistoryen()
                {
                    Application.OpenURL("https://translate.google.com/translate?hl=&sl=ru&tl=en&u=https%3A%2F%2Fwww.amursu.ru%2Fabout%2Fistoriya-universiteta%2F&sandbox=1");
                }
                public void OpenURLMestoen()
                {
                    Application.OpenURL("https://yandex.com/maps/77/blagoveshchensk/?from=api-maps&ll=127.511175%2C50.300556&mode=usermaps&origin=jsapi_2_1_76&um=constructor%3ABcJaZlE8DRmYSfvjID2tcmgHwkNux3_r&z=16");
                }

                public void OpenURLEventen()
                {
                    Application.OpenURL("https://translate.google.com/translate?hl=&sl=ru&tl=en&u=https%3A%2F%2Fwww.amursu.ru%2Fevents%2F");
                }


    public void BackMenu()
    {
        GlMenu.SetActive(true);
        ARGID.SetActive(false);
        Amurgosy.SetActive(false);
        Profile.SetActive(false);
    }
    public void BackMenuEN()
    {
        GGlMenuEn.SetActive(true);
        GlMenu.SetActive(false);
        AARGIDEn.SetActive(false);
        ARGID.SetActive(false);
        AAmurgosyEn.SetActive(false);
        Profile.SetActive(false);
    }


    public void Exit ()
    {
        Application.Quit();
    }

}
