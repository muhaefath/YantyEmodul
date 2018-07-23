using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SearchHalm : MonoBehaviour {
	public GameObject Menunya;
	[SerializeField]
	private bool MenuBuka;
	public Button[] SebelumSesudah;

	public GameObject ButtonMenu;
	public GameObject ButtonMenu2;

	//public Button[] SemuaHalaman;
	// Use this for initialization
	void Start () {
		Menunya.SetActive (false);
		MenuBuka = false;

		ButtonMenu.SetActive (true);
		ButtonMenu2.SetActive (false);

		for (int i = 0; i < SebelumSesudah.Length; i++) {
			SebelumSesudah [i].interactable = true;
		}
	//	SebelumSesudah [2].interactable = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void KlikSearch()
	{
		if(MenuBuka == false)
		{
			Menunya.SetActive (true);
			Time.timeScale = 0;
			MenuBuka = true;
			for (int i = 0; i < SebelumSesudah.Length; i++) {
				SebelumSesudah [i].interactable = false;
			}
		//	SebelumSesudah [2].interactable = true;



			ButtonMenu.SetActive (false);
			ButtonMenu2.SetActive (true);
		}
		else if(MenuBuka == true)
		{
			Menunya.SetActive (false);
			Time.timeScale = 1;
			MenuBuka = false;
			for (int i = 0; i < SebelumSesudah.Length; i++) {
				SebelumSesudah [i].interactable = true;
			}
			//SebelumSesudah [2].interactable = false;
		}
	}

	public void TutupSearch()
	{
		Menunya.SetActive (false);
		Time.timeScale = 1;
		MenuBuka = false;
		for (int i = 0; i < SebelumSesudah.Length; i++) {
			SebelumSesudah [i].interactable = true;
		}


		ButtonMenu.SetActive (true);
		ButtonMenu2.SetActive (false);
	//	SebelumSesudah [2].interactable = false;
	}
}
