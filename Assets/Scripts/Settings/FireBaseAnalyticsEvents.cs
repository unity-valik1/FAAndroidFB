using Firebase.Analytics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FireBaseAnalyticsEvents
{
    public static void EventsCharter(string charter)
    {
        FirebaseAnalytics.LogEvent(charter);
    }
}
