using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    //DetectClicks

    [SerializeField]
    private TextMeshProUGUI _score;
    [SerializeField]
    private GameObject _secretBird;
    [SerializeField]
    private GameObject _dLore;
    [SerializeField]
    private GameObject _boostText;
    [SerializeField]
    private GameObject _endButton;
    [SerializeField]
    private long coins;

    private long _coinUpdate;
    private bool _canBird = true;

    public int _random;

    public void Start() {
        _coinUpdate = System.Convert.ToInt64(PlayerPrefs.GetString("coinUpdate"));
        if (_coinUpdate == 0)
            _coinUpdate = 1;

        long savedCoins = System.Convert.ToInt64(PlayerPrefs.GetString("coins"));
        coins = savedCoins;
        _score.text = "FOXCOINS: " + savedCoins.ToString();
    }

    public void PlusOneCoin() {
        if (coins >= 10) {
            coins -= 10;
            _coinUpdate++;
        }
    }
    public void PlusTenCoins() {
        if (coins >= 100) {
            coins -= 100;
            _coinUpdate = _coinUpdate + 10;
        }
    }
    public void PlusOneHundredCoins() {
        if (coins >= 1000) {
            coins -= 1000;
            _coinUpdate = _coinUpdate + 100;
        }
    }
    public void PlusThousandCoins() {
        if (coins >= 10000) {
            coins -= 10000;
            _coinUpdate = _coinUpdate + 1000;
        }
    }
    public void PlusTenThousandCoins() {
        if (coins >= 100000) {
            coins -= 100000;
            _coinUpdate = _coinUpdate + 10000;
        }
    }
    public void PlusHundredThousandCoins() {
        if (coins >= 1000000) {
            coins -= 1000000;
            _coinUpdate = _coinUpdate + 100000;
        }
    }
    public void PlusMillionCoins() {
        if (coins >= 1000000000) {
            coins -= 1000000000;
            _coinUpdate = _coinUpdate + 1000000;
        }
    }

    void OnMouseDown() {
        coins += _coinUpdate;
    }

    public void Update() {
        _score.text = "FOXCOINS: " + coins;
        PlayerPrefs.SetString("coins", coins.ToString());
        PlayerPrefs.SetString("coinUpdate", _coinUpdate.ToString());

        if (_canBird == true) {
            _random = Random.Range(1, 100000); //1 from 100,000

            if (_random == 50) {
                StartCoroutine(Bird());
                _secretBird.SetActive(true);
            }
        }
        if (_coinUpdate >= 1000000000) { // if coinUpdate greater or equals one Billion
            _endButton.SetActive(true);
        }
    }

    IEnumerator Bird() { //Easter egg
        _canBird = false;
        yield return new WaitForSeconds(7);
        _boostText.SetActive(true);
        _dLore.SetActive(true);
        _secretBird.SetActive(false);
        _coinUpdate += 1000;
    }
}
