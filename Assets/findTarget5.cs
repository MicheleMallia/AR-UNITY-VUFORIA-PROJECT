using UnityEngine;
using System.Collections;
using Vuforia;

public class findTarget5 : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;


	// Use this for initialization
	void Start ()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();

		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}               

	// Update is called once per frame
	void Update ()
	{
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			OnTrackingFound();
		}
	}
	private void OnTrackingFound()
	{

	}
}