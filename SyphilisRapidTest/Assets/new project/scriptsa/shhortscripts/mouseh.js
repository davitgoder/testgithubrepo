﻿var text = "YOUR TEXT HERE";
 
 private var currentToolTipText = "";
 private var guiStyleFore : GUIStyle;
 private var guiStyleBack : GUIStyle;
 
 function Start()
 {
     guiStyleFore = new GUIStyle();
     guiStyleFore.normal.textColor = Color.green;  
     guiStyleFore.alignment = TextAnchor.UpperCenter ;
     guiStyleFore.wordWrap = true;
     guiStyleBack = new GUIStyle();
     guiStyleBack.normal.textColor = Color.black;  
     guiStyleBack.alignment = TextAnchor.UpperCenter ;
     guiStyleBack.wordWrap = true;
 }
 
 function OnMouseEnter ()
 {
 
     currentToolTipText = "Object : "   +  gameObject.name +  ", " + text;
 }
 
 function OnMouseExit ()
 {
     currentToolTipText = "";
 }
 
 function OnGUI()
 {
     if (currentToolTipText != "")
     {
         var x = Event.current.mousePosition.x;
         var y = Event.current.mousePosition.y;
         GUI.Label (Rect (x-149,y+40,300,60), currentToolTipText, guiStyleBack);
         GUI.Label (Rect (x-150,y+40,300,60), currentToolTipText, guiStyleFore);
     }
 }

 function OnMouseDown()
 {

  
     Destroy( GetComponent(mouseh));
    
 }