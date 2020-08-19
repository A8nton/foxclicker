using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    [SerializeField]
    private Text _score;

    private int coinUpdate;
    private int coins;

    private int _random;

    public void Start() {
        coinUpdate = PlayerPrefs.GetInt("coinUpdate");
        int savedCoins = PlayerPrefs.GetInt("coins");
        coins = savedCoins;
        _score.text = "FOXCOINS: " + savedCoins.ToString();
    }

    public void PlusCoins() {
        if (coins >= 10) {
            coins -= 10;
            coinUpdate++;
        }
    }

    void OnMouseDown() {
        coins += coinUpdate;
    }

    public void Update() {
        _score.text = "FOXCOINS: " + coins;
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("coinUpdate", coinUpdate);

        _random = Random.Range(1, 100);

        if (_random == 50) {

        }
    }
}
