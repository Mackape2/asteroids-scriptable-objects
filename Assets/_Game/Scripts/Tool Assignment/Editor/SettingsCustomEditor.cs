using System.Collections;
using System.Collections.Generic;
using Tool_Assignment;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class AssetHandler
{
   [OnOpenAsset()]
   public static bool OpenEditor(int instanceId, int line)
   {
      SettingsManager obj = EditorUtility.InstanceIDToObject(instanceId) as SettingsManager;
      if (obj != null)
      {
         SettingsEditorWindow.Open(obj);
         return true;
      }

      return false;
   }
}

[CustomEditor(typeof(SettingsManager))]
public class SettingsCustomEditor : Editor
{
   public override void OnInspectorGUI()
   {
      if (GUILayout.Button("Open Editor"))
      {
         SettingsEditorWindow.Open((SettingsManager)target);
      }
   }
}
