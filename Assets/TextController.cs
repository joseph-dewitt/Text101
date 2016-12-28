using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {


	public Text text;
	private enum States {cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			state_cell();
		}
		if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
	}
	
	void state_cell () {
		text.text = "You've awoken to find yourself on a thin cot on the floor " +
					"of a cell. A distant humming is causing the cell walls to " +
					"reverberate. The door is closed and locked. There's a thin " +
					"sheet tangled at your feet. On the iron grey wall to your left " +
					"is a square mirror.\n\n" + 
				"Press M to look at mirror.\n"+
				"Press S to look at sheets.\n"+
				"Press L to look at lock.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
	}

	void state_sheets_0 () {
		text.text = "After getting your feet untangled from the sheets " +
					"they're left in a pile on the cot. They're old, ragged and " +
					"thin, holes chewed in them by rats. You could perhaps hang yourself " +
					"with them, but there's nothing on the ceiling to tie them to.\n\n" +
				"Press R to return to roaming your cell.\n";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
}