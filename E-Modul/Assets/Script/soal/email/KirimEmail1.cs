using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class KirimEmail1 : MonoBehaviour {
	public InputField YourEmail;
	public InputField YourPassword;
	public InputField Subject;
	public InputField Message;
	public Text errorr;

	public string EmailPengirim;
	public string PasswordPengirim;
	//public InputField path;


	public ManagerSimpanData manager;


	// Use this for initialization
	public void SendEmailStart () {
		StartCoroutine (SendMail());
	}

	public IEnumerator SendMail()
	{
		yield return new WaitForSeconds (0.0f);
		if (Message.text == "" || Subject.text == "" || YourEmail.text == "") {
			errorr.text = "please fill in all fields";
		} 
		else {
			EmailPengirim = YourEmail.text;
			PasswordPengirim = YourPassword.text;
			Debug.Log (EmailPengirim);
			Contoh ();


			// ini tempat tarok path
			/*
			if(path.text != "")
			{
				Attachment attachment = null;
				attachment = new Attachment (path.text);
				mail.Attachments.Add (attachment);
			}
			*/


		}

	}

	public void Contoh()
	{
		MailMessage mail = new MailMessage ();
		//yantypurnama7795@gmail.com
		mail.From = new MailAddress (YourEmail.text);
		mail.To.Add ("yantypurnama7795@gmail.com");
		mail.Subject = Subject.text + "Mail From: " + YourEmail.text ;

		mail.Body = "Mail From: " + YourEmail.text + "\n Berikut adalah jawaban Kegiatan 2\n" + "\n \n " + Message.text + "\n \n "


			/*
			+ "\n Jawaban Nomor 1: " + PlayerPrefs.GetString (manager.NamaData[0]) + "\n"
			+ "\n Jawaban Nomor 2: " + PlayerPrefs.GetString (manager.NamaData[1]) + "\n"
			+ "\n Jawaban Nomor 3: " + PlayerPrefs.GetString (manager.NamaData[2]) + "\n"
			+ "\n Jawaban Nomor 4: " + PlayerPrefs.GetString (manager.NamaData[3]) + "\n"
			+ "\n Jawaban Nomor 5: " + PlayerPrefs.GetString (manager.NamaData[4]) + "\n"
			+ "\n Jawaban Nomor 6: " + PlayerPrefs.GetString (manager.NamaData[5]) + "\n"
			+ "\n Jawaban Nomor 7: " + PlayerPrefs.GetString (manager.NamaData[6]) + "\n"
			+ "\n Jawaban Nomor 8: " + PlayerPrefs.GetString (manager.NamaData[7]) + "\n"
			+ "\n Jawaban Nomor 9: " + PlayerPrefs.GetString (manager.NamaData[8]) + "\n"
			+ "\n Jawaban Nomor 10: " + PlayerPrefs.GetString (manager.NamaData[9]) + "\n"
			+ "\n Jawaban Nomor 11: " + PlayerPrefs.GetString (manager.NamaData[10]) + "\n"
			+ "\n Jawaban Nomor 12: " + PlayerPrefs.GetString (manager.NamaData[11]) + "\n"

			+ "\n Jawaban Nomor 13: " + PlayerPrefs.GetString (manager.NamaData[12]) + "\n"

			*/
			+ "\n Jawaban Nomor 14: " + PlayerPrefs.GetString (manager.NamaData[13]) + "\n"
			+ "\n Jawaban Nomor 15: " + PlayerPrefs.GetString (manager.NamaData[14]) + "\n"
			+ "\n Jawaban Nomor 16: " + PlayerPrefs.GetString (manager.NamaData[15]) + "\n"
			+ "\n Jawaban Nomor 17: " + PlayerPrefs.GetString (manager.NamaData[16]) + "\n"
			+ "\n Jawaban Nomor 18: " + PlayerPrefs.GetString (manager.NamaData[17]) + "\n"
			+ "\n Jawaban Nomor 19: " + PlayerPrefs.GetString (manager.NamaData[18]) + "\n"
			+ "\n Jawaban Nomor 20: " + PlayerPrefs.GetString (manager.NamaData[19]) + "\n"
			+ "\n Jawaban Nomor 21: " + PlayerPrefs.GetString (manager.NamaData[20]) + "\n"
			+ "\n Jawaban Nomor 22: " + PlayerPrefs.GetString (manager.NamaData[21]) + "\n"

			+ "\n Jawaban Nomor 23: " + PlayerPrefs.GetString (manager.NamaData[22]) + "\n"


			+ "\n Jawaban Nomor 24: " + PlayerPrefs.GetString (manager.NamaData[23]) + "\n"

			/*
			+ "\n Jawaban Nomor 25: " + PlayerPrefs.GetString (manager.NamaData[24]) + "\n"
			+ "\n Jawaban Nomor 26: " + PlayerPrefs.GetString (manager.NamaData[25]) + "\n"
			+ "\n Jawaban Nomor 27: " + PlayerPrefs.GetString (manager.NamaData[26]) + "\n"
			+ "\n Jawaban Nomor 28: " + PlayerPrefs.GetString (manager.NamaData[27]) + "\n"
			+ "\n Jawaban Nomor 29: " + PlayerPrefs.GetString (manager.NamaData[28]) + "\n"
			+ "\n Jawaban Nomor 30: " + PlayerPrefs.GetString (manager.NamaData[29]) + "\n"
			+ "\n Jawaban Nomor 31: " + PlayerPrefs.GetString (manager.NamaData[30]) + "\n"
			+ "\n Jawaban Nomor 32: " + PlayerPrefs.GetString (manager.NamaData[31]) + "\n"
			+ "\n Jawaban Nomor 33: " + PlayerPrefs.GetString (manager.NamaData[32]) + "\n"
			+ "\n Jawaban Nomor 34: " + PlayerPrefs.GetString (manager.NamaData[33]) + "\n"
			+ "\n Jawaban Nomor 35: " + PlayerPrefs.GetString (manager.NamaData[34]) + "\n"
			+ "\n Jawaban Nomor 36: " + PlayerPrefs.GetString (manager.NamaData[35]) + "\n"
			+ "\n Jawaban Nomor 37: " + PlayerPrefs.GetString (manager.NamaData[36]) + "\n"
			+ "\n Jawaban Nomor 38: " + PlayerPrefs.GetString (manager.NamaData[37]) + "\n"
			+ "\n Jawaban Nomor 39: " + PlayerPrefs.GetString (manager.NamaData[38]) + "\n"
			+ "\n Jawaban Nomor 40: " + PlayerPrefs.GetString (manager.NamaData[39]) + "\n"
			+ "\n Jawaban Nomor 41: " + PlayerPrefs.GetString (manager.NamaData[40]) + "\n"
			+ "\n Jawaban Nomor 42: " + PlayerPrefs.GetString (manager.NamaData[41]) + "\n"
			+ "\n Jawaban Nomor 43: " + PlayerPrefs.GetString (manager.NamaData[42]) + "\n"
			+ "\n Jawaban Nomor 44: " + PlayerPrefs.GetString (manager.NamaData[43]) + "\n"
			*/
			;



		SmtpClient smtpServer = new SmtpClient ("smtp.gmail.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential ("fisikafluida@gmail.com","argamakmur") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback =
			delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
			return true;	
		};
		smtpServer.Send (mail);
		errorr.text = "The mail is Sent Succsessfully";
	}



}
