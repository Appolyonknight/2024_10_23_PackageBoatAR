using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AppolyonKnight
{
    [CustomEditor(typeof(Basic_Boat_Mono))]
    public class Basic_Biat_Editor_Mono : Editor
    {
        public override void OnInspectorGUI ()
        {
            base.OnInspectorGUI();
            Basic_Boat_Mono t = (Basic_Boat_Mono)target;
            if (GUILayout.Button("Teleport Forward"))
            {
                t.TeleportForward();
            }
        }
    }
}

