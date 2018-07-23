using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VL6Manager : MonoBehaviour {


	public List<GameObject> KumpulanAction;
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<DragVL6> SatuanBahanScript;

	public GameObject BackBawah;
	public Animator anim1;
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

		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
	}

	// Update is called once per frame
	void Update () {

		if(Vector2.Distance(SatuanBahan[0].transform.position,this.transform.position) < 300)
		{
			SatuanBahan [0].transform.position = SatuanBahanParent [0].transform.position;

			SatuanBahanParent [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [0].SetActive (true);
			SatuanBahanScript [0].enabled = false;
			SatuanBahanScript [1].enabled = true;

		}

		else if(Vector2.Distance(SatuanBahan[1].transform.position,BackBawah.transform.position) < 300)
		{
			SatuanBahan [1].transform.position = SatuanBahanParent [1].transform.position;

			SatuanBahanParent [2].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [2].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [1].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [1].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [0].SetActive (false);
			KumpulanAction [1].SetActive (true);
			SatuanBahanScript [1].enabled = false;
			SatuanBahanScript [2].enabled = true;
			anim1.SetBool ("Jalan",true);
		}
		else if(Vector2.Distance(SatuanBahan[2].transform.position,BackBawah.transform.position) < 300)
		{
			SatuanBahan [2].transform.position = SatuanBahanParent [2].transform.position;

			//KumpulanAction [1].SetActive (false);
			SatuanBahanParent [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [2].SetActive (true);
			SatuanBahanScript [2].enabled = false;

			anim2.SetBool ("Jalan",true);
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
		anim1.SetBool ("Jalan",false);
		anim2.SetBool ("Jalan",false);

		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
	}

}
