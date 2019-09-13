using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class jing : MonoBehaviour {
	void Start () {
		restart();
	}
	
	int turn=1;
	int count=0;
	int[,] chess = new int[3, 3];

	void restart() {
		for (int i = 0; i < 3; ++i) {
			for (int j = 0; j < 3; ++j) {
				chess[i, j] = 0;
			}
		}
		turn = 1;
		count = 0;
	}
	
	int temp() {
		for(int i = 0; i < 3; ++i) {
			if (chess[i, 0] != 0 && chess[i,0]==chess[i, 1] && chess[i, 1] == chess[i, 2]) {
				return chess[i, 0];
			}
		}
		for (int i = 0; i < 3; ++i) {
			if (chess[0, i] != 0 && chess[0, i] == chess[1, i] && chess[1, i] == chess[2, i]) {
				return chess[0, i];
			}
		}
		if(chess[1,1]!=0&&
			chess[0,0]==chess[1,1]&&
			chess[1,1]==chess[2,2]||
			chess[0,2]==chess[1,1]&&
			chess[1,1]==chess[2,0]
			) {
			return chess[1, 1];
		}
		if (count == 9) return 3;
		return 0;
	}

	 void OnGUI() {
		if(GUI.Button(new Rect(525, 25, 100, 50),"开始")) {
			restart();
		}
		int result = temp();
		GUIStyle style = new GUIStyle {
			fontSize = 35
		};
		
		if(result == 1){
			GUI.Label(new Rect(550, 300, 100, 50), "1胜", style: style);
		}
		
		else if(result == 2){
			GUI.Label(new Rect(550, 300, 100, 50), "0胜", style: style);
		}
		else if (result == 3){
			GUI.Label(new Rect(550, 300, 100, 50), "平局", style: style);
		}

		for (int i = 0; i < 3; ++i) {
			for(int j = 0; j < 3; ++j) {
				if (chess[i, j] == 1) {
					GUI.Button(new Rect(500 + i * 50, 100 + j * 50, 50, 50), "1");
				}
				if (chess[i, j] == 2) {
					GUI.Button(new Rect(500 + i * 50, 100 + j * 50, 50, 50), "0");
				}
				if(GUI.Button(new Rect(500 + i * 50, 100 + j * 50, 50, 50), "")) {
					if (result == 0) {
						if (turn == 1) chess[i, j] = 1;
						else chess[i, j] = 2;
						count ++;
						turn = - turn;
					}
				}
			}
		}
	}
}


