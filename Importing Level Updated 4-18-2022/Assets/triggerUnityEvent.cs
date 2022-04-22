using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerUnityEvent : MonoBehaviour
{
	public UnityEvent OnTrigger;



	private void OnTriggerEnter2D(Collider2D col)
	{
		OnTrigger.Invoke();
		TimerCounter.instance.startTimer();
		ScoreManager.instance.startPoints();
	}
}
