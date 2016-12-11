using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;


public class UI_MouseOverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject objSubMenu;
    public Button btnMenu;

    void Awake()
    {
        objSubMenu.SetActive(false);
        btnMenu.onClick.AddListener(ToggleSubMenu);
    }

    void ToggleSubMenu()
    {
        objSubMenu.SetActive(!objSubMenu.activeSelf);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        objSubMenu.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        objSubMenu.SetActive(false);
    }
}
