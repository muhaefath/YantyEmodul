using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VL9Manager : MonoBehaviour {

	public List<GameObject> KumpulanAction;
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<DragVL9> SatuanBahanScript;

	public GameObject BackBawah;
	public Animator Anim;
	public Animator anim2;
	// Use this for initialization
	void Start () {
		for (int i = 0; i <  KumpulanAction.Count; i++) {
			KumpulanAction [i].SetActive (false);
		}
		//KumpulanAction [0].SetActive (true);
		for (int i = 0; i < SatuanBahanScript.Count; i++) {
			SatuanBahanScript [i].enabled = false;
		}
		SatuanBahanScript [0].enabled = true;
	}

	// Update is called once per frame
	void Update () {

		if(Vector2.Distance(SatuanBahan[0].transform.position,this.transform.position) < 200)
		{
			SatuanBahan [0].transform.position = SatuanBahanParent [0].transform.position;


			KumpulanAction [0].SetActive (true);
			SatuanBahanScript [0].enabled = false;
			SatuanBahanScript [1].enabled = true;

		}

		else if(Vector2.Distance(SatuanBahan[1].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [1].transform.position = SatuanBahanParent [1].transform.position;

			KumpulanAction [0].SetActive (false);
			KumpulanAction [1].SetActive (true);
			SatuanBahanScript [1].enabled = false;
			SatuanBahanScript [2].enabled = true;
		}
		else if(Vector2.Distance(SatuanBahan[2].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [2].transform.position = SatuanBahanParent [2].transform.position;

			//KumpulanAction [1].SetActive (false);
			KumpulanAction [2].SetActive (true);
			SatuanBahanScript [2].enabled = false;
			SatuanBahanScript [3].enabled = true;
		}
		else if(Vector2.Distance(SatuanBahan[3].transform.position,BackBawah.transform.position) < 200)
		{
			SatuanBahan [3].transform.position = SatuanBahanParent [3].transform.position;

			KumpulanAction [2].SetActive (false);
			KumpulanAction [3].SetActive (true);
			SatuanBahanScript [3].enabled = false;

		}

	}
	public void RestrartVL4()
	{
		for (int i = 0; i < KumpulanAction.Count; i++) {
			KumpulanAction [i].SetActive (false);
		}

		for (int i = 0; i < SatuanBahanScript.Count; i++) {
			SatuanBahanScript [i].enabled = false;
		}
		SatuanBahanScript [0].enabled  = true;
		Anim.SetBool ("Jalan",false);
		anim2.SetBool ("Jalan",false);
	}

	public void Animasi1()
	{
		Anim.SetBool ("Jalan",true);
	}

	public void Animasi2()
	{
		Anim.SetBool ("Jalan",false);
		anim2.SetBool ("Jalan",true);
	}
}
