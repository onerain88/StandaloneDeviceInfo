using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour {
    Text locationText;
    Text languageText;

    void Start() {
        locationText = transform.Find("LocationText").GetComponent<Text>();
        languageText = transform.Find("LanguageText").GetComponent<Text>();

        locationText.text = $"location: {StandaloneDeviceInfo.GetLocation()}";
        languageText.text = $"language: {StandaloneDeviceInfo.GetLanguage()}";
    }
}
