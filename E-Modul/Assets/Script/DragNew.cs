using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragNew : MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler  {


	private Image background;
	private Image virjoystrick;


	public Vector3 inputvector1;
	public Vector3 inputvector2;

	public  Vector3 SimpanRot;
	[SerializeField] private int pilih;
	public dragitem manager;

	// Use this for initialization
	void Start () {

		background = GetComponent<Image> ();
		virjoystrick = transform.GetChild (0).GetComponent<Image> ();


	}

	void Update()
	{
		Ditahan (pilih);
	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(background.rectTransform,ped.position,ped.pressEventCamera,out pos))
		{
			pos.x = (pos.x /background.rectTransform.sizeDelta.x);
			pos.y = (pos.y / background.rectTransform.sizeDelta.y);



			//virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector.x * (background.rectTransform.sizeDelta.x/2), inputvector.z * (background.rectTransform.sizeDelta.y/2));
			if(pilih ==1)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector1.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);
				manager.airkeran.enabled = true;
				manager.airalas.enabled = true;



				inputvector1 = new Vector3 (pos.x ,0, pos.y*2 -1);

				//
				if (inputvector1.x < 0.8f) {
					inputvector1.x = 0.8f;
				} 
				else if(inputvector1.x > 2.3f)
				{
					inputvector1.x = 2.3f;
				}
				//


				////////////////////////////////////
				if (inputvector1.x <= 1f) {
					manager.airkeran.rectTransform.sizeDelta = new Vector2 (200, manager.airkeran.rectTransform.rect.height);
					manager.NambahAirAlas = 0.5f;


				} else if (inputvector1.x > 1f && inputvector1.x <= 1.5f) {
					manager.airkeran.rectTransform.sizeDelta = new Vector2 (400, manager.airkeran.rectTransform.rect.height);
					manager.NambahAirAlas = 1f;


				} else if (inputvector1.x > 1.5f && inputvector1.x <= 2f) {
					manager.airkeran.rectTransform.sizeDelta = new Vector2 (600, manager.airkeran.rectTransform.rect.height);
					manager.NambahAirAlas = 1.5f;

				} else if (inputvector1.x > 2f) {
					manager.airkeran.rectTransform.sizeDelta = new Vector2 (800, manager.airkeran.rectTransform.rect.height);
					manager.NambahAirAlas = 2f;

				}
				manager.masihditarik = true;


			}
			else if(pilih == 2)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector2.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);
				manager.airkeran2.enabled = true;
				//airalas.enabled = true;
				inputvector2 = new Vector3 (pos.x ,0, pos.y*2 -1);


				if (inputvector2.x < 0.8f) {
					inputvector2.x = 0.8f;
				} 
				else if(inputvector2.x > 2.3f)
				{
					inputvector2.x = 2.3f;
				}


				if (inputvector2.x <= 1f) {
					manager.airkeran2.rectTransform.sizeDelta = new Vector2 (100, manager.airkeran2.rectTransform.rect.height);
					manager.NambahAirAlas = 0.5f;


				} else if (inputvector2.x > 1f && inputvector2.x <= 1.5f) {
					manager.airkeran2.rectTransform.sizeDelta = new Vector2 (200, manager.airkeran2.rectTransform.rect.height);
					manager.NambahAirAlas = 1f;


				} else if (inputvector2.x > 1.5f && inputvector2.x <= 2f) {
					manager.airkeran2.rectTransform.sizeDelta = new Vector2 (300, manager.airkeran2.rectTransform.rect.height);
					manager.NambahAirAlas = 1.5f;

				} else if (inputvector2.x > 2f) {
					manager.airkeran2.rectTransform.sizeDelta = new Vector2 (400, manager.airkeran2.rectTransform.rect.height);
					manager.NambahAirAlas = 2f;

				}
				manager.masihditarik2 = true;

				

			}



		}
	}

	public virtual void OnPointerDown(PointerEventData ped)
	{
		inputvector1.x = 0.8f;
		inputvector2.x = 0.8f;
		OnDrag (ped);

	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
		inputvector2 = Vector3.zero;
		inputvector1 = Vector3.zero;

		if(pilih == 1)
		{
			manager.airkeran.enabled = false;
			virjoystrick.rectTransform.anchoredPosition = new Vector3 (33f,7.9f);
			manager.airkeran.rectTransform.sizeDelta = new Vector2 (0f,99.73f); 
		
			manager.masihditarik = false;
		}
		else if(pilih == 2)
		{
			manager.airkeran2.enabled = false;
			virjoystrick.rectTransform.anchoredPosition = new Vector3 (21.2f,6.2f);
			manager.airkeran.rectTransform.sizeDelta = new Vector2 (0f,99.73f); 

			manager.masihditarik2 = false;
		}
	}


	void Ditahan(int curr)
	{
		if(manager.masihditarik == true && curr == 1)
		{
			manager.Didrag3 (1);
		}
		if(manager.masihditarik2 == true && curr == 2)
		{
			manager.Didrag3 (2);

		}
	}





}
