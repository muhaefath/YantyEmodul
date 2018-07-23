using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerahMerah : MonoBehaviour {
	public float Speed;
	public Transform BatasPipa;

	public  bool ada;

	void Start()
	{
		ada = false;
		bool udahdiambil = DragVL2.instance.Add (this);

	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Speed*Time.deltaTime,0,0);
		if(this.transform.position.x > BatasPipa.transform.position.x +800 )
		{
			Destroy (gameObject);
			DragVL2.instance.Remove (this);
		}
	}
}
