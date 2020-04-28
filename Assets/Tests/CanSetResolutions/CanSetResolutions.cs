using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class CanSetResolutions
    {
        [UnityTest]
        public IEnumerator CanSetResolution_ToSmaller()
        {
            SceneManager.LoadScene("CanSetResolutions");
            yield return null;

            var width = Screen.width;
            var height = Screen.height;
            Screen.SetResolution(width / 2, height / 2, true);
            yield return null;
            
            Assert.AreEqual(width / 2, Screen.width);
            Assert.AreEqual(height / 2, Screen.height);
        }
        
        [UnityTest]
        public IEnumerator CanSetResolution_ToHigher()
        {
            SceneManager.LoadScene("CanSetResolutions");
            yield return null;

            var width = Screen.width;
            var height = Screen.height;
            Screen.SetResolution(width * 2, height * 2, true);
            yield return null;
            
            Assert.AreEqual(width * 2, Screen.width);
            Assert.AreEqual(height * 2, Screen.height);
        }
        
        [UnityTest]
        public IEnumerator CanSetResolution_ToNative()
        {
            SceneManager.LoadScene("CanSetResolutions");
            yield return null;

            var width = Screen.width;
            var height = Screen.height;
            Screen.SetResolution(width / 2, height / 2, true);
            yield return null;
            
            Screen.SetResolution(width, height, true);
            yield return null;
            
            Assert.AreEqual(width, Screen.width);
            Assert.AreEqual(height, Screen.height);
        }
        
    }
}
