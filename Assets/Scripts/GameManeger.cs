using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManeger : MonoBehaviour {

	List<int> ageList = new List<int>();//年齢のリスト
	float averageAge = 0;
	float averageInAguri = 0;

	int aguriAge = 27;

	public static GameManeger instance = null;

	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

	public float AverageAge{
		get{
			CalculateAverage ();
			return averageAge;
		}
	}
	public float AverageInAguri{
		get{
			CalculateAverage ();
			return averageInAguri;
		}
	}


	public void AddAge(int input){
		ageList.Add (input);
	}

	public void FinishInput(){
		CalculateAverage ();
	}

	public void ClearResult(){
		averageAge = 0;
		averageInAguri = 0;
		ageList.Clear ();
	}

	void CalculateAverage(){
		int count = ageList.Count;
		if (count <= 0) {
			return;
		}
		int sum = 0;
		foreach (int age in ageList) {
			sum += age;
		}
		averageAge = ((float)sum) / count;
		int sumInAguri = sum + aguriAge;
		averageInAguri = ((float)sumInAguri) / (count + 1);
	}
}
