using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    //DetectClicks

    [SerializeField]
    private Text _score;
    [SerializeField]
    private GameObject _secretBird;
    [SerializeField]
    private GameObject _dLore;
    [SerializeField]
    private GameObject _boostText;
    [SerializeField]
    private GameObject _endButton;

    public int coinUpdate;
    public int coins;
    public int _random;

    private bool _canBird = true;

    public void Start() {
        coinUpdate = PlayerPrefs.GetInt("coinUpdate");
        int savedCoins = PlayerPrefs.GetInt("coins");
        coins = savedCoins;
        _score.text = "FOXCOINS: " + savedCoins.ToString();
    }

    public void PlusOneCoin() {
        if (coins >= 10) {
            coins -= 10;
            coinUpdate++;
        }
    }
    public void PlusTenCoin() {
        if (coins >= 100) {
            coins -= 100;
            coinUpdate = coinUpdate + 10;
        }
    }
    public void PlusOneHundredCoin() {
        if (coins >= 1000) {
            coins -= 1000;
            coinUpdate = coinUpdate + 100;
        }
    }
    public void PlusThouthantCoin() {
        if (coins >= 10000) {
            coins -= 10000;
            coinUpdate = coinUpdate + 1000;
        }
    }
    public void PlusTenThouthentCoin() {
        if (coins >= 100000) {
            coins -= 100000;
            coinUpdate = coinUpdate + 10000;
        }
    }
    public void PlusHundredThouthentCoin() {
        if (coins >= 1000000) {
            coins -= 1000000;
            coinUpdate = coinUpdate + 100000;
        }
    }
    public void PlusMillionCoin() {
        if (coins >= 1000000000) {
            coins -= 1000000000;
            coinUpdate = coinUpdate + 100000000;
        }
    }

    void OnMouseDown() {
        coins += coinUpdate;
    }

    public void Update() {
        _score.text = "FOXCOINS: " + coins;
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("coinUpdate", coinUpdate);

        if (_canBird == true) {
            _random = Random.Range(1, 100000);//1 from 100,000

            if (_random == 50) {
                StartCoroutine(Bird());
                _secretBird.SetActive(true);
            }
        }
        if (coinUpdate >= 1000000) { //If coinUpdate equals one Million
            _endButton.SetActive(true);
        }
    }

    IEnumerator Bird() { //Easter egg
        _canBird = false;
        yield return new WaitForSeconds(7);
        _boostText.SetActive(true);
        _dLore.SetActive(true);
        _secretBird.SetActive(false);
        coinUpdate = coinUpdate + 1000;
    }
}
