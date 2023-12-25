void OnTriggerEnter(Collider other) {
    if(!other.CompareTag("SafeB")) {
        FailMission(); 
    }
}

void FailMission() {
    
    GameObject text = new GameObject("MissionFailedText", typeof(TextMesh));
    TextMesh txt = text.GetComponent<TextMesh>();
    txt.anchor = TextAnchor.MiddleCenter;  
    txt.fontSize = 72; 
    txt.text = "MISSION FAILED";
    text.transform.position = new Vector3(Screen.width/2f, Screen.height/2f, 0f);

    Destroy(text, 3f);
        
}
