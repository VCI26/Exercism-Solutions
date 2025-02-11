using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = false;
        bool isFake = false;
        
        string dialingCode = phoneNumber.Split('-')[0];
        string prefixCode = phoneNumber.Split('-')[1];
        string number = phoneNumber.Split('-')[2];

        if (dialingCode == "212") { isNewYork = true;}
        if (prefixCode == "555") { isFake = true;}

        return (isNewYork, isFake, number);        
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}

//// name items in declaration
//(bool success, string message) results = (true, "well done!");
//bool mySuccess = results.success;
//string myMessage = results.message;

//// name items in creating expression
//var results2 = (success: true, message: "well done!");
//bool mySuccess2 = results2.success;
//string myMessage2 = results2.message;