using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleSheetsToUnity;

public class GetMeData : MonoBehaviour {

    private const string SHEET_ID = "13q-FhnZO64FzCASsVsMZ-OZtVz0IUmiS5QGSaNt9B1s";
    private const string SHEET_NAME = "Sheet1";

    // Use this for initialization
    void Start () {

        SpreadsheetManager.Read(new GSTU_Search(SHEET_ID, SHEET_NAME), DaTigaIsInDaCage);

	}


    void DaTigaIsInDaCage(GstuSpreadSheet spreadsheetRef)
    {
        Debug.Log(spreadsheetRef["C3"].value);

        List<string> list1 = new List<string>()
        {
            "A",
            "B",
            "",
            "D"
        };

        List<string> list2 = new List<string>()
        {
            "",
            "2",
            "3"
        };

        List<List<string>> values = new List<List<string>>() { list1, list2 };

        SpreadsheetManager.Append(new GSTU_Search(SHEET_ID, SHEET_NAME), new ValueRange(values), null);

        // What should happen is you should check if value exists. If it doesn't, append a row with all values initialized.
    }
}
