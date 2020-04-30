using UnityEngine;
using System.Threading;

public class MultiThreadSample4 : MonoBehaviour
{
	//因為這不是一個用完就拋棄的執行緒, 所以宣告成類別變數, 方便主動關閉
	Thread thread;
	
	void Start()
	{
		//創建並立刻執行thread
		thread = Loom.RunAsync(ThreadMainFunc);
		thread.Start();
	}
	
	void ThreadMainFunc()
	{
		//這裏我們使用無窮迴圈讓執行緒永久存在
		while(true)
		{
			Debug.Log("This is thread message 123");
			//這種永久存在的執行緒, 要適當讓他進入沉睡, 否則Abort關不掉這個執行緒
			Thread.Sleep(1);
		}
	}
	
	//當程式被關閉的時候, 主動關閉執行緒
	void OnApplicationQuit()
	{
		thread.Abort();
	}
}