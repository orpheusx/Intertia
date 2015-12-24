using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	public Transform warpTarget;

	IEnumerator OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("fading out!!!");

		GameObject gobj = GameObject.FindGameObjectWithTag ("ScreenFader");
		if (gobj == null)
			Debug.Log ("no gameobject tagged");
		ScreenFader sf = gobj.GetComponent<ScreenFader> ();
		if (sf == null)
			Debug.Log ("no screen fader found by tag");

		yield return StartCoroutine (sf.FadeToBlack ());

		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;
		
		Debug.Log ("fading in !!!");
		yield return StartCoroutine(sf.FadeToClear());

		Debug.Log ("Transition complete.");
	}

}
