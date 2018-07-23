using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PindahScene : MonoBehaviour {
	public GameObject[] Halaman;
	public float CurrSwipe;


	public  SearchHalm manager;
	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.GetInt ("BalikSoal") == 1) {
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [20].SetActive (true);
			PlayerPrefs.SetInt ("BalikSoal", 0);

		} else if (PlayerPrefs.GetInt ("BalikSoal") == 2) {
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [19].SetActive (true);
			PlayerPrefs.SetInt ("BalikSoal", 0);
		}
		else if (PlayerPrefs.GetInt ("BalikSoal") == 3) {
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [14].SetActive (true);
			PlayerPrefs.SetInt ("BalikSoal", 0);
		}
		else {
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [0].SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pindah1(string NamaScene)
	{
		SceneManager.LoadScene (NamaScene,LoadSceneMode.Single);
	}

	public void SwipeKekiri()
	{
		CurrSwipe =  Input.mousePosition.x;

	}

	public void PindahDiKlik(int Nama)
	{
		if(Nama < Halaman.Length - 1 )
		{
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [Nama + 1].SetActive (true);
		}
		
		manager.TutupSearch ();


	}


	public void PindahDiKlik2(int Nama)
	{
		

		if(Nama >0)
		{
			for (int i = 0; i < Halaman.Length; i++) {
				Halaman [i].SetActive (false);
			}
			Halaman [Nama - 1].SetActive (true);
		}
		manager.TutupSearch ();
	}

	public void Youtube()
	{
		Application.OpenURL ("https://www.youtube.com/watch?v=xqvL3yaKDco");
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
