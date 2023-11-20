using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleSceneManager : MonoBehaviour
{
    public static ExampleSceneManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] public GameObject scenarioEndText;
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ScenarioEnd()
    {
        scenarioEndText.SetActive(true);
    }
}
