using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class CanSetFullscreenModes
    {
        [UnityTest]
        public IEnumerator CanSetFullscreenMode_Windowed()
        {
            SceneManager.LoadScene("CanSetResolutions");
            yield return null;

            Screen.fullScreenMode = FullScreenMode.Windowed;
            yield return null;
            
            Assert.IsFalse(Screen.fullScreen);
        }
        
        [UnityTest]
        public IEnumerator CanSetFullscreenMode_Fullscreen()
        {
            SceneManager.LoadScene("CanSetResolutions");
            yield return null;

            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            yield return null;
            
            Assert.IsTrue(Screen.fullScreen);
        }
    }
}
