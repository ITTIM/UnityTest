using UnityEngine;
using System.Threading;

public class Sample3 : MonoBehaviour
{
	void OnGUI()
	{
		//使用按鈕來進行一次性的觸發
		if(GUI.Button(new Rect(0, 0, 100, 50), "Test"))
		{
			//即時創建一個新的執行緒, 這個執行緒會去運行ThreadMainFunc函式
			Loom.RunAsync(ThreadMainFunc);
		}
	}
	
	//執行緒真正的運行內容
	void ThreadMainFunc()
	{
		Debug.Log("This is thread message 123");
		/*
        由於Unity的規範, 副執行緒是不能使用UnityEngine裏頭的東西的
        所以我們這裡故意寫一行會讓Unity報錯的東西, 請視自己的測試需求
        正確移除註解符號
        */
		//gameobject.transform.Translate(1f, 0f, 0f);
	}
}