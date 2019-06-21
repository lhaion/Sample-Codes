using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SineBehaviour))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    
        SineBehaviour myScript = (SineBehaviour)target;

        if(EditorApplication.isPlaying){
            if(GUILayout.Button("Reset Object"))
            {
                myScript.ResetBehaviour();
            }
        }
    }
}