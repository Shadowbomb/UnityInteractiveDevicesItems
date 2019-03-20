﻿using UnityEngine;
using System.Collections;

public class SettingsPopup : MonoBehaviour {
    public void Open() {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    public void Close() {
        gameObject.SetActive(false);
    }

    public void OnSubmitName(string name) {
        Debug.Log(name);
    }

    public void OnSpeedValue(float speed) {
        Debug.Log("Speed: " + speed);
    }
}
