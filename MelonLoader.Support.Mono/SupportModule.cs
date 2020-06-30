using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MelonLoader.Support
{
    public class Module : ISupportModule
    {
        public string GetUnityVersion() => Application.unityVersion;
        public float GetUnityDeltaTime() => Time.deltaTime;
        public int GetActiveSceneIndex() => SceneManager.GetActiveScene().buildIndex;
        public object StartCoroutine(IEnumerator coroutine) => Main.comp.StartCoroutine(coroutine);
        public void StopCoroutine(object coroutineToken) => Main.comp.StopCoroutine((Coroutine) coroutineToken);
        public void UnityDebugLog(string msg) => Debug.Log(msg);
        public ModSettingsMenu.RenderHelper GetModSettingsMenuRenderHelper() => null;
        public void Destroy() => MelonLoaderComponent.Destroy();
    }
}