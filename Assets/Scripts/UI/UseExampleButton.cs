using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using TMPro;

public class UseExampleButton : MonoBehaviour
{
    private int num;
    [SerializeField] private TMP_Text sceneNameText;

    private UseExamplePage page;

    public void Init(UseExamplePage page, int num)
    {
        this.num = num;
        this.page = page;
        sceneNameText.text = "Example " + num.ToString();
    }

    public void ClickedButton()
    {
        page.OnButtonClicked(num);
    }
}
