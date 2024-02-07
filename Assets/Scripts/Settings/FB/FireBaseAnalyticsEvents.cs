using Firebase.Analytics;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class FireBaseAnalyticsEvents
{

    //public static void EventsNewGame(string NewGame, int ii, int oo, int aa)
    //{
    //    var id = new Parameter("NewGame", ii);
    //    var gg = new Parameter("NewGame", oo);
    //    var SS = new Parameter("NewGame", aa);
    //    FirebaseAnalytics.LogEvent("NewGame", id, gg, SS);

    //}
    public static void EventsNewGame1(string NewGame, string gg)
    {
        FirebaseAnalytics.LogEvent("NewGame",
            new Parameter("timer", gg));
        //FirebaseAnalytics.LogEvent("NewGame",
        //    new Parameter("id", activeMenu.ii),
        //    new Parameter("gg", activeMenu.oo),
        //    new Parameter("ff", activeMenu.aa));

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
    public static void EventsAbout(string About)
    {
        FirebaseAnalytics.LogEvent(About);
    }
    public static void EventsOnboarding_1Button(string Onboarding_1Button, string timer)
    {
        FirebaseAnalytics.LogEvent("Onboarding_1Button",
            new Parameter("timer", timer));
    }
    public static void EventsOnboarding_2Button(string Onboarding_2Button, string timer)
    {
        FirebaseAnalytics.LogEvent("Onboarding_2Button",
            new Parameter("timer", timer));
    }
    public static void EventsOnboarding_3Button(string Onboarding_3Button, string timer)
    {
        FirebaseAnalytics.LogEvent("Onboarding_3Button",
            new Parameter("timer", timer));
    }
    public static void EventsOnboarding_Swipe(string Onboarding_Swipe)
    {
        FirebaseAnalytics.LogEvent("Onboarding_Swipe");
    }
    public static void EventsOnboardingSwipeBuy(string EventsOnboardingSwipeBuy)
    {
        FirebaseAnalytics.LogEvent("EventsOnboardingSwipeBuy");
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
    public static void EventsScreen_1(string Screen_1)
    {
        FirebaseAnalytics.LogEvent(Screen_1);
    }
    public static void EventsScreen_1_0_1(string Screen_1_0_1)
    {
        FirebaseAnalytics.LogEvent(Screen_1_0_1);
    }
    public static void EventsScreen_1_0_2(string Screen_1_0_2)
    {
        FirebaseAnalytics.LogEvent(Screen_1_0_2);
    }
    public static void EventsScreen_2(string Screen_2)
    {
        FirebaseAnalytics.LogEvent(Screen_2);
    }
    public static void EventsScreen_2_0_1(string Screen_2_0_1)
    {
        FirebaseAnalytics.LogEvent(Screen_2_0_1);
    }
    public static void EventsScreen_2_0_2(string Screen_2_0_2)
    {
        FirebaseAnalytics.LogEvent(Screen_2_0_2);
    }
    public static void EventsScreen_3(string Screen_3)
    {
        FirebaseAnalytics.LogEvent(Screen_3);
    }
    public static void EventsScreen_4(string Screen_4)
    {
        FirebaseAnalytics.LogEvent(Screen_4);
    }
    public static void EventsScreen_5(string Screen_5)
    {
        FirebaseAnalytics.LogEvent(Screen_5);
    }
    public static void EventsScreen_6(string Screen_6)
    {
        FirebaseAnalytics.LogEvent(Screen_6);
    }
    public static void EventsScreen_6_0_1(string Screen_6_0_1)
    {
        FirebaseAnalytics.LogEvent(Screen_6_0_1);
    } 
    public static void EventsScreen_6_0_2(string Screen_6_0_2)
    {
        FirebaseAnalytics.LogEvent(Screen_6_0_2);
    }
    public static void EventsScreen_7(string Screen_7)
    {
        FirebaseAnalytics.LogEvent(Screen_7);
    }
    public static void EventsScreen_8(string Screen_8)
    {
        FirebaseAnalytics.LogEvent(Screen_8);
    }
    public static void EventsScreen_9(string Screen_9)
    {
        FirebaseAnalytics.LogEvent(Screen_9);
    }
    public static void EventsScreen_10(string Screen_10)
    {
        FirebaseAnalytics.LogEvent(Screen_10);
    }
    public static void EventsScreen_11(string Screen_11)
    {
        FirebaseAnalytics.LogEvent(Screen_11);
    }
    public static void EventsScreen_12(string Screen_12)
    {
        FirebaseAnalytics.LogEvent(Screen_12);
    }
    public static void EventsScreen_13(string Screen_13)
    {
        FirebaseAnalytics.LogEvent(Screen_13);
    }
    public static void EventsScreen_14(string Screen_14)
    {
        FirebaseAnalytics.LogEvent(Screen_14);
    }
    public static void EventsScreen_15(string Screen_15)
    {
        FirebaseAnalytics.LogEvent(Screen_15);
    }
    public static void EventsScreen_16(string Screen_16)
    {
        FirebaseAnalytics.LogEvent(Screen_16);
    }
    public static void EventsScreen_17(string Screen_17)
    {
        FirebaseAnalytics.LogEvent(Screen_17);
    }
    public static void EventsScreen_18(string Screen_18)
    {
        FirebaseAnalytics.LogEvent(Screen_18);
    }
    public static void EventsScreen_19(string Screen_19)
    {
        FirebaseAnalytics.LogEvent(Screen_19);
    }
    public static void EventsScreen_20(string Screen_20)
    {
        FirebaseAnalytics.LogEvent(Screen_20);
    }
    public static void EventsScreen_21(string Screen_21)
    {
        FirebaseAnalytics.LogEvent(Screen_21);
    }
    public static void EventsScreen_22(string Screen_22)
    {
        FirebaseAnalytics.LogEvent(Screen_22);
    }
    public static void EventsScreen_23(string Screen_23)
    {
        FirebaseAnalytics.LogEvent(Screen_23);
    }
    public static void EventsScreen_24(string Screen_24)
    {
        FirebaseAnalytics.LogEvent(Screen_24);
    }
    public static void EventsScreen_25(string Screen_25)
    {
        FirebaseAnalytics.LogEvent(Screen_25);
    }
    public static void EventsScreen_26(string Screen_26)
    {
        FirebaseAnalytics.LogEvent(Screen_26);
    }
    public static void EventsScreen_27(string Screen_27)
    {
        FirebaseAnalytics.LogEvent(Screen_27);
    }
    public static void EventsScreen_28(string Screen_28)
    {
        FirebaseAnalytics.LogEvent(Screen_28);
    }
    public static void EventsScreen_29(string Screen_29)
    {
        FirebaseAnalytics.LogEvent(Screen_29);
    }
    public static void EventsScreen_30(string Screen_30)
    {
        FirebaseAnalytics.LogEvent(Screen_30);
    }
    public static void EventsScreen_31(string Screen_31)
    {
        FirebaseAnalytics.LogEvent(Screen_31);
    }
    public static void EventsScreen_32(string Screen_32)
    {
        FirebaseAnalytics.LogEvent(Screen_32);
    }
    public static void EventsScreen_33(string Screen_33)
    {
        FirebaseAnalytics.LogEvent(Screen_33);
    }
    public static void EventsScreen_34(string Screen_34)
    {
        FirebaseAnalytics.LogEvent(Screen_34);
    }
    public static void EventsScreen_35(string Screen_35)
    {
        FirebaseAnalytics.LogEvent(Screen_35);
    }
    public static void EventsScreen_36(string Screen_36)
    {
        FirebaseAnalytics.LogEvent(Screen_36);
    }
    public static void EventsScreen_37(string Screen_37)
    {
        FirebaseAnalytics.LogEvent(Screen_37);
    }
    public static void EventsScreen_38(string Screen_38)
    {
        FirebaseAnalytics.LogEvent(Screen_38);
    }
    public static void EventsScreen_39(string Screen_39)
    {
        FirebaseAnalytics.LogEvent(Screen_39);
    }
    public static void EventsScreen_40(string Screen_40)
    {
        FirebaseAnalytics.LogEvent(Screen_40);
    }
    public static void EventsScreen_41(string Screen_41)
    {
        FirebaseAnalytics.LogEvent(Screen_41);
    }
    public static void EventsScreen_42(string Screen_42)
    {
        FirebaseAnalytics.LogEvent(Screen_42);
    }
    public static void EventsScreen_43(string Screen_43)
    {
        FirebaseAnalytics.LogEvent(Screen_43);
    }
    public static void EventsScreen_44(string Screen_44)
    {
        FirebaseAnalytics.LogEvent(Screen_44);
    }
    public static void EventsScreen_45(string Screen_45)
    {
        FirebaseAnalytics.LogEvent(Screen_45);
    }
    public static void EventsScreen_46(string Screen_46)
    {
        FirebaseAnalytics.LogEvent(Screen_46);
    }
    public static void EventsScreen_47(string Screen_47)
    {
        FirebaseAnalytics.LogEvent(Screen_47);
    }
    public static void EventsScreen_48(string Screen_48)
    {
        FirebaseAnalytics.LogEvent(Screen_48);
    }
    public static void EventsScreen_49(string Screen_49)
    {
        FirebaseAnalytics.LogEvent(Screen_49);
    }
    public static void EventsScreen_50(string Screen_50)
    {
        FirebaseAnalytics.LogEvent(Screen_50);
    }
    public static void EventsScreen_51(string Screen_51)
    {
        FirebaseAnalytics.LogEvent(Screen_51);
    }
    public static void EventsScreen_52(string Screen_52)
    {
        FirebaseAnalytics.LogEvent(Screen_52);
    }
    public static void EventsScreen_53(string Screen_53)
    {
        FirebaseAnalytics.LogEvent(Screen_53);
    }
    public static void EventsScreen_54(string Screen_54)
    {
        FirebaseAnalytics.LogEvent(Screen_54);
    }
    public static void EventsScreen_55(string Screen_55)
    {
        FirebaseAnalytics.LogEvent(Screen_55);
    }
    public static void EventsScreen_56(string Screen_56)
    {
        FirebaseAnalytics.LogEvent(Screen_56);
    }
    public static void EventsScreen_57(string Screen_57)
    {
        FirebaseAnalytics.LogEvent(Screen_57);
    }
    public static void EventsScreen_58(string Screen_58)
    {
        FirebaseAnalytics.LogEvent(Screen_58);
    }
    public static void EventsScreen_59(string Screen_59)
    {
        FirebaseAnalytics.LogEvent(Screen_59);
    }
    public static void EventsScreen_60(string Screen_60)
    {
        FirebaseAnalytics.LogEvent(Screen_60);
    }
    public static void EventsScreen_61(string Screen_61)
    {
        FirebaseAnalytics.LogEvent(Screen_61);
    }
    public static void EventsScreen_62(string Screen_62)
    {
        FirebaseAnalytics.LogEvent(Screen_62);
    }
    public static void EventsScreen_63(string Screen_63)
    {
        FirebaseAnalytics.LogEvent(Screen_63);
    }
    public static void EventsScreen_64(string Screen_64)
    {
        FirebaseAnalytics.LogEvent(Screen_64);
    }
    public static void EventsScreen_65(string Screen_65)
    {
        FirebaseAnalytics.LogEvent(Screen_65);
    }
    public static void EventsScreen_66(string Screen_66)
    {
        FirebaseAnalytics.LogEvent(Screen_66);
    }
    public static void EventsScreen_67(string Screen_67)
    {
        FirebaseAnalytics.LogEvent(Screen_67);
    }
    public static void EventsScreen_68(string Screen_68)
    {
        FirebaseAnalytics.LogEvent(Screen_68);
    }
    public static void EventsScreen_69(string Screen_69)
    {
        FirebaseAnalytics.LogEvent(Screen_69);
    }
    public static void EventsScreen_70(string Screen_70)
    {
        FirebaseAnalytics.LogEvent(Screen_70);
    }
    public static void EventsScreen_71(string Screen_71)
    {
        FirebaseAnalytics.LogEvent(Screen_71);
    }
    public static void EventsScreen_72(string Screen_72)
    {
        FirebaseAnalytics.LogEvent(Screen_72);
    }
    public static void EventsScreen_73(string Screen_73)
    {
        FirebaseAnalytics.LogEvent(Screen_73);
    }
    public static void EventsScreen_74(string Screen_74)
    {
        FirebaseAnalytics.LogEvent(Screen_74);
    }
    public static void EventsScreen_75(string Screen_75)
    {
        FirebaseAnalytics.LogEvent(Screen_75);
    }
    public static void EventsScreen_76(string Screen_76)
    {
        FirebaseAnalytics.LogEvent(Screen_76);
    }
    public static void EventsScreen_77(string Screen_77)
    {
        FirebaseAnalytics.LogEvent(Screen_77);
    }
    public static void EventsScreen_78(string Screen_78)
    {
        FirebaseAnalytics.LogEvent(Screen_78);
    }
    public static void EventsScreen_79(string Screen_79)
    {
        FirebaseAnalytics.LogEvent(Screen_79);
    }
    public static void EventsScreen_80(string Screen_80)
    {
        FirebaseAnalytics.LogEvent(Screen_80);
    }
    public static void EventsScreen_81(string Screen_81)
    {
        FirebaseAnalytics.LogEvent(Screen_81);
    }
    public static void EventsScreen_82(string Screen_82)
    {
        FirebaseAnalytics.LogEvent(Screen_82);
    }
    public static void EventsScreen_83(string Screen_83)
    {
        FirebaseAnalytics.LogEvent(Screen_83);
    }
    public static void EventsScreen_84(string Screen_84)
    {
        FirebaseAnalytics.LogEvent(Screen_84);
    }
    public static void EventsScreen_85(string Screen_85)
    {
        FirebaseAnalytics.LogEvent(Screen_85);
    }
    public static void EventsScreen_86(string Screen_86)
    {
        FirebaseAnalytics.LogEvent(Screen_86);
    }
    public static void EventsScreen_87(string Screen_87)
    {
        FirebaseAnalytics.LogEvent(Screen_87);
    }
    public static void EventsScreen_88(string Screen_88)
    {
        FirebaseAnalytics.LogEvent(Screen_88);
    }
    public static void EventsScreen_89(string Screen_89)
    {
        FirebaseAnalytics.LogEvent(Screen_89);
    }
    public static void EventsScreen_90(string Screen_90)
    {
        FirebaseAnalytics.LogEvent(Screen_90);
    }
    public static void EventsScreen_91(string Screen_91)
    {
        FirebaseAnalytics.LogEvent(Screen_91);
    }
    public static void EventsScreen_92(string Screen_92)
    {
        FirebaseAnalytics.LogEvent(Screen_92);
    }
    public static void EventsScreen_93(string Screen_93)
    {
        FirebaseAnalytics.LogEvent(Screen_93);
    }
    public static void EventsScreen_94(string Screen_94)
    {
        FirebaseAnalytics.LogEvent(Screen_94);
    }
    public static void EventsScreen_95(string Screen_95)
    {
        FirebaseAnalytics.LogEvent(Screen_95);
    }
    public static void EventsScreen_96(string Screen_96)
    {
        FirebaseAnalytics.LogEvent(Screen_96);
    }
    public static void EventsScreen_97(string Screen_97)
    {
        FirebaseAnalytics.LogEvent(Screen_97);
    }
    public static void EventsScreen_98(string Screen_98)
    {
        FirebaseAnalytics.LogEvent(Screen_98);
    }
    public static void EventsScreen_99(string Screen_99)
    {
        FirebaseAnalytics.LogEvent(Screen_99);
    }
    public static void EventsScreen_100(string Screen_100)
    {
        FirebaseAnalytics.LogEvent(Screen_100);
    }
    public static void EventsScreen_101(string Screen_101)
    {
        FirebaseAnalytics.LogEvent(Screen_101);
    }
    public static void EventsScreen_102(string Screen_102)
    {
        FirebaseAnalytics.LogEvent(Screen_102);
    }
    public static void EventsScreen_103(string Screen_103)
    {
        FirebaseAnalytics.LogEvent(Screen_103);
    }
    public static void EventsScreen_104(string Screen_104)
    {
        FirebaseAnalytics.LogEvent(Screen_104);
    }
    public static void EventsScreen_105(string Screen_105)
    {
        FirebaseAnalytics.LogEvent(Screen_105);
    }
    public static void EventsScreen_106(string Screen_106)
    {
        FirebaseAnalytics.LogEvent(Screen_106);
    }
    public static void EventsScreen_107(string Screen_107)
    {
        FirebaseAnalytics.LogEvent(Screen_107);
    }
    public static void EventsScreen_108(string Screen_108)
    {
        FirebaseAnalytics.LogEvent(Screen_108);
    }
    public static void EventsScreen_109(string Screen_109)
    {
        FirebaseAnalytics.LogEvent(Screen_109);
    }
    public static void EventsScreen_110(string Screen_110)
    {
        FirebaseAnalytics.LogEvent(Screen_110);
    }
    public static void EventsScreen_111(string Screen_111)
    {
        FirebaseAnalytics.LogEvent(Screen_111);
    }
    public static void EventsScreen_112(string Screen_112)
    {
        FirebaseAnalytics.LogEvent(Screen_112);
    }
    public static void EventsScreen_113(string Screen_113)
    {
        FirebaseAnalytics.LogEvent(Screen_113);
    }
    public static void EventsScreen_114(string Screen_114)
    {
        FirebaseAnalytics.LogEvent(Screen_114);
    }
    public static void EventsScreen_115(string Screen_115)
    {
        FirebaseAnalytics.LogEvent(Screen_115);
    }
    public static void EventsScreen_116(string Screen_116)
    {
        FirebaseAnalytics.LogEvent(Screen_116);
    }
    public static void EventsScreen_117(string Screen_117)
    {
        FirebaseAnalytics.LogEvent(Screen_117);
    }
    public static void EventsScreen_118(string Screen_118)
    {
        FirebaseAnalytics.LogEvent(Screen_118);
    }
    public static void EventsScreen_119(string Screen_119)
    {
        FirebaseAnalytics.LogEvent(Screen_119);
    }
    public static void EventsScreen_120(string Screen_120)
    {
        FirebaseAnalytics.LogEvent(Screen_120);
    }
    public static void EventsScreen_121(string Screen_121)
    {
        FirebaseAnalytics.LogEvent(Screen_121);
    }
    public static void EventsScreen_122(string Screen_122)
    {
        FirebaseAnalytics.LogEvent(Screen_122);
    }
    public static void EventsScreen_123(string Screen_123)
    {
        FirebaseAnalytics.LogEvent(Screen_123);
    }
    public static void EventsScreen_124(string Screen_124)
    {
        FirebaseAnalytics.LogEvent(Screen_124);
    }
    public static void EventsScreen_125(string Screen_125)
    {
        FirebaseAnalytics.LogEvent(Screen_125);
    }
    public static void EventsScreen_126(string Screen_126)
    {
        FirebaseAnalytics.LogEvent(Screen_126);
    }
    public static void EventsScreen_127(string Screen_127)
    {
        FirebaseAnalytics.LogEvent(Screen_127);
    }
    public static void EventsScreen_128(string Screen_128)
    {
        FirebaseAnalytics.LogEvent(Screen_128);
    }
    public static void EventsScreen_129(string Screen_129)
    {
        FirebaseAnalytics.LogEvent(Screen_129);
    }
    public static void EventsScreen_130(string Screen_130)
    {
        FirebaseAnalytics.LogEvent(Screen_130);
    }
    public static void EventsScreen_131(string Screen_131)
    {
        FirebaseAnalytics.LogEvent(Screen_131);
    }
    public static void EventsScreen_132(string Screen_132)
    {
        FirebaseAnalytics.LogEvent(Screen_132);
    }
    public static void EventsScreen_133(string Screen_133)
    {
        FirebaseAnalytics.LogEvent(Screen_133);
    }
    public static void EventsScreen_134(string Screen_134)
    {
        FirebaseAnalytics.LogEvent(Screen_134);
    }
    public static void EventsScreen_135(string Screen_135)
    {
        FirebaseAnalytics.LogEvent(Screen_135);
    }
    public static void EventsScreen_136(string Screen_136)
    {
        FirebaseAnalytics.LogEvent(Screen_136);
    }
    public static void EventsScreen_137(string Screen_137)
    {
        FirebaseAnalytics.LogEvent(Screen_137);
    }
    public static void EventsScreen_138(string Screen_138)
    {
        FirebaseAnalytics.LogEvent(Screen_138);
    }
    public static void EventsScreen_139(string Screen_139)
    {
        FirebaseAnalytics.LogEvent(Screen_139);
    }
    public static void EventsScreen_140(string Screen_140)
    {
        FirebaseAnalytics.LogEvent(Screen_140);
    }
    public static void EventsScreen_141(string Screen_141)
    {
        FirebaseAnalytics.LogEvent(Screen_141);
    }
    public static void EventsScreen_142(string Screen_142)
    {
        FirebaseAnalytics.LogEvent(Screen_142);
    }
    public static void EventsScreen_143(string Screen_143)
    {
        FirebaseAnalytics.LogEvent(Screen_143);
    }
    public static void EventsScreen_144(string Screen_144)
    {
        FirebaseAnalytics.LogEvent(Screen_144);
    }
    public static void EventsScreen_145(string Screen_145)
    {
        FirebaseAnalytics.LogEvent(Screen_145);
    }
    public static void EventsScreen_146(string Screen_146)
    {
        FirebaseAnalytics.LogEvent(Screen_146);
    }
    public static void EventsScreen_147(string Screen_147)
    {
        FirebaseAnalytics.LogEvent(Screen_147);
    }
    public static void EventsScreen_148(string Screen_148)
    {
        FirebaseAnalytics.LogEvent(Screen_148);
    }
    public static void EventsScreen_149(string Screen_149)
    {
        FirebaseAnalytics.LogEvent(Screen_149);
    }
    public static void EventsScreen_150(string Screen_150)
    {
        FirebaseAnalytics.LogEvent(Screen_150);
    }
    public static void EventsScreen_151(string Screen_151)
    {
        FirebaseAnalytics.LogEvent(Screen_151);
    }
    public static void EventsScreen_152(string Screen_152)
    {
        FirebaseAnalytics.LogEvent(Screen_152);
    }
    public static void EventsScreen_153(string Screen_153)
    {
        FirebaseAnalytics.LogEvent(Screen_153);
    }
    public static void EventsScreen_154(string Screen_154)
    {
        FirebaseAnalytics.LogEvent(Screen_154);
    }
    public static void EventsScreen_155(string Screen_155)
    {
        FirebaseAnalytics.LogEvent(Screen_155);
    }
    public static void EventsScreen_156(string Screen_156)
    {
        FirebaseAnalytics.LogEvent(Screen_156);
    }
    public static void EventsScreen_157(string Screen_157)
    {
        FirebaseAnalytics.LogEvent(Screen_157);
    }
    public static void EventsScreen_158(string Screen_158)
    {
        FirebaseAnalytics.LogEvent(Screen_158);
    }
    public static void EventsScreen_159(string Screen_159)
    {
        FirebaseAnalytics.LogEvent(Screen_159);
    }
    public static void EventsScreen_160(string Screen_160)
    {
        FirebaseAnalytics.LogEvent(Screen_160);
    }
    public static void EventsScreen_161(string Screen_161)
    {
        FirebaseAnalytics.LogEvent(Screen_161);
    }
    public static void EventsScreen_162(string Screen_162)
    {
        FirebaseAnalytics.LogEvent(Screen_162);
    }
    public static void EventsScreen_163(string Screen_163)
    {
        FirebaseAnalytics.LogEvent(Screen_163);
    }
    public static void EventsScreen_164(string Screen_164)
    {
        FirebaseAnalytics.LogEvent(Screen_164);
    }
    public static void EventsScreen_165(string Screen_165)
    {
        FirebaseAnalytics.LogEvent(Screen_165);
    }
    public static void EventsScreen_166(string Screen_166)
    {
        FirebaseAnalytics.LogEvent(Screen_166);
    }
    public static void EventsScreen_167(string Screen_167)
    {
        FirebaseAnalytics.LogEvent(Screen_167);
    }
    public static void EventsScreen_168(string Screen_168)
    {
        FirebaseAnalytics.LogEvent(Screen_168);
    }
    public static void EventsScreen_169(string Screen_169)
    {
        FirebaseAnalytics.LogEvent(Screen_169);
    }
    public static void EventsScreen_170(string Screen_170)
    {
        FirebaseAnalytics.LogEvent(Screen_170);
    }
    public static void EventsScreen_171(string Screen_171)
    {
        FirebaseAnalytics.LogEvent(Screen_171);
    }
    public static void EventsScreen_172(string Screen_172)
    {
        FirebaseAnalytics.LogEvent(Screen_172);
    }
    public static void EventsScreen_173(string Screen_173)
    {
        FirebaseAnalytics.LogEvent(Screen_173);
    }
    public static void EventsScreen_174(string Screen_174)
    {
        FirebaseAnalytics.LogEvent(Screen_174);
    }
    public static void EventsScreen_175(string Screen_175)
    {
        FirebaseAnalytics.LogEvent(Screen_175);
    }
    public static void EventsScreen_176(string Screen_176)
    {
        FirebaseAnalytics.LogEvent(Screen_176);
    }
    public static void EventsScreen_177(string Screen_177)
    {
        FirebaseAnalytics.LogEvent(Screen_177);
    }
    public static void EventsScreen_178(string Screen_178)
    {
        FirebaseAnalytics.LogEvent(Screen_178);
    }
    public static void EventsScreen_179(string Screen_179)
    {
        FirebaseAnalytics.LogEvent(Screen_179);
    }
    public static void EventsScreen_180(string Screen_180)
    {
        FirebaseAnalytics.LogEvent(Screen_180);
    }
    public static void EventsScreen_181(string Screen_181)
    {
        FirebaseAnalytics.LogEvent(Screen_181);
    }
}
