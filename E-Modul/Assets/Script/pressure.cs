using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pressure : MonoBehaviour {

	public Image Bendanya;
	public Image[] Pressures;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DragPressure(int curr)
	{
		//Instantiate (Bendanya,Input.mousePosition,Bendanya.transform.rotation);
		Pressures[curr].transform.position = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);

	}

	public void DropPressure(int curr)
	{
		if(Pressures[curr].rectTransform.anchoredPosition.x > -129 && Pressures[curr].rectTransform.anchoredPosition.x < 129 && Pressures[curr].rectTransform.anchoredPosition.y > 682 && Pressures[curr].rectTransform.anchoredPosition.x < 923)
		{
			Pressures [curr].rectTransform.anchoredPosition = Bendanya.rectTransform.anchoredPosition;
			Debug.Log ("a");
		}
	}
}
