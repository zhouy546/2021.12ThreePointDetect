using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YunqiLibrary;
public class UdpTest : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        UDP udp = new UDP(29010, callBack);
        udp.udp_Send("ini", "192.168.110.26", 29010);

        udp.udp_Send("ÄãºÃ", "192.168.110.26", 29010);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void callBack(string s)
    {
        Debug.Log(s);
    }
}
