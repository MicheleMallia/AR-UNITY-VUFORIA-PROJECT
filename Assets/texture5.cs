using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texture5 : MonoBehaviour {


	IEnumerator Start(string urlTexture)
	{
		// Start a download of the given URL
		using (WWW www = new WWW(urlTexture))
		{
			// Wait for download to complete
			yield return www;

			// assign texture
			Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = www.texture;

			Debug.Log ("SCARICATO 5 --> " + urlTexture);

			//take measure of downloaded image
			float width = www.texture.width;
			float height = www.texture.height;

			//resize plane
			float resizeX = 0.15f * (width / height);
			transform.localScale = new Vector3 (0.0f + resizeX, 0.15f, 0.15f);

			//rotate image
			Vector3 rot = transform.rotation.eulerAngles;
			rot = new Vector3(rot.x,rot.y+180,rot.z);
			transform.rotation = Quaternion.Euler(rot);
		}
	}
}
