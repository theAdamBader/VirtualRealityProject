#pragma strict
var handleIsJammed : boolean = false;
var handle : Transform;
var knob : Transform;
var box : Transform;
//
private var turnKnob : boolean = false;
private var randomRotation : float = 0.00;
private var openDoor : boolean = false;
private var P1 : float;
private var P2 : float;
private var P3 : float;


function ToggleDoor () {
	P1 = 0.0;
	P2 = 0.0;
	if(openDoor == false) {
	openDoor = true;
	if(handleIsJammed == false) {
	yield WaitForSeconds(0.6);
	}
	box.GetComponent.<HingeJoint>().spring.targetPosition = 130;
	} else {
	box.GetComponent.<HingeJoint>().spring.targetPosition = 0;
	openDoor = false;
	}
}
function TurnKnob () {
	P3 = 0.00;
	randomRotation = Random.Range(0.0, 350.0);
	turnKnob = true;
	yield WaitForSeconds(0.5);
	turnKnob = false;
}

function Update () {
	if(handleIsJammed == false) {
	if(openDoor == true) {
	P1 += Time.deltaTime;
	handle.localEulerAngles.z = Mathf.Lerp(handle.localEulerAngles.z, 90.0, P1);
	} else if(openDoor == false && box.GetComponent.<HingeJoint>().angle < 0.5) {
	P2 += Time.deltaTime;
	handle.localEulerAngles.z = Mathf.Lerp(handle.localEulerAngles.z, 0.0, P2);
	}
	}
	
	if(turnKnob == true) {
	P3 += Time.deltaTime;
	knob.localEulerAngles.z = Mathf.Lerp(knob.localEulerAngles.z, randomRotation, P3);
	}
	
	if(Input.GetMouseButtonDown(0)) {
		var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
    	var hit : RaycastHit;
    	if (Physics.Raycast (ray, hit, 10.0)) {
    		if(hit.collider.transform.IsChildOf(transform)) {
        	//Debug.DrawLine (ray.origin, hit.point);
        	print(hit.collider.name);
        	var hitObject = hit.collider.name;
        	
        	if(hitObject == "Handle") {
        	ToggleDoor();
        	}
        	
        	if(hitObject == "knob" && turnKnob == false) {
        	TurnKnob();
        	}
        	
        	}
        	 
    	}
    }
    
}