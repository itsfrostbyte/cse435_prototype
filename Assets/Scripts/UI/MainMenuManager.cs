using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance;

    private GameObject activePage;

    private void Awake()
    {
        Instance = this;
    }

    public void EnablePage(GameObject page)
    {
        activePage = page;
        page.SetActive(true);
    }

    public void ClosePage()
    {
        activePage.SetActive(false);
    }


}
