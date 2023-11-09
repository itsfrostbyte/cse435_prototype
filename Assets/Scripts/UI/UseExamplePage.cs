using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseExamplePage : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform buttonsParent;

    [SerializeField] private int exampleSceneCount;

    private void OnEnable()
    {
        foreach(Transform button in buttonsParent)
        {
            Destroy(button.gameObject);
        }

        for (int i = 1; i <= exampleSceneCount; i++)
        {
            GameObject button = Instantiate(buttonPrefab, buttonsParent);
            button.GetComponent<UseExampleButton>().Init(this, i);
        }
        
        
    }

    public void OnButtonClicked(int num)
    {
        SceneManager.LoadScene(num.ToString());
    }
}
