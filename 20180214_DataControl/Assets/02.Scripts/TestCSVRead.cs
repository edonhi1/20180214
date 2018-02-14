using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCSVRead : MonoBehaviour {
    public string csvFileName;
    public GameObject unitPrefab;

	void Awake () {
        List<Dictionary<string, object>> data = CSVReader.Read(csvFileName);
        Debug.Log(data.Count);
        //int j = Random.Range(0, 53);
        //Debug.Log("no." + j +
        //    " 이름: " + data[j]["유닛이름"] + "," +
        //    " 종족: " + data[j]["종족"] + "," +
        //    " 필요미네랄: " + data[j]["필요미네랄"] + "," +
        //    " 필요가스: " + data[j]["필요가스"]);

        //for (var i = 0; i < data.Count; i++)
        //{
        //    Debug.Log("no." + i +
        //        " 종족: " + data[i]["종족"] + "," +
        //        " 이름: " + data[i]["유닛이름"] + "," +
        //        " 필요미네랄: " + data[i]["필요미네랄"]);
        //}

        for (int i = 0; i < data.Count; i++)
        {
            GameObject unitObj = Instantiate(unitPrefab) as GameObject;
            UnitScript unitDetail = unitObj.GetComponent<UnitScript>();
            switch (data[i]["종족"].ToString())
            {
                case "프로토스":
                    unitDetail.unitTribe = UnitScript.UNITTRIBE.PROTOSS;
                    break;                
                case "저그":
                    unitDetail.unitTribe = UnitScript.UNITTRIBE.ZERG;
                    break;
                case "테란":
                    unitDetail.unitTribe = UnitScript.UNITTRIBE.TERRAN;
                    break;
            }
            unitDetail.unitName = data[i]["유닛이름"].ToString();
            unitDetail.hp = int.Parse(data[i]["체력"].ToString());
            unitDetail.mp = int.Parse(data[i]["마나"].ToString());
            unitDetail.atk = int.Parse(data[i]["공격력"].ToString());
            unitDetail.def = int.Parse(data[i]["방어력"].ToString());
            unitDetail.shd = int.Parse(data[i]["쉴드"].ToString());
            unitDetail.asp = float.Parse(data[i]["공격속도"].ToString());
            unitDetail.msp = float.Parse(data[i]["이동속도"].ToString());
            unitDetail.range = float.Parse(data[i]["사거리"].ToString());
        }
    }
}
