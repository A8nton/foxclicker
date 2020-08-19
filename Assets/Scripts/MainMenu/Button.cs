using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    public AudioClip clip;

    public void ChangeScene(string game) {
        SceneManager.LoadScene(1);
    }
    public void Play() {
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 2));
    }
    public void End() {
        SceneManager.LoadScene(2);
    }
}
