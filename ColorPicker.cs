using UnityEngine;
using UnityEditor;

public class ColorPicker : EditorWindow
{

    Color matColor = Color.white;

    [MenuItem("Window/colorPicker")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ColorPicker>("Color Picker");
    }

    void OnGUI()
    {
        GUILayout.Label("Color", EditorStyles.boldLabel);
        
        matColor = EditorGUILayout.ColorField("Object Color", matColor);

        if (GUILayout.Button("Color"))
        {
            // ChangeColor();
        }

        if (Selection.activeGameObject)
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();

                if (renderer != null)
                {
                    renderer.color = matColor;
                }
            }
        }
    }

    void ChangeColor()
    {
        if (Selection.activeGameObject)
        {
            foreach (GameObject t in Selection.gameObjects)
            {
                SpriteRenderer rend = t.GetComponent<SpriteRenderer>();

                if (rend != null)
                {
                    rend.color = matColor;
                }
            }
        }
    }
}
