using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {

        string[] phoneNumberInfo = phoneNumber.Split('-');

        return (phoneNumberInfo[0] == "212", phoneNumberInfo[1] == "555", phoneNumberInfo[2]);        
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