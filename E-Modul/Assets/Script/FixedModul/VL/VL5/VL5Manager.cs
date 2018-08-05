using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VL5Manager : MonoBehaviour {


	public List<GameObject> KumpulanAction;
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<Button> SatuanBahanScript;

	public GameObject BackBawah;

	public Animator Anim;
	public GameObject SiletSabun;
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
		SiletSabun.SetActive (false);
	}

	// Update is called once per frame
	void Update () {



	}
	public void VL5Atur(int index)
	{
		if(index ==0)
		{
			SatuanBahan [0].transform.position = SatuanBahanParent [0].transform.position;

			SatuanBahanParent [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [1].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [0].SetActive (true);
			SatuanBahanScript [0].enabled = false;
			SatuanBahanScript [1].enabled = true;
			SiletSabun.SetActive (false);
		}

		else if(index ==1) 
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
		}
		else if(index ==2)
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
		else if(index ==3)
		{
			SatuanBahan [3].transform.position = SatuanBahanParent [3].transform.position;

			SatuanBahanParent [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [3].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,255);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,255);

			KumpulanAction [2].SetActive (false);
			KumpulanAction [3].SetActive (true);
			SatuanBahanScript [3].enabled = false;
			SatuanBahanScript [4].enabled = true;
			SiletSabun.SetActive (true);
			//Anim.SetBool ("Jalan",true);
		}
		else if(index ==4)
		{
			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			Anim.SetBool ("Jalan",true);
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

		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);

		Anim.SetBool ("Jalan",false);
		SiletSabun.SetActive (false);
	}


}
