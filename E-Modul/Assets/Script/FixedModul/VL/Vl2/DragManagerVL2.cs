using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManagerVL2 : MonoBehaviour {
	public List<GameObject> DaftarVL1; 
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<DragVL1> ScriptBahan;
	public List<GameObject> KumpulanPaku;

	public int CabutPaku;
	public GameObject BackBawah;

	public Animator Anim;
	// Use this for initialization
	void Start () {

		for (int i = 0; i < DaftarVL1.Count; i++) {
			DaftarVL1 [i].SetActive (false);
		}
		for (int i = 0; i < ScriptBahan.Count; i++) {
			ScriptBahan [i].enabled = false;
		}
		ScriptBahan [0].enabled = true;
	}

	// Update is called once per frame
	void Update () {

		Vl1Step ();

	}

	void Vl1Step()
	{
		if(Vector2.Distance(SatuanBahan[0].transform.position,this.transform.position) < 200)
		{
			SatuanBahan [0].transform.position = SatuanBahanParent [0].transform.position;


			DaftarVL1 [0].SetActive (true);
			ScriptBahan [0].enabled = false;
			ScriptBahan [1].enabled = true;

		}
		else if(Vector2.Distance(SatuanBahan[1].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [1].transform.position = SatuanBahanParent [1].transform.position;

			DaftarVL1 [0].SetActive (false);
			DaftarVL1 [1].SetActive (true);
			ScriptBahan [1].enabled = false;
			ScriptBahan [2].enabled = true;
		}
		else if(Vector2.Distance(SatuanBahan[2].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [2].transform.position = SatuanBahanParent [2].transform.position;

			DaftarVL1 [1].SetActive (false);
			DaftarVL1 [2].SetActive (true);
			ScriptBahan [2].enabled = false;
			ScriptBahan [3].enabled = true;
		}
		else if(Vector2.Distance(SatuanBahan[3].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [3].transform.position = SatuanBahanParent [3].transform.position;

			DaftarVL1 [2].SetActive (false);
			DaftarVL1 [3].SetActive (true);
			ScriptBahan [3].enabled = false;
			ScriptBahan [4].enabled = true;
		}
		else if(CabutPaku == 3)
		{

			Anim.SetBool ("Jalan",true);
		}

	}

	public void RestrartVL1()
	{
		Anim.SetBool ("Jalan",false);
		for (int i = 0; i < DaftarVL1.Count; i++) {
			DaftarVL1 [i].SetActive (false);
		}

		for (int i = 0; i < ScriptBahan.Count; i++) {
			ScriptBahan [i].enabled = false;
		}
		ScriptBahan [0].enabled  = true;

		KumpulanPaku [0].SetActive (true);

		CabutPaku = 0;
	}
}
