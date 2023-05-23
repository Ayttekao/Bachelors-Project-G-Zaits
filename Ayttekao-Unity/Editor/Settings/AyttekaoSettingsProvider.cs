using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Ayttekao.Unity.Editor
{
    public class AyttekaoSettingsProvider : SettingsProvider
    {
        private SerializedObject serializedObject;
        private AyttekaoSettingsGrid2D.Inspector inspectorGrid2D;
        private AyttekaoSettingsGeneral.Inspector inspectorGeneral;

        public AyttekaoSettingsProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null)
            : base(path, scopes, keywords) { }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            AyttekaoSettings.instance.Save();
            serializedObject = new SerializedObject(AyttekaoSettings.instance);
            inspectorGrid2D = new AyttekaoSettingsGrid2D.Inspector(serializedObject);
            inspectorGeneral = new AyttekaoSettingsGeneral.Inspector(serializedObject);
        }

        public override void OnGUI(string searchContext)
        {
            using (CreateSettingsWindowGUIScope())
            {
                serializedObject.Update();
                EditorGUI.BeginChangeCheck();

                inspectorGeneral.OnGUI();
                inspectorGrid2D.OnGUI();

                if (EditorGUI.EndChangeCheck())
                {
                    serializedObject.ApplyModifiedProperties();
                    AyttekaoSettings.instance.Save();
                }
            }
        }

        [SettingsProvider]
        public static SettingsProvider CreateMySingletonProvider()
        {
            var provider = new AyttekaoSettingsProvider("Preferences/Ayttekao", SettingsScope.User);
            return provider;
        }

        private IDisposable CreateSettingsWindowGUIScope()
        {
            var unityEditorAssembly = Assembly.GetAssembly(typeof(EditorWindow));
            var type = unityEditorAssembly.GetType("UnityEditor.SettingsWindow+GUIScope");
            return Activator.CreateInstance(type) as IDisposable;
        }
    }
}