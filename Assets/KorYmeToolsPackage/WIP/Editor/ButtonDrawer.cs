using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace KorYmeLibrary.Attributes
{
    [CustomPropertyDrawer(typeof(ButtonAttribute))]
    public class ButtonDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 18f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Debug.Log("Salut");
            EditorGUI.PropertyField(position, property, label, true);
            ButtonAttribute btn = attribute as ButtonAttribute;
            if (GUILayout.Button(btn.MethodName))
            {
                Debug.Log(fieldInfo.Name);
            }
        }
    }
}
