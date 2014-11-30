using UnityEngine;
using System.Collections;

public class VersionLabel : MonoBehaviour {
	public Texture2D textureToDisplay;
	public GUIStyle myStyle;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){

		GUI.Label(new Rect(Screen.width/2-textureToDisplay.width/2+20, Screen.height/2-250, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
		GUI.Label(new Rect(Screen.width/2-50, Screen.height/2+50, 450, 100), " Presented by \n Charles Andrew Tapar \n James Gozarate \n Keane Quibilan \n Raj Jariwala \n Yue Zhao",myStyle);
	}
}
