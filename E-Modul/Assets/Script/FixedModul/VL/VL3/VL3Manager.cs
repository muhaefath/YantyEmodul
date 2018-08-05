using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VL3Manager : MonoBehaviour {

	public List<GameObject> KumpulanAction;
	public List<GameObject> SatuanBahan;
	public List<GameObject> SatuanBahanParent;
	public List<Button> SatuanBahanScript;

	public GameObject BackBawah;

	public GameObject Apayangterjadi;

	public Animator[] Anim;
	public	int indexBeban;

	// Use this for initialization
	void Start () {
		for (int i = 0; i <  KumpulanAction.Count; i++) {
			KumpulanAction [i].SetActive (false);
		}
	
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

		Apayangterjadi.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void VL4Atur(int index)
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

			KumpulanAction [1].SetActive (false);
			KumpulanAction [2].SetActive (true);
			SatuanBahanScript [2].enabled = false;
			SatuanBahanScript [3].enabled = true;
		}
		else if(index ==3)
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
		else if(index ==4)
		{
			SatuanBahan [4].transform.position = SatuanBahanParent [4].transform.position;

			//Apayangterjadi.SetActive (true);

			SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [3].SetActive (false);
			KumpulanAction [4].SetActive (true);
			SatuanBahanScript [4].enabled = false;
			indexBeban = 1;
		}

		else if(index ==5)
		{
			//SatuanBahan [4].transform.position = SatuanBahanParent [4].transform.position;

			//Apayangterjadi.SetActive (true);

			//SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			//SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [4].SetActive (false);
			KumpulanAction [5].SetActive (true);
			//SatuanBahanScript [5].enabled = false;
			indexBeban =2;
		}

		else if(index ==6)
		{
			//SatuanBahan [4].transform.position = SatuanBahanParent [4].transform.position;

			//Apayangterjadi.SetActive (true);

			//SatuanBahanParent [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			//SatuanBahan [4].GetComponent<Image> ().color = new Color32 (255,255,255,60);

			KumpulanAction [5].SetActive (false);
			KumpulanAction [6].SetActive (true);
			//SatuanBahanScript [6].enabled = false;
			indexBeban =3;
		}
	}

	public void RestrartVL3()
	{
		for (int i = 0; i < KumpulanAction.Count; i++) {
			KumpulanAction [i].SetActive (false);
		}

		for (int i = 0; i < SatuanBahanScript.Count; i++) {
			SatuanBahanScript [i].enabled = false;
		}
		SatuanBahanScript [0].enabled  = true;
		Anim[0].SetBool ("Jalan",false);
		Anim[1].SetBool ("Jalan",false);
		Anim[2].SetBool ("Jalan",false);

		for (int i = 0; i < SatuanBahanParent.Count; i++) {
			SatuanBahanParent [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
			SatuanBahan [i].GetComponent<Image> ().color = new Color32 (255,255,255,60);
		}
		Apayangterjadi.SetActive (false);
		SatuanBahanParent [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		SatuanBahan [0].GetComponent<Image> ().color = new Color32 (255,255,255,255);
		indexBeban = 0;
	}

	public void TekanPer()
	{
		if (indexBeban == 1) {
			Anim[0].Play("gb3");


			Anim[0].SetBool ("Jalan",true);
			
		
		}
		else if (indexBeban == 2) {
			
			Anim[1].Play("gb3");
		
			Anim[1].SetBool ("Jalan",true);
		}
		else if (indexBeban == 3) {

			Anim[2].Play("gb3");
			Anim[2].SetBool ("Jalan",true);
		}
	}

	public void PindahBeban(int index)
	{
		if (index == 1) {
			KumpulanAction [4].SetActive (false);
			KumpulanAction [5].SetActive (true);
			KumpulanAction [6].SetActive (false);
			Anim[1].SetBool ("Jalan",false);

			indexBeban =2;
		}else if (index == 0) {
			KumpulanAction [4].SetActive (true);
			KumpulanAction [5].SetActive (false);
			KumpulanAction [6].SetActive (false);
			Anim[0].SetBool ("Jalan",false);

			indexBeban =1;
		}
		else if (index == 2) {
			KumpulanAction [6].SetActive (true);
			KumpulanAction [5].SetActive (false);
			KumpulanAction [4].SetActive (false);
			Anim[2].SetBool ("Jalan",false);

			indexBeban =3;
		}

	}

}
