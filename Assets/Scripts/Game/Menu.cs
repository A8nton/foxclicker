using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    //Main Camera

    [SerializeField]
    private GameObject _uiMenu;
    [SerializeField]
    private GameObject _menu;
    [SerializeField]
    private GameObject _detectClicks;

    public bool _isMenuActive;

    public void OnClick(string game) {
        if (_isMenuActive == false) {
            _detectClicks.transform.position = new Vector3(100, 100, 100);
            _isMenuActive = true;
            _menu.SetActive(true);
            _uiMenu.SetActive(true);
        }
        else if (_isMenuActive == true) {
            _detectClicks.transform.position = new Vector3(0.34f, 0.54f, -7.39f);
            _isMenuActive = false;
            _menu.SetActive(false);
            _uiMenu.SetActive(false);
        }

    }
}
