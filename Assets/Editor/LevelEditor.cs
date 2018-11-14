using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Level))]
public class LevelEditor : Editor {
	public override void OnInspectorGUI(){
		Level myLevel = (Level)target;

		myLevel.experience = EditorGUILayout.IntField("Experience", myLevel.experience);
		EditorGUILayout.LabelField("Level", myLevel.level.ToString());
	}
	
}
