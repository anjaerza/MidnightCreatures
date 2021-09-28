using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Botones : MonoBehaviour {
    public Button boton;
   


	// Use this for initialization
	void Start () {
		
	}
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
	
	// Update is called once per frame
	void Update () {
    
		
	}
}
