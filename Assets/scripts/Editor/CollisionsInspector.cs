using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Collision))]
public class CollisionsInspector : Editor
{

    static bool stateFoldout = true;
    static bool drawDefaultInspector;
    static bool colliderBoxesFoldout;

    public override void OnInspectorGUI()
    {
        Collision collisions = (Collision)target;

        GUIStyle booleanText = new GUIStyle();

        EditorGUILayout.Space();
        EditorGUI.indentLevel = 1;

        stateFoldout = EditorGUILayout.Foldout(stateFoldout, "State", true, EditorStyles.toolbarDropDown);

        if(stateFoldout)
        {
            EditorGUILayout.BeginVertical(EditorStyles.textArea);

            EditorGUI.indentLevel = 2;
            // collisions.isGrounded = EditorGUILayout.Toggle("Is Grounded", collisions.isGrounded, EditorStyles.booleanText);

            //---------------------------------------------------------------------------

            //Ground
            EditorGUILayout.LabelField("Ground", booleanText);

            if(collisions.isGrounded) booleanText.normal.textColor = Color.green;
            if(!collisions.isGrounded) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Is Grounded", booleanText);

            if (collisions.wasGrounded) booleanText.normal.textColor = Color.green;
            if (!collisions.wasGrounded) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Was Grounded", booleanText);

            if(collisions.justGotGrounded) booleanText.normal.textColor = Color.green;
            if(!collisions.justGotGrounded) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Just GOT Grounded", booleanText);

            if(collisions.justNOTGrounded) booleanText.normal.textColor = Color.green;
            if(!collisions.justNOTGrounded) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Just NOT Grounded", booleanText);

            if(collisions.IsFalling) booleanText.normal.textColor = Color.green;
            if(!collisions.IsFalling) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Is falling", booleanText);

            //---------------------------------------------------------------------------

            //Ceiling
            EditorGUILayout.LabelField("Ceiling", booleanText);

            if(collisions.isCeiling) booleanText.normal.textColor = Color.green;
            if(!collisions.isCeiling) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Is touching ceiling", booleanText);

            if(collisions.wasCeiling) booleanText.normal.textColor = Color.green;
            if(!collisions.wasCeiling) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("WAS touching ceiling", booleanText);

            if(collisions.justGotCeiling) booleanText.normal.textColor = Color.green;
            if(!collisions.justGotCeiling) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("JUST touched ceiling", booleanText);

            if(collisions.justNOTCeiling) booleanText.normal.textColor = Color.green;
            if(!collisions.justNOTCeiling) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Just didn't touch ceiling", booleanText);

            //---------------------------------------------------------------------------

            //Walls
            EditorGUILayout.LabelField("Walls", booleanText);

            if(collisions.isTouchingWall) booleanText.normal.textColor = Color.green;
            if(!collisions.isTouchingWall) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Is touching wall", booleanText);

            if(collisions.wasTouchingWallLastFrame) booleanText.normal.textColor = Color.green;
            if(!collisions.wasTouchingWallLastFrame) booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("WAS touching wall", booleanText);

            //---------------------------------------------------------------------------

            EditorGUILayout.EndVertical();
        }

        EditorGUILayout.Space();
        EditorGUI.indentLevel = 1;

        drawDefaultInspector = EditorGUILayout.Foldout(drawDefaultInspector, "Default Inspector", true, EditorStyles.toolbarDropDown);

        if (drawDefaultInspector)
        {
            EditorGUI.indentLevel = 2;
            base.OnInspectorGUI();
        }
    }

}
