
using UnityEngine;
using UnityEngine.Networking;
public class GameNetworkManager : NetworkManager
{

    public GameObject StratGameObject;
    public GameObject FPSGameObject;

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        GameObject player = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
       
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
