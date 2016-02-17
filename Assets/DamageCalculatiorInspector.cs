using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections;

public class DamageCalculatiorInspector : MonoBehaviour {
#if UNITY_EDITOR
    [MenuItem ("GameObect/Create HelloWorld")] 

    private static void CreateHelloWorldGameObject()
    {
        if (EditorUtility.DisplayDialog("Hello World","Do you really want to do this?","Create","Cancel"))
        {
            new GameObject("Hello World");
        }
    }
#endif
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
