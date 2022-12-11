using UnityEngine;

public class Sample : MonoBehaviour {
    void Start() {
        Debug.Log($"location: {StandaloneDeviceInfo.GetLocation()}");
        Debug.Log($"language: {StandaloneDeviceInfo.GetLanguage()}");
    }
}
