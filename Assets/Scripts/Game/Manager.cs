using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    [SerializeField]
    private Text _score;

    public int coinUpdate = 1;
    public int coins;

    public void Start() {
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

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            coins += coinUpdate;
            PlayerPrefs.SetInt("coins", coins);
            PlayerPrefs.SetInt("coinUpdate", coinUpdate);
            _score.text = "FOXCOINS: " + coins;
        }
    }
}
