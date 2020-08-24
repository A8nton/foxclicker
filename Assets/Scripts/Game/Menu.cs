using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    //Main Camera

    [SerializeField]
    private GameObject _buttonFirst;
    [SerializeField]
    private GameObject _buttonSecond;
    [SerializeField]
    private GameObject _buttonThird;
    [SerializeField]
    private GameObject _buttonFourth;
    [SerializeField]
    private GameObject _buttonFifth;
    [SerializeField]
    private GameObject _buttonSix;
    [SerializeField]
    private GameObject _buttonSeven;

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
            _buttonFirst.SetActive(true);
            _buttonSecond.SetActive(true);
            _buttonThird.SetActive(true);
            _buttonFourth.SetActive(true);
            _buttonFifth.SetActive(true);
            _buttonSix.SetActive(true);
            _buttonSeven.SetActive(true);
        }
        else if (_isMenuActive == true) {
            _detectClicks.transform.position = new Vector3(0.34f, 0.54f, -7.39f);
            _isMenuActive = false;
            _menu.SetActive(false);
            _buttonFirst.SetActive(false);
            _buttonSecond.SetActive(false);
            _buttonThird.SetActive(false);
            _buttonFourth.SetActive(false);
            _buttonFifth.SetActive(false);
            _buttonSix.SetActive(false);
            _buttonSeven.SetActive(false);
        }

    }
}
