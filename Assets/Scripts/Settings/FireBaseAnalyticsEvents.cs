using Firebase.Analytics;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class FireBaseAnalyticsEvents
{

    public static void EventsNewGame(string NewGame, int ii, int oo, int aa)
    {
        var id = new Parameter("NewGame", ii);
        var gg = new Parameter("NewGame", oo);
        var SS = new Parameter("NewGame", aa);
        FirebaseAnalytics.LogEvent("NewGame", id, gg, SS);

    }
    public static void EventsNewGame1(ActiveMenu activeMenu)
    {
        FirebaseAnalytics.LogEvent("NewGame",
            new Parameter("id", activeMenu.ii),
            new Parameter("gg", activeMenu.oo),
            new Parameter("ff", activeMenu.aa));

    }
    public static void EventsNewGameStart(string NewGameStart)
    {
        FirebaseAnalytics.LogEvent(NewGameStart);
    }
    public static void EventsNewGameClose(string NewGameClose)
    {
        FirebaseAnalytics.LogEvent(NewGameClose);
    }
    public static void EventsContinueGame(string ContinueGame)
    {
        FirebaseAnalytics.LogEvent(ContinueGame);
    }
    public static void EventsLoadGame1(string LoadGame1)
    {
        FirebaseAnalytics.LogEvent(LoadGame1);
    }
    public static void EventsLoadGame2(string LoadGame2)
    {
        FirebaseAnalytics.LogEvent(LoadGame2);
    }
    public static void EventsLoadGame3(string LoadGame3)
    {
        FirebaseAnalytics.LogEvent(LoadGame3);
    }
    public static void EventsLoadGame4(string LoadGame4)
    {
        FirebaseAnalytics.LogEvent(LoadGame4);
    }
    public static void EventsLoadGame5(string LoadGame5)
    {
        FirebaseAnalytics.LogEvent(LoadGame5);
    }
    public static void EventsLoadGameDelete(string LoadGameDelete)
    {
        FirebaseAnalytics.LogEvent(LoadGameDelete);
    }
    public static void EventsAchievements(string Achievements)
    {
        FirebaseAnalytics.LogEvent(Achievements);
    }
    public static void EventsSettings(string Settings)
    {
        FirebaseAnalytics.LogEvent(Settings);
    }
    public static void EventsTyphography(string Typhography)
    {
        FirebaseAnalytics.LogEvent(Typhography);
    }
    public static void EventsTyphographySmall(string TyphographySmall)
    {
        FirebaseAnalytics.LogEvent(TyphographySmall);
    }
    public static void EventsTyphographyMiddle(string TyphographyMiddle)
    {
        FirebaseAnalytics.LogEvent(TyphographyMiddle);
    }
    public static void EventsTyphographyLarge(string TyphographyLarge)
    {
        FirebaseAnalytics.LogEvent(TyphographyLarge);
    }
    public static void EventsTheme(string Theme)
    {
        FirebaseAnalytics.LogEvent(Theme);
    }
    public static void EventsThemeLight(string ThemeLight)
    {
        FirebaseAnalytics.LogEvent(ThemeLight);
    }
    public static void EventsThemeDark(string ThemeDark)
    {
        FirebaseAnalytics.LogEvent(ThemeDark);
    }
    public static void EventsMusicSounds(string MusicSounds)
    {
        FirebaseAnalytics.LogEvent(MusicSounds);
    }
    public static void EventsMusicButtonOn(string MusicButtonOn)
    {
        FirebaseAnalytics.LogEvent(MusicButtonOn);
    }
    public static void EventsMusicButtonOff(string MusicButtonOff)
    {
        FirebaseAnalytics.LogEvent(MusicButtonOff);
    }
    public static void EventsSoundsButtonOn(string SoundsButtonOn)
    {
        FirebaseAnalytics.LogEvent(SoundsButtonOn);
    }
    public static void EventsSoundsButtonOff(string SoundsButtonOff)
    {
        FirebaseAnalytics.LogEvent(SoundsButtonOff);
    }
    public static void EventsNotificationOn(string NotificationOn)//?
    {
        FirebaseAnalytics.LogEvent(NotificationOn);
    }
    public static void EventsNotificationOff(string NotificationOff)//?
    {
        FirebaseAnalytics.LogEvent(NotificationOff);
    }
    public static void EventsAbout(string About)
    {
        FirebaseAnalytics.LogEvent(About);
    }
    public static void EventsOnboarding_1(string Onboarding_1)//?
    {
        FirebaseAnalytics.LogEvent(Onboarding_1);
    }
    public static void EventsOnboarding_2(string Onboarding_2)//?
    {
        FirebaseAnalytics.LogEvent(Onboarding_2);
    }
    public static void EventsOnboarding_3(string Onboarding_3)//?
    {
        FirebaseAnalytics.LogEvent(Onboarding_3);
    }
    public static void EventsSave_Button(string Save_Button)
    {
        FirebaseAnalytics.LogEvent(Save_Button);
    }
    public static void EventsSave_Button_Buy(string Save_Button_Buy)
    {
        FirebaseAnalytics.LogEvent(Save_Button_Buy);
    }
    public static void EventsPurchase_Continue(string Purchase_Continue)//?
    {
        FirebaseAnalytics.LogEvent(Purchase_Continue);
    }
    public static void EventsPurchase_Successfull(string Purchase_Successfull)//?
    {
        FirebaseAnalytics.LogEvent(Purchase_Successfull);
    }
    public static void EventsWinGame(string WinGame)
    {
        FirebaseAnalytics.LogEvent(WinGame);
    }
}
