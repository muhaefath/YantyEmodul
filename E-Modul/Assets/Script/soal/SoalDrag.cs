using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SoalDrag : MonoBehaviour {
	public Image[] Soal;
	public Image[] jawaban;
	public Vector2[] vec;
	[SerializeField]int JumlahSoalBenar;


	public Button prev;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < vec.Length; i++) {
			vec[i] = Soal [i].transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (JumlahSoalBenar == 3) {
			
			prev.interactable = true;

		} else {
			
			prev.interactable = false;
		}
	}

	public void PindahinSoal(int curr)
	{
		
		Soal[curr].transform.position = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);

	}

	public void DropSoal(int curr)
	{
		if (Vector2.Distance (Soal [curr].transform.position, jawaban [curr].transform.position) < 100) {
			Soal [curr].transform.position = jawaban [curr].transform.position;
			JumlahSoalBenar += 1;

		} else {
			Soal [curr].transform.position = vec[curr];
		}
	}

	public void BalikMateri(string nama)
	{
		PlayerPrefs.SetInt ("BalikSoal",2);
		SceneManager.LoadScene (nama);
	}
}
