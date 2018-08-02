using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VL1Manager : MonoBehaviour {

	public List<GameObject> DaftarVL1; 
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<Button> ScriptBahan;
	public DragPaku ScriptBahanper;

	public List<GameObject> KumpulanPaku;

	public int CabutPaku;
	public GameObject BackBawah;

	public Animator Anim;


	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < DaftarVL1.Count; i++) {
			DaftarVL1 [i].SetActive (false);
		}
		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		for (int i = 0; i < ScriptBahan.Count; i++) {
			ScriptBahan [i].enabled = false;
		}
		ScriptBahan [0].enabled = true;
		ScriptBahanper.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Vl1Step ();
		 if(CabutPaku == 3)
		{

			Anim.SetBool ("Jalan",true);
		}
	}

	public void Vl1Step(int index)
	{
		if(index == 0)
		{
			SatuanBahan [0].transform.position = SatuanBahanParent [0].transform.position;

			SatuanBahanParent [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			DaftarVL1 [0].SetActive (true);
			ScriptBahan [0].enabled = false;
			ScriptBahan [1].enabled = true;

		}
		else if(index == 1)
		{
			SatuanBahan [1].transform.position = SatuanBahanParent [1].transform.position;

			SatuanBahanParent [2].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [2].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [1].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [1].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			DaftarVL1 [0].SetActive (false);
			DaftarVL1 [1].SetActive (true);
			ScriptBahan [1].enabled = false;
			ScriptBahan [2].enabled = true;
		}
		else if(index == 2)
		{
			SatuanBahan [2].transform.position = SatuanBahanParent [2].transform.position;

			SatuanBahanParent [3].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [3].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			DaftarVL1 [1].SetActive (false);
			DaftarVL1 [2].SetActive (true);
			ScriptBahan [2].enabled = false;
			ScriptBahan [3].enabled = true;
		}
		else if(index == 3)
		{
			SatuanBahan [3].transform.position = SatuanBahanParent [3].transform.position;



			SatuanBahanParent [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			DaftarVL1 [2].SetActive (false);
			DaftarVL1 [3].SetActive (true);
			ScriptBahan [3].enabled = false;
			ScriptBahanper.enabled = true;

		}


	}



	public void RestrartVL1()
	{
		Anim.SetBool ("Jalan",false);
		for (int i = 0; i < DaftarVL1.Count; i++) {
			DaftarVL1 [i].SetActive (false);
		}
		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);

		for (int i = 0; i < ScriptBahan.Count; i++) {
			ScriptBahan [i].enabled = false;
		}
		ScriptBahan [0].enabled  = true;
		for (int i = 0; i < KumpulanPaku.Count; i++) {
			KumpulanPaku [i].SetActive (true);
		}
		CabutPaku = 1;
	}




}
