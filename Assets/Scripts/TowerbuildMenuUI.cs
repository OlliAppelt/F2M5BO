using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerbuildMenuUI : MonoBehaviour
{
    [SerializeField] private RectTransform _menuPanel;

    private void Start()
    {
        Show(false);
    }

    public void Show(bool enabled)
    {
        _menuPanel.gameObject.SetActive(enabled);
    }
}
