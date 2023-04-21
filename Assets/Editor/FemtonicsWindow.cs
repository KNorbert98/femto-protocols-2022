using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class K�rnyezet : EditorWindow
{
    [MenuItem("Femtonics/Environment")]
    static void Init()
    {
        K�rnyezet window = (K�rnyezet)GetWindow(typeof(K�rnyezet));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

    void OnGUI()
    {
        //Creates new scene
        if (GUILayout.Button("New Scene", GUILayout.ExpandWidth(false)))
        {
            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        }
    }
}


public class Funkcionalit�s : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    [MenuItem("Femtonics/Funkcionalit�s")]
    static void Init()
    {
        Funkcionalit�s window = (Funkcionalit�s)GetWindow(typeof(Funkcionalit�s));
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