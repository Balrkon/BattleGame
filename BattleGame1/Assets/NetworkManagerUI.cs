using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : MonoBehaviour
{

	[SerializeField] private Button btnServer;
	[SerializeField] private Button btnHost;
	[SerializeField] private Button btnClieht;

	private void Awake() {

		
		btnServer.onClick.AddListener(() => {

			NetworkManager.Singleton.StartServer();
		});

		btnHost.onClick.AddListener(() => {
			NetworkManager.Singleton.StartHost();
		});

		btnClieht.onClick.AddListener(() => {
			NetworkManager.Singleton.StartClient();
		});

	}
}
 