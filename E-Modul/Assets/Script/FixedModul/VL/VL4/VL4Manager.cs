using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VL4Manager : MonoBehaviour {


	public List<GameObject> KumpulanAction;
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<DragVL4> SatuanBahanScript;

	public GameObject BackBawah;
	public GameObject Gelas5;

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

		if(Vector2.Distance(SatuanBahan[0].transform.position,BackBawah.transform.position) < 300)
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

			SatuanBahanParent [3].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [3].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [2].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			//KumpulanAction [1].SetActive (false);
			KumpulanAction [2].SetActive (true);
			SatuanBahanScript [2].enabled = false;
			SatuanBahanScript [3].enabled = true;
		}
		else if(Vector2.Distance(SatuanBahan[3].transform.position,BackBawah.transform.position) < 300)
		{
			SatuanBahan [3].transform.position = SatuanBahanParent [3].transform.position;

			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [2].SetActive (false);
			KumpulanAction [3].SetActive (true);
			SatuanBahanScript [3].enabled = false;
			SatuanBahanScript [4].enabled = true;

		}
		else if(Vector2.Distance(SatuanBahan[4].transform.position,BackBawah.transform.position) < 120)
		{
			SatuanBahan [4].transform.position = SatuanBahanParent [4].transform.position;

			SatuanBahanParent [5].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [5].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [3].SetActive (false);
			KumpulanAction [4].SetActive (true);
			SatuanBahanScript [4].enabled = false;
			SatuanBahanScript [5].enabled = true;
			//Debug.Log ("2");
		}
		else if(Vector2.Distance(SatuanBahan[5].transform.position,Gelas5.transform.position) < 120)
		{
			SatuanBahan [5].transform.position = SatuanBahanParent [5].transform.position;



			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [4].SetActive (false);
			KumpulanAction [1].SetActive (false);
			KumpulanAction [5].SetActive (true);
			SatuanBahanScript [5].enabled = false;
			//SatuanBahanScript [5].enabled = true;
			anim2.SetBool("Jalan",true);
			//Debug.Log ("2");
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


		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);

		SatuanBahanScript [0].enabled  = true;
		anim1.SetBool("Jalan",false);
		anim2.SetBool("Jalan",false);
	}

	public void TekanTombol()
	{
		KumpulanAction [5].SetActive (false);
		KumpulanAction [6].SetActive (true);
	}
}
