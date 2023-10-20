using KorYmeLibrary.Attributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttributes : MonoBehaviour
{
    [Button]
    public void Test()
    {
        Debug.Log("C'est la bonne fonction");
    }
}
