using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class K�rnyezet : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;
    bool teleporting;
    float teleportDelta;


    // Add menu named "My Window" to the Window menu
    [MenuItem("Femtonics/K�rnyezet")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        K�rnyezet window = (K�rnyezet)EditorWindow.GetWindow(typeof(K�rnyezet));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);
        teleporting = EditorGUILayout.Toggle("Teleporting", PositionTracking.teleporting);
        teleportDelta = EditorGUILayout.FloatField("Teleport Delta", PositionTracking.teleportDelta);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}


public class Funkcionalit�s : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    // Add menu named "My Window" to the Window menu
    [MenuItem("Femtonics/Funkcionalit�s")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        Funkcionalit�s window = (Funkcionalit�s)EditorWindow.GetWindow(typeof(Funkcionalit�s));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}