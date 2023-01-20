using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Tool_Assignment
{
    public class SettingsEditorWindow : ExtendedEditorWindow
    {
        public static void Open(SettingsManager dataObject)
        {
            SettingsEditorWindow window = GetWindow<SettingsEditorWindow>("Settings Editor");
            window._serializedObject = new SerializedObject(dataObject);
        }

        private void OnGUI()
        {
            _currentProperty = _serializedObject.FindProperty("NewSettingManager");
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.BeginVertical("box", GUILayout.MaxWidth(150), GUILayout.ExpandHeight(true));
            
            DrawSidebar(_currentProperty);
            EditorGUILayout.EndVertical();
            EditorGUILayout.EndHorizontal();
        }
    }
}
