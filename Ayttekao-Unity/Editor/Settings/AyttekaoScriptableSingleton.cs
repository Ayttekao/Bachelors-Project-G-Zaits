using System.IO;
using UnityEditorInternal;
using UnityEngine;

namespace Ayttekao.Unity.Editor
{
    public class AyttekaoScriptableSingleton<T> : ScriptableObject where T : ScriptableObject
    {
        private static T s_Instance;

        public static T instance
        {
            get
            {
                if ((Object)AyttekaoScriptableSingleton<T>.s_Instance == (Object)null)
                    AyttekaoScriptableSingleton<T>.CreateAndLoad();
                return AyttekaoScriptableSingleton<T>.s_Instance;
            }
        }

        protected AyttekaoScriptableSingleton()
        {
            if ((Object)AyttekaoScriptableSingleton<T>.s_Instance != (Object)null)
                Debug.LogError((object)"ScriptableSingleton already exists. Did you query the singleton in a constructor?");
            else
                AyttekaoScriptableSingleton<T>.s_Instance = (object)this as T;
        }

        private static void CreateAndLoad()
        {
            string filePath = AyttekaoScriptableSingleton<T>.GetFilePath();
            if (!string.IsNullOrEmpty(filePath))
                InternalEditorUtility.LoadSerializedFileAndForget(filePath);
            if (!((Object)AyttekaoScriptableSingleton<T>.s_Instance == (Object)null))
                return;
            ScriptableObject.CreateInstance<T>().hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSave;
        }

        protected virtual void Save(bool saveAsText)
        {
            if ((Object)AyttekaoScriptableSingleton<T>.s_Instance == (Object)null)
            {
                Debug.Log((object)"Cannot save ScriptableSingleton: no instance!");
            }
            else
            {
                string filePath = AyttekaoScriptableSingleton<T>.GetFilePath();
                if (string.IsNullOrEmpty(filePath))
                    return;
                string directoryName = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);
                InternalEditorUtility.SaveToSerializedFileAndForget((Object[])new T[1]
                {
                    AyttekaoScriptableSingleton<T>.s_Instance
                }, filePath, saveAsText);
            }
        }

        private static string GetFilePath()
        {
            return AyttekaoSettings.FilePath;
        }
    }
}