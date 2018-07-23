using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TahanDrag : MonoBehaviour {
	dragitem manager;
	public int Curr;
	// Use this for initialization
	void Start () {
		manager = FindObjectOfType<dragitem> ();
	}
	
	// Update is called once per frame
	void Update () {
		ditahan (Curr);
	}

	void ditahan(int pilih)
	{
		if(manager.masihditarik == true && pilih == 1)
		{
			manager.Didrag3 (1);
		}
		if(manager.masihditarik2 == true && pilih == 2)
		{
			manager.Didrag3 (2);

		}
	}
}
