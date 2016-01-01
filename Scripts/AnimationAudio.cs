using UnityEngine;
using System.Collections;

public class AnimationAudio : StateMachineBehaviour {

	AudioSource audioSource;

	public void init() {
		if(audioSource==null)
			audioSource = GameObject.FindWithTag ("PlayerWalkAudio").GetComponent<AudioSource> ();
	}
	
	private void play() {
		init ();
		audioSource.PlayDelayed (0.1f);
	}

	private void stop() {
		if (audioSource!=null)
		    audioSource.Stop ();
	}

	override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		play ();
	}
	
	override public void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		stop ();
	}
	
	//public virtual void OnStateIK (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//}
	
	override public void OnStateMachineEnter (Animator animator, int stateMachinePathHash)
	{
        //play ();
        Debug.Log("onStateMachineEnter called. Do init once here?");
	}
	
	override public void OnStateMachineExit (Animator animator, int stateMachinePathHash)
	{
        Debug.Log("onStateMachineExit called. Clean up resources?");
		//stop ();
	}
	
	//public virtual void OnStateMove (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//}
	//
	//public virtual void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	//{
	//}
}
