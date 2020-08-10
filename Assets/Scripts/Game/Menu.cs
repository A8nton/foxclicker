using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    [SerializeField]
    private GameObject _uiMenu;
    [SerializeField]
    private GameObject _menu;

    public bool _isMenuActive;

    public void OnClick(string game) {
        if (_isMenuActive == false) {
            _isMenuActive = true;
            _menu.SetActive(true);
            _uiMenu.SetActive(true);
        }
        else if (_isMenuActive == true) {
            _isMenuActive = false;
            _menu.SetActive(false);
            _uiMenu.SetActive(false);
        }

    }
}
