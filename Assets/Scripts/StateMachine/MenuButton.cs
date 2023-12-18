using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuButton : MonoBehaviour
{
	[SerializeField] MenuButtonController menuButtonController;
	[SerializeField] Animator animator;
	[SerializeField] AnimatorFunctions animatorFunctions;
	[SerializeField] int thisIndex;

	public UnityEvent btnEvent;

    // Update is called once per frame
    void Update()
    {
		if(menuButtonController.index == thisIndex)
		{
			animator.SetBool ("Btn_Select_Anim", true);
			if(Input.GetAxis ("Submit") == 1){
				animator.SetBool ("Btn_Pick_Anim", true);

				btnEvent.Invoke();
				//GetComponent<Button>().onClick.Invoke();
				/*
				if (animatorFunctions.CompareTag("StartBtn"))
				{
					btnEvent.Invoke();
				}
				if (animatorFunctions.CompareTag("OptionBtn"))
				{
					Destroy(other.gameObject);
				}
				if (animatorFunctions.CompareTag("QuitBtn"))
				{
					Destroy(other.gameObject);
				} */
			}
			else if (animator.GetBool ("Btn_Pick_Anim")){
				animator.SetBool ("Btn_Pick_Anim", false);
				animatorFunctions.disableOnce = true;
			}
		}else{
			animator.SetBool ("Btn_Select_Anim", false);
		}
    }
}
