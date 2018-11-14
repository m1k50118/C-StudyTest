using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LevelEditor : Editor {

	[CustomEditor(typeof(Level))]
	[CanEditMultipleObjects]
	public override void OnInspectorGUI(){
        serializedObject.Update();
		Level myLevel = (Level)target;
		myLevel.experience = EditorGUILayout.IntField("Experience", myLevel.experience);
        EditorGUILayout.LabelField("Level", myLevel.level.ToString());
	}
}
