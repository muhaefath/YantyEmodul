using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerahSimpan : MonoBehaviour {
	

	public delegate void OnItemChanged();
	public OnItemChanged onitemchangedcallback;

	public int MaxItem;
	public List<MerahMerah> items = new List<MerahMerah>();
	//public inventoryUI manager;


	public bool Add(MerahMerah item)
	{	
		bool masukgak = false;

		item = GameObject.Find ("Merah(Clone)").GetComponent<MerahMerah>();


		if (!masukgak) {	
			if (!item.ada) {
				if (items.Count >= MaxItem) {

					Debug.Log ("tidak ada ruang");
					return false;
				}

				items.Add (item);
			
				if (onitemchangedcallback != null) {
					onitemchangedcallback.Invoke ();
				}
				masukgak = false;
			}
		}
		return true;
	}

	public void Remove(MerahMerah item)
	{

		items.Remove (item);
		if(onitemchangedcallback!= null)
		{
			onitemchangedcallback.Invoke ();
		}
	}
}
