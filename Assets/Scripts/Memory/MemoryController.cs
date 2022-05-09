using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI.Button;

public class MemoryController : MonoBehaviour
{
	[SerializeField]
	private Sprite Background;
	
	public Sprite[] puzzles;
	
	public List<Sprite> gamePuzzles = new List<Sprite>();
	
	public List<UnityEngine.UI.Button> btns = new List<UnityEngine.UI.Button>();
	
	private bool firstGuess, secondGuess;
	
	private int countGuesses;
	private int countCorrectGuesses;
	private int gameGuesses;
	
	private int firstGuessIndex, secondGuessIndex;
	
	private string firstGuessPuzzle, secondGuessPuzzle;
	
	void Awake() {
	}
	
	void Start() {
		GetButtons();
		AddListeners();
		AddGamePuzzles();
		Shuffle (gamePuzzles);
		gameGuesses = gamePuzzles.Count/2;
	}
	
	void GetButtons(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");
		
		for(int i = 0; i < objects.Length; i++) {
			btns.Add(objects[i].GetComponent<UnityEngine.UI.Button>());
			btns[i].image.sprite = Background;
		}
	}
	
	void AddGamePuzzles() {
		int looper = btns.Count;
		int index = 0;
		
		for(int i = 0; i < looper; i++) {
			if(index == looper/2) {
				index = 0;
			}
			gamePuzzles.Add(puzzles[index]);
			
			index++;
		}
	}
	
	void AddListeners() {
		foreach (UnityEngine.UI.Button btn in btns){
			btn.onClick.AddListener(() => PickAPuzzle());
		}
	}
	
	public void PickAPuzzle() {
		if(!firstGuess) {
			
			firstGuess = true;
			
			firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			
			firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
			
			btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
			
		} else if (!secondGuess) {
			secondGuess = true;
			
			secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			
			secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
			
			btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
			
			countGuesses++;
			
			StartCoroutine(CheckIfThePuzzlesMatch());
		}
	}
	
	IEnumerator CheckIfThePuzzlesMatch() {
		yield return new WaitForSeconds (0.5f);
		
		if(firstGuessPuzzle == secondGuessPuzzle) {
		
			yield return new WaitForSeconds (0.3f);
			
			btns[firstGuessIndex].interactable = false;
			btns[secondGuessIndex].interactable = false;
			
			btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
			btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);
			
			CheckIfTheGameIsFinished();
		} else {
			btns[firstGuessIndex].image.sprite = Background;
			btns[secondGuessIndex].image.sprite = Background;
		}
		
		yield return new WaitForSeconds(0.3f);
		
		firstGuess = secondGuess = false;
	}
	
	void CheckIfTheGameIsFinished() {
		countCorrectGuesses++;
		
		if(countCorrectGuesses == gameGuesses) {
			Debug.Log("done");
		}
	}
	
	void Shuffle(List<Sprite> list) {
		for(int i = 0; i < list.Count; i++) {
			Sprite tmp = list[i];
			int randomIndex = Random.Range(i, list.Count);
			list[i] = list[randomIndex];
			list[randomIndex] = tmp;
		}
	}
}
