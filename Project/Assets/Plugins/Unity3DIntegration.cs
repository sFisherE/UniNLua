using System;
using System.Collections.Generic;
using UnityEngine;
class Unity3DIntegration
{
    const string Prefix = "@lua:";
    public static void Log(string str)
    {
        Debug.Log(Prefix + str);
    }
    public static void LogError(string str)
    {
        Debug.LogError(Prefix + str);
    }
    public static void LogWarning(string str)
    {
        Debug.LogWarning(Prefix + str);
    }

    public static void Log(string format, params object[] paramList)
    {
        Debug.Log(Prefix + string.Format(format as string, paramList));
    }
    public static void LogError(string format, params object[] paramList)
    {
        Debug.LogError(Prefix + string.Format(format as string, paramList));
    }
    public static void LogWarning(string format, params object[] paramList)
    {
        Debug.LogWarning(Prefix + string.Format(format as string, paramList));
    }

    public static void Assert(bool condition)
    {
        Assert(condition, string.Empty, true);
    }
    public static void Assert(bool condition, string assertString)
    {
        Assert(condition, assertString, false);
    }

    public static void Assert(bool condition, string assertString, bool pauseOnFail)
    {
        if (!condition)
        {
            Debug.LogError("assert failed! " + assertString);

            if (pauseOnFail)
                Debug.Break();
        }
    }
}

