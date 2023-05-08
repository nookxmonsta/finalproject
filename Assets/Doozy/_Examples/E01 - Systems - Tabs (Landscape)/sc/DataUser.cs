using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUser : MonoBehaviour
{
    private ArrayList dataUser = new ArrayList(); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addUser(User user)
    {
        dataUser.Add(user); 
    }

    public void removeUser(User user)
    {
        dataUser.Remove(user);
    }
}
