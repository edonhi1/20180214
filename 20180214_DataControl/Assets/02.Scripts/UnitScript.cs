using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {
    public enum UNITTRIBE
    {
        NEUTRAL=0, PROTOSS, ZERG, TERRAN
    }
    public UNITTRIBE unitTribe;
    public string unitName;
    public int hp;
    public int mp;
    public int atk;
    public int def;
    public int shd;     //보호막
    public float asp;       //공격속도
    public float msp;       //이동속도
    public float range;

	void Start () {
        gameObject.name = unitName;
	}
}
