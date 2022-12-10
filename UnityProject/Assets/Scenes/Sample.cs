using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class Sample : MonoBehaviour {
    [DllImport("MacDeviceInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetDeviceLocation();

    [DllImport("MacDeviceInfo", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr GetDeviceLanguage();

    void Start() {
        Debug.Log(Marshal.PtrToStringAnsi(GetDeviceLocation()));
        Debug.Log(Marshal.PtrToStringAnsi(GetDeviceLanguage()));
    }
}
