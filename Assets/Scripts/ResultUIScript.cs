using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultUIScript : MonoBehaviour {

	[SerializeField]
	Text averageText,averageInAguriText;

	void Start(){

		averageText.text = GameManeger.instance.AverageAge.ToString ("f1");
		averageInAguriText.text = GameManeger.instance.AverageInAguri.ToString ("f1");

	}

	public void PushBackButton(){
		GameManeger.instance.ClearResult ();
		SceneManager.LoadScene ("Input");
	}
}
