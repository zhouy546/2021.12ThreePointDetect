using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YunqiLibrary;
public class TCPtest : MonoBehaviour
{
    TCP_Client tCP_Client;
    // Start is called before the first frame update
    void Start()
    {
        tCP_Client = new TCP_Client(tcpListening);
  

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tCP_Client.TCPSend("192.168.110.26", 29010, "123");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            tCP_Client.TCPSenHex("192.168.110.26", 29010, "09 03 05 33");
        }
    }

    void tcpListening(string str)
    {
        Debug.Log(str);
    }
}
