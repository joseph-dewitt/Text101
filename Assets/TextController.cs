using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {


	public Text text;
	private enum States {cell, sheets_0, mirror, door_0, cell_mirror, sheets_1, door_1, freedom};
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
			state_sheets_0();
		}
		if (myState == States.mirror) {
			state_mirror();
		}
		if (myState == States.door_0) {
			state_door_0();
		}
		if (myState == States.cell_mirror) {
			state_cell_mirror ();
		}
		if (myState == States.sheets_1) {
			state_sheets_1();
		}
		if (myState == States.door_1) {
			state_door_1();
		}
		if (myState == States.freedom) {
			state_freedom ();
		}
	}
	
	void state_cell () {
		text.text = "You've awoken to find yourself on a thin cot on the floor " +
			"of a cell. A distant humming is causing the cell walls to " +
			"reverberate. The door is closed and locked. There's a thin " +
			"sheet tangled at your feet. On the iron grey wall to your left " +
			"is a square mirror.\n\n" + 
			"Press M to look at the mirror.\n" +
			"Press S to look at the sheets.\n" +
			"Press D to look at door.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.door_0;
		}
	}

	void state_sheets_0 () {
		text.text = "After getting your feet untangled from the sheets " +
			"they're left in a pile on the cot. They're old, ragged and " +
			"thin, holes chewed in them by rats. You could perhaps hang yourself " +
			"with them, but there's nothing on the ceiling to tie them to.\n\n" +
			"Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_mirror () {
		text.text = "The mirror is dirty and scratched, held " +
			"by a metal frame folded on the edges, which is cemented to the wall." +
			"You struggle against the thin metal on one side, and manage to fold " +
			"it back and slide the mirror out of the frame.\n\n" +
			"Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void state_door_0 () {
		text.text = "The door is flat, the same color and material as the walls, " +
			"and opens outwards. There is a peephole in the center of it, but looking " +
			"through it all you see is the blank opposite wall. It's just wide enough " +
			"that you might fit your arm through, as malnourished as you are.\n\n" +
			"Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_cell_mirror () {
		text.text = "You've awoken to find yourself on a thin cot on the floor " +
			"of a cell. A distant humming is causing the cell walls to " +
			"reverberate. The door is closed and locked. There's a thin " +
			"sheet tangled at your feet. In your hand is the " +
			"square mirror.\n\n" + 
			"Press S to look at the sheets.\n" +
			"Press D to look at door.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.door_1;
		}
	}

	void state_sheets_1 () {
		text.text = "After getting your feet untangled from the sheets " +
			"they're left in a pile on the cot. They're old, ragged and " +
			"thin, holes chewed in them by rats. You could perhaps hang yourself " +
			"with them, but there's nothing on the ceiling to tie them to.\n\n" +
			"Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void state_door_1 () {
		text.text = "You reach your hand through the peephole, holding " +
			"the mirror in it tightly. Your elbow scrapes and bleeds on " +
			"on the iron as you squeeze through as far as you can. Looking " +
			"at the mirror, you see the complex mechanism keeping the door shut." +
			" It is difficult and time consuming, but you eventually disengage the " +
			"lock.\n\n" +
			"Press F to leave the cell.";
		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.freedom;
		}
	}

	void state_freedom () {
		text.text = "The moment you step into the hallway, a guard " +
			"20 yards away shoots you in the head.\n" +
			"The end.\n\n" +
			"Press T to try again.";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell;
		}
	}
}





