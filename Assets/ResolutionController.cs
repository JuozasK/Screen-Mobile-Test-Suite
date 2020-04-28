using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ResolutionController : MonoBehaviour
{
    public InputField inputWidth, inputHeight;
    public Text info;
    public Toggle toggleFullscreen;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScreenInfo();
    }

    void UpdateScreenInfo()
    {
        string payload = "";
        payload += $"Screen.Height = {Screen.height} \n";
        payload += $"Screen.Width = {Screen.width} \n";
        payload += $"Screen.currentResolution = {Screen.currentResolution} \n";
        payload += $"Screen.safeArea yMin,xMin : yMax,xMax  = {Screen.safeArea.yMin},{Screen.safeArea.xMin} : {Screen.safeArea.yMax},{Screen.safeArea.xMax} \n";
        payload += $"Display.systemHeight = {Display.main.systemHeight} \n";
        payload += $"Display.systemWidth = {Display.main.systemWidth} \n";
        payload += $"Display.renderingHeight = {Display.displays[0].renderingHeight} \n";
        payload += $"Display.renderingWidth = {Display.displays[0].renderingWidth} \n";
        
        info.text = payload;

    }

    public void ClickSetResolution()
    {
        int width = Int32.Parse(inputWidth.text);
        int height = Int32.Parse(inputHeight.text);
        bool toggle = toggleFullscreen.isOn;
        Debug.LogFormat("Setting resolution to {0} width, {1} height, Fullscreen = {2}", width,height,toggle );
        Screen.SetResolution( width, height, toggle);
        UpdateScreenInfo();
    }
}
