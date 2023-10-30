using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ActiveChapter : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ActiveMenu activeMenu;
    [SerializeField] private TPCharter tPCharter;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private Sound sound;
    [SerializeField] private Achievements achievements;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private Animation anim;
    [SerializeField] private AnimContent[] animContent;
    [SerializeField] private AnimContent animContentPanel;
    [SerializeField] private LogicValuesChapters logicValuesChapters;
    [SerializeField] private GameObject[] buttonIf;
    [SerializeField] private AnimStar animStar;
    //[SerializeField] private ActiveCamp activeCamp;
    //[SerializeField] private MusicCamp musicCamp;

    public GameObject panel;
    public GameObject[] charter;

    [SerializeField] public Image imgBlackout;
    public TMP_Text toBeContinued;
    public GameObject rateUs;
    public Button star1;
    public Button star2;
    public Button star3;
    public Button star4;
    public Button star5;
    public Sprite starYes;
    public Sprite starNo;
    public GameObject rateUsNot;
    public GameObject Img2;
    public GameObject Img_charter_1;
    public GameObject Img_charter_2;
    public GameObject Img_charter_3;

    //Загрузка места сохранения
    public void CharterActiveUpdate()
    {
        if (gameManager.charter[0] == 1)
        {
            Charter1UI(0);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[1] == 1)
        {
            ButtonC2();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[2] == 1)
        {
            ButtonC3();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[3] == 1)
        {
            ButtonC4();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[4] == 1)
        {
            ButtonC5();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[5] == 1)
        {
            ButtonC6();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[6] == 1)
        {
            ButtonC7();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[7] == 1)
        {
            ButtonC8();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[8] == 1)
        {
            ButtonC9();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[9] == 1)
        {
            ButtonC10();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[10] == 1)
        {
            ButtonC11();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[11] == 1)
        {
            ButtonC12();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[12] == 1)
        {
            ButtonC13();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[13] == 1)
        {
            ButtonC14();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[14] == 1)
        {
            ButtonC15();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[15] == 1)
        {
            ButtonC16();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[16] == 1)
        {
            ButtonC17();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[17] == 1)
        {
            ButtonC18();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[18] == 1)
        {
            ButtonC19();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[19] == 1)
        {
            ButtonC20();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[20] == 1)
        {
            ButtonC21();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[21] == 1)
        {
            ButtonC22();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[22] == 1)
        {
            ButtonC23();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[23] == 1)
        {
            ButtonC24();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[24] == 1)
        {
            ButtonC25();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[25] == 1)
        {
            ButtonC26();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[26] == 1)
        {
            ButtonC27();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[27] == 1)
        {
            ButtonC28();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[28] == 1)
        {
            ButtonC29();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[29] == 1)
        {
            ButtonC30();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[30] == 1)
        {
            ButtonC31();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[31] == 1)
        {
            ButtonC32();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[32] == 1)
        {
            ButtonC33();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[33] == 1)
        {
            ButtonC34();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[34] == 1)
        {
            ButtonC35();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[35] == 1)
        {
            ButtonC36();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[36] == 1)
        {
            ButtonC37();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[37] == 1)
        {
            ButtonC38();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[38] == 1)
        {
            ButtonC39();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[39] == 1)
        {
            ButtonC40();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[40] == 1)
        {
            ButtonC41();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[41] == 1)
        {
            ButtonC42();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[42] == 1)
        {
            ButtonC43();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[43] == 1)
        {
            ButtonC44();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[44] == 1)
        {
            ButtonC45();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[45] == 1)
        {
            ButtonC46();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[46] == 1)
        {
            ButtonC47();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[47] == 1)
        {
            ButtonC48();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[48] == 1)
        {
            ButtonC49();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[49] == 1)
        {
            ButtonC50();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[50] == 1)
        {
            ButtonC51();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[51] == 1)
        {
            ButtonC52();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[52] == 1)
        {
            ButtonC53();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[53] == 1)
        {
            ButtonC54();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[54] == 1)
        {
            ButtonC55();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[55] == 1)
        {
            ButtonC56();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[56] == 1)
        {
            ButtonC57();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[57] == 1)
        {
            ButtonC58();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[58] == 1)
        {
            ButtonC59();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[59] == 1)
        {
            ButtonC60();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[60] == 1)
        {
            ButtonC61();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[61] == 1)
        {
            ButtonC62();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[62] == 1)
        {
            ButtonC63();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[63] == 1)
        {
            ButtonC64();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[64] == 1)
        {
            ButtonC65();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[65] == 1)
        {
            ButtonC66();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[66] == 1)
        {
            ButtonC67();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[67] == 1)
        {
            ButtonC68();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[68] == 1)
        {
            ButtonC69();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[69] == 1)
        {
            ButtonC70();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[70] == 1)
        {
            ButtonC71();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[71] == 1)
        {
            ButtonC72();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[72] == 1)
        {
            ButtonC73();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[73] == 1)
        {
            ButtonC74();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[74] == 1)
        {
            ButtonC75();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[75] == 1)
        {
            ButtonC76();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[76] == 1)
        {
            ButtonC77();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[77] == 1)
        {
            ButtonC78();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[78] == 1)
        {
            ButtonC79();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[79] == 1)
        {
            ButtonC80();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[80] == 1)
        {
            ButtonC81();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[81] == 1)
        {
            ButtonC82();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[82] == 1)
        {
            ButtonC83();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[83] == 1)
        {
            ButtonC84();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[84] == 1)
        {
            ButtonC85();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[85] == 1)
        {
            ButtonC86();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[86] == 1)
        {
            ButtonC87();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[87] == 1)
        {
            ButtonC88();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[88] == 1)
        {
            ButtonC89();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[89] == 1)
        {
            ButtonC90();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[90] == 1)
        {
            ButtonC91();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[91] == 1)
        {
            ButtonC92();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[92] == 1)
        {
            ButtonC93();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[93] == 1)
        {
            ButtonC94();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[94] == 1)
        {
            ButtonC95();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[95] == 1)
        {
            ButtonC96();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[96] == 1)
        {
            ButtonC97();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[97] == 1)
        {
            ButtonC98();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[98] == 1)
        {
            ButtonC99();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[99] == 1)
        {
            ButtonC100();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[100] == 1)
        {
            ButtonC101();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[101] == 1)
        {
            ButtonC102();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[102] == 1)
        {
            ButtonC103();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[103] == 1)
        {
            ButtonC104();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[104] == 1)
        {
            ButtonC105();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[105] == 1)
        {
            ButtonC106();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[106] == 1)
        {
            ButtonC107();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[107] == 1)
        {
            ButtonC108();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[108] == 1)
        {
            ButtonC109();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[109] == 1)
        {
            ButtonC110();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[110] == 1)
        {
            ButtonC111();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[111] == 1)
        {
            ButtonC112();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[112] == 1)
        {
            ButtonC113();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[113] == 1)
        {
            ButtonC114();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[114] == 1)
        {
            ButtonC115();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[115] == 1)
        {
            ButtonC116();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[116] == 1)
        {
            ButtonC117();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[117] == 1)
        {
            ButtonC118();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[118] == 1)
        {
            ButtonC119();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[119] == 1)
        {
            ButtonC120();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[120] == 1)
        {
            ButtonC121();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[121] == 1)
        {
            ButtonC122();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[122] == 1)
        {
            ButtonC123();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[123] == 1)
        {
            ButtonC124();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[124] == 1)
        {
            ButtonC125();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[125] == 1)
        {
            ButtonC126();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[126] == 1)
        {
            ButtonC127();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[127] == 1)
        {
            ButtonC128();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[128] == 1)
        {
            ButtonC129();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[129] == 1)
        {
            ButtonC130();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[130] == 1)
        {
            ButtonC131();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[131] == 1)
        {
            ButtonC132();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[132] == 1)
        {
            ButtonC133();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[133] == 1)
        {
            ButtonC134();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[134] == 1)
        {
            ButtonC135();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[135] == 1)
        {
            ButtonC136();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[136] == 1)
        {
            ButtonC137();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[137] == 1)
        {
            ButtonC138();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[138] == 1)
        {
            ButtonC139();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[139] == 1)
        {
            ButtonC140();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[140] == 1)
        {
            ButtonC141();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[141] == 1)
        {
            ButtonC142();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[142] == 1)
        {
            ButtonC143();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[143] == 1)
        {
            ButtonC144();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[144] == 1)
        {
            ButtonC145();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[145] == 1)
        {
            ButtonC146();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[146] == 1)
        {
            ButtonC147();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[147] == 1)
        {
            ButtonC148();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[148] == 1)
        {
            ButtonC149();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[149] == 1)
        {
            ButtonC150();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[150] == 1)
        {
            ButtonC151();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[151] == 1)
        {
            ButtonC152();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[152] == 1)
        {
            ButtonC153();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[153] == 1)
        {
            ButtonC154();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[154] == 1)
        {
            ButtonC155();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[155] == 1)
        {
            ButtonC156();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[156] == 1)
        {
            ButtonC157();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[157] == 1)
        {
            ButtonC158();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[158] == 1)
        {
            ButtonC159();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[159] == 1)
        {
            ButtonC160();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[160] == 1)
        {
            ButtonC161();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[161] == 1)
        {
            ButtonC162();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[162] == 1)
        {
            ButtonC163();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[163] == 1)
        {
            ButtonC164();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[164] == 1)
        {
            ButtonC165();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[165] == 1)
        {
            ButtonC166();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[166] == 1)
        {
            ButtonC167();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[167] == 1)
        {
            ButtonC168();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[168] == 1)
        {
            ButtonC169();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[169] == 1)
        {
            ButtonC170();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[170] == 1)
        {
            ButtonC171();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[171] == 1)
        {
            ButtonC172();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[172] == 1)
        {
            ButtonC173();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[173] == 1)
        {
            ButtonC174();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[174] == 1)
        {
            ButtonC175();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[175] == 1)
        {
            ButtonC176();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[176] == 1)
        {
            ButtonC177();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[177] == 1)
        {
            ButtonC178();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[178] == 1)
        {
            ButtonC179();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[179] == 1)
        {
            ButtonC180();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[180] == 1)
        {
            ButtonC181();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[181] == 1)
        {
            ButtonC182();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else
        {
            for (int i = 0; i < gameManager.charter.Length; i++)
            {
                gameManager.charter[i] = 0;
            }
        }




        //if (gameManager.charter1UI == true)
        //{
        //    Charter1UI(0);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter2UI == true)
        //{
        //    Charter2UI(1);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter3UI == true)
        //{
        //    Charter3UI(2);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter4UI == true)
        //{
        //    Charter4UI(3);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter5UI == true)
        //{
        //    Charter5UI(4);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter6UI == true)
        //{
        //    Charter6UI(5);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter7UI == true)
        //{
        //    Charter7UI(6);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter8UI == true)
        //{
        //    Charter8UI(7);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter9UI == true)
        //{
        //    Charter9UI(8);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter10UI == true)
        //{
        //    Charter10UI(9);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter11UI == true)
        //{
        //    Charter11UI(10);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter12UI == true)
        //{
        //    Charter12UI(11);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter13UI == true)
        //{
        //    Charter13UI(12);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter14UI == true)
        //{
        //    Charter14UI(13);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter15UI == true)
        //{
        //    Charter15UI(14);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter16UI == true)
        //{
        //    Charter16UI(15);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter17UI == true)
        //{
        //    Charter17UI(16);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter18UI == true)
        //{
        //    Charter18UI(17);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter19UI == true)
        //{
        //    Charter19UI(18);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter20UI == true)
        //{
        //    Charter20UI(19);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter21UI == true)
        //{
        //    Charter21UI(20);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter22UI == true)
        //{
        //    Charter22UI(21);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter23UI == true)
        //{
        //    Charter23UI(22);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter24UI == true)
        //{
        //    Charter24UI(23);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter25UI == true)
        //{
        //    Charter25UI(24);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter26UI == true)
        //{
        //    Charter26UI(25);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter27UI == true)
        //{
        //    Charter27UI(26);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter28UI == true)
        //{
        //    Charter28UI(27);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter29UI == true)
        //{
        //    Charter29UI(28);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter30UI == true)
        //{
        //    Charter30UI(29);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else
        //{
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //}
    }

    public void AAA()
    {
        gameManager.b_the_end++;
    }
    //1
    public void Charter1_1UI(int index)
    {
        toBeContinued.text = "Prologue";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        panel.gameObject.SetActive(true);
        tPCharter.C1();
        musicCharter.PlayMusic(gameManager.numberMusic);
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[0].AllAnim();
        }
        gameManager.SavePlayer();
    }
    public void Charter1UI(int index)
    {
        toBeContinued.text = "Prologue";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[0].AllAnim();
        }
        gameManager.SavePlayer();
    }

    //2
    public void ButtonC2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC2", 0.5f);
        Invoke("InvokerAchievements1", 6.5f);
    }
    public void InvokerC2()
    {
        Charter2UI(1);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements1()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter2UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        sound.PlaySound(0);
    }
    //2_2
    public void ButtonC2_2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("ActiveImg", 0.5f);
        Invoke("Bda", 6.0f);
        Invoke("InvokerC2_2", 6.5f);
        Invoke("Bda", 14.0f);
        Invoke("InvokerC2_3", 14.5f);
        Invoke("InvokerAchievements1_2", 19.5f);
    }
    public void ActiveImg()
    {
        Img2.gameObject.SetActive(true);
        charter[0].SetActive(false);
        panel.SetActive(false);
        animContent[182].AllAnim_2();
    }
    public void Bda()
    {
        anim.Play("BlackoutDarkAnimation");
    }
    public void InvokerC2_2()
    {
        Img2.gameObject.SetActive(false);
        Img_charter_1.gameObject.SetActive(true);
        animContent[183].AllAnim();
        musicCharter.StopMusic();
        sound.PlaySound(0);
        //animContent[183].AllAnim_2();
        //Charter2_2UI(1);
        //Img2.gameObject.SetActive(false);
        //gameManager.SavePlayer();
    }
    public void InvokerC2_3()
    {
        Charter2_2UI(1);
        panel.SetActive(true);
        Img_charter_1.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements1_2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter2_2UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //3
    public void ButtonC3()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC3", 0.5f);
        Invoke("InvokerAchievements2", 6.5f);
    }
    public void InvokerC3()
    {
        Charter3UI(2);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter3UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[2].AllAnim();
        }

        sound.PlaySound(1);
    }
    //3A
    public void AButtonC3()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[1].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC3", 1.1f);
        Invoke("AInvokerAchievements2", 2.2f);
    }
    private void AInvokerC3()
    {
        ACharter3UI(2);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter3UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[2].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(1);
    }

    //4
    public void ButtonC4()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC4", 0.5f);
        Invoke("InvokerAchievements3", 6.5f);
    }
    public void InvokerC4()
    {
        Charter4UI(3);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements3()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter4UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[3].AllAnim();
        }
    }
    //4A
    public void AButtonC4()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[1].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC4", 1.1f);
        Invoke("AInvokerAchievements3", 2.2f);
    }
    private void AInvokerC4()
    {
        ACharter4UI(3);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements3()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter4UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[3].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //5
    public void ButtonC5()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC5", 0.5f);
        Invoke("InvokerAchievements4", 6.5f);
    }
    public void InvokerC5()
    {
        Charter5UI(4);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements4()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter5UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[4].AllAnim();
        }

        sound.PlaySound(24);
    }
    //5A
    public void AButtonC5()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[2].AllAnim1();
        animContent[3].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC5", 1.1f);
        Invoke("AInvokerAchievements4", 2.2f);
    }
    private void AInvokerC5()
    {
        ACharter5UI(4);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements4()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter5UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[4].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(24);
    }

    //6
    public void ButtonC6()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC6", 0.5f);
        Invoke("InvokerAchievements5", 6.5f);
    }
    public void InvokerC6()
    {
        Charter6UI(5);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements5()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter6UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[5].AllAnim();
        }
    }
    //6A
    public void AButtonC6()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[4].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC6", 1.1f);
        Invoke("AInvokerAchievements5", 2.2f);
    }
    private void AInvokerC6()
    {
        ACharter6UI(5);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements5()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter6UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }



        animContent[5].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //7
    public void ButtonC7()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC7", 0.5f);
        Invoke("InvokerAchievements6", 6.5f);
    }
    public void InvokerC7()
    {
        Charter7UI(6);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements6()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter7UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[6].AllAnim();
        }
    }
    //7A
    public void AButtonC7()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[4].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC7", 1.1f);
        Invoke("AInvokerAchievements6", 2.2f);
    }
    private void AInvokerC7()
    {
        ACharter7UI(6);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements6()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter7UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[6].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //Проигрышь
    public void MenuCharter7UI()
    {
        toBeContinued.text = "Chapter 1";
        //sound.StopSound();
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }


        for (int i = 0; i < charter.Length; i++)
        {
            charter[i].SetActive(false);
        }
        panel.gameObject.SetActive(false);
        saveAndLoad.continueGame = 0;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        musicCharter.StopMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    //8
    public void ButtonC8()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC8", 0.5f);
        Invoke("InvokerAchievements7", 6.5f);
    }
    public void InvokerC8()
    {
        Charter8UI(7);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements7()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter8UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[7].AllAnim();
        }
    }
    //8A
    public void AButtonC8()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[6].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC8", 1.1f);
        Invoke("AInvokerAchievements7", 2.2f);
    }
    private void AInvokerC8()
    {
        ACharter8UI(7);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements7()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    private void ACharter8UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[7].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //9
    public void ButtonC9()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC9", 0.5f);
        Invoke("InvokerAchievements8", 6.5f);
    }
    public void InvokerC9()
    {
        Charter9UI(8);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements8()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter9UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[8].AllAnim();
        }
    }

    //10
    public void ButtonC10()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC10", 0.5f);
        Invoke("InvokerAchievements9", 6.5f);
    }
    public void InvokerC10()
    {
        Charter10UI(9);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements9()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter10UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = true;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[9].AllAnim();
        }
    }
    //10A
    public void AButtonC10()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[8].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC10", 1.1f);
        Invoke("AInvokerAchievements9", 2.2f);
    }
    private void AInvokerC10()
    {
        ACharter10UI(9);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements9()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter10UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        animContent[9].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //11
    public void ButtonC11()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC11", 0.5f);
        Invoke("InvokerAchievements10", 6.5f);
    }
    public void InvokerC11()
    {
        Charter11UI(10);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements10()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter11UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Any_Other_Flights();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[10].AllAnim();
        }
    }
    //11A
    public void AButtonC11()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[8].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC11", 1.1f);
        Invoke("AInvokerAchievements10", 2.2f);
    }
    private void AInvokerC11()
    {
        ACharter11UI(10);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements10()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter11UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Any_Other_Flights();

        animContent[10].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //12
    public void ButtonC12()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC12", 0.5f);
        Invoke("InvokerAchievements11", 6.5f);
    }
    public void InvokerC12()
    {
        Charter12UI(11);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements11()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter12UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 2;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Visit_The_Cigar_Bar();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[11].AllAnim();
        }
        musicCharter.PlayMusic(2);
    }

    //13
    public void ButtonC13()
    {
        //FireBaseAnalyticsEvents.EventsWinGame("WinGame");
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC13", 0.5f);
        Invoke("InvokerAchievements12", 6.5f);
    }
    public void InvokerC13()
    {
        Charter13UI(12);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements12()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter13UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_any_other_flights == 0)
        {
            buttonIf[0].gameObject.SetActive(false);
        }
        else if (gameManager.b_any_other_flights == 1)
        {
            buttonIf[0].gameObject.SetActive(true);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[12].AllAnim();
        }
    }
    //13A
    public void AButtonC13()
    {
        //FireBaseAnalyticsEvents.EventsWinGame("WinGame");
        imgBlackout.gameObject.SetActive(true);
        animContent[9].AllAnim1();
        animContent[10].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC13", 1.1f);
        Invoke("AInvokerAchievements12", 2.2f);
    }
    private void AInvokerC13()
    {
        ACharter13UI(12);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements12()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter13UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_any_other_flights == 0)
        {
            buttonIf[0].gameObject.SetActive(false);
        }
        else if (gameManager.b_any_other_flights == 1)
        {
            buttonIf[0].gameObject.SetActive(true);
        }


        animContent[12].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //14
    public void ButtonC14()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC14", 0.5f);
        Invoke("InvokerAchievements13", 6.5f);
    }
    public void InvokerC14()
    {
        Charter14UI(13);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements13()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter14UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[13].AllAnim();
        }
        sound.PlaySound(3);
    }
    //14A
    public void AButtonC14()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[11].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC14", 1.1f);
        Invoke("AInvokerAchievements13", 2.2f);
    }
    private void AInvokerC14()
    {
        ACharter14UI(13);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements13()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter14UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[13].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(3);
    }

    //15
    public void ButtonC15()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC15", 0.5f);
        Invoke("InvokerAchievements14", 6.5f);
    }
    public void InvokerC15()
    {
        Charter15UI(14);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements14()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter15UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = true;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[14].AllAnim();
        }
    }
    //15A
    public void AButtonC15()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[11].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC15", 1.1f);
        Invoke("AInvokerAchievements14", 2.2f);
    }
    private void AInvokerC15()
    {
        ACharter15UI(14);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements14()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter15UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[14].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //16
    public void ButtonC16()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC16", 0.5f);
        Invoke("InvokerAchievements15", 6.5f);
    }
    public void InvokerC16()
    {
        Charter16UI(15);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements15()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter16UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[15].AllAnim();
        }
        sound.PlaySound(4);
    }
    //16AA
    public void AAButtonC16()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("AAInvokerC16", 0.5f);
        Invoke("AAInvokerAchievements15", 6.5f);
    }
    private void AAInvokerC16()
    {
        AACharter16UI(15);
        gameManager.SavePlayer();
    }
    private void AAInvokerAchievements15()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void AACharter16UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[15].AllAnim();
        }
        sound.PlaySound(4);
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //17
    public void ButtonC17()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC17", 0.5f);
        Invoke("InvokerAchievements16", 6.5f);
    }
    public void InvokerC17()
    {
        Charter17UI(16);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements16()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter17UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = true;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Grab_Some_Food();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[16].AllAnim();
        }
    }

    //18
    public void ButtonC18()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC18", 0.5f);
        Invoke("InvokerAchievements17", 6.5f);
    }
    public void InvokerC18()
    {
        Charter18UI(17);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements17()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter18UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = true;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[17].AllAnim();
        }
    }
    //18A
    public void AButtonC18()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[16].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC18", 1.1f);
        Invoke("AInvokerAchievements17", 2.2f);
    }
    private void AInvokerC18()
    {
        ACharter18UI(17);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements17()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter18UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[17].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //19
    public void ButtonC19()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC19", 0.5f);
        Invoke("InvokerAchievements18", 6.5f);
    }
    public void InvokerC19()
    {
        Charter19UI(18);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements18()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter19UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = true;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[18].AllAnim();
        }
    }
    //19A
    public void AButtonC19()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[16].AllAnim1();
        animContent[17].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC19", 1.1f);
        Invoke("AInvokerAchievements18", 2.2f);
    }
    private void AInvokerC19()
    {
        ACharter19UI(18);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements18()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter19UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[18].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //20
    public void ButtonC20()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC20", 0.5f);
        Invoke("InvokerAchievements19", 6.5f);
    }
    public void InvokerC20()
    {
        Charter20UI(19);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements19()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter20UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = true;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[19].AllAnim();
        }
    }
    //20A
    public void AButtonC20()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[16].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC20", 1.1f);
        Invoke("AInvokerAchievements19", 2.2f);
    }
    private void AInvokerC20()
    {
        ACharter20UI(19);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements19()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter20UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[19].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //21
    public void ButtonC21()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC21", 0.5f);
        Invoke("InvokerAchievements20", 6.5f);
    }
    public void InvokerC21()
    {
        Charter21UI(20);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements20()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter21UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = true;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[20].AllAnim();
        }
    }
    //21A
    public void AButtonC21()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[17].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC21", 1.1f);
        Invoke("AInvokerAchievements20", 2.2f);
    }
    private void AInvokerC21()
    {
        ACharter21UI(20);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements20()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter21UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[20].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //22
    public void ButtonC22()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC22", 0.5f);
        Invoke("InvokerAchievements21", 6.5f);
    }
    public void InvokerC22()
    {
        Charter22UI(21);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements21()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter22UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = true;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[21].AllAnim();
        }
    }
    //22A
    public void AButtonC22()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[20].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC22", 1.1f);
        Invoke("AInvokerAchievements21", 2.2f);
    }
    private void AInvokerC22()
    {
        ACharter22UI(21);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements21()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter22UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[21].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //23
    public void ButtonC23()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC23", 0.5f);
        Invoke("InvokerAchievements22", 6.5f);
    }
    public void InvokerC23()
    {
        Charter23UI(22);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements22()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter23UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = true;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[22].AllAnim();
        }
    }
    //23A
    public void AButtonC23()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[20].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC23", 1.1f);
        Invoke("AInvokerAchievements22", 2.2f);
    }
    private void AInvokerC23()
    {
        ACharter23UI(22);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements22()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter23UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[22].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //24
    public void ButtonC24()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC24", 0.5f);
        Invoke("InvokerAchievements23", 6.5f);
    }
    public void InvokerC24()
    {
        Charter24UI(23);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements23()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter24UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = true;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[23].AllAnim();
        }
    }

    //25
    public void ButtonC25()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC25", 0.5f);
        Invoke("InvokerAchievements24", 6.5f);
    }
    public void InvokerC25()
    {
        Charter25UI(24);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements24()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter25UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = true;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[24].AllAnim();
        }
        sound.PlaySound(5);
    }
    //25A
    public void AButtonC25()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[23].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC25", 1.1f);
        Invoke("AInvokerAchievements24", 2.2f);
    }
    private void AInvokerC25()
    {
        ACharter25UI(24);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements24()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter25UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[24].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(5);

    }

    //26
    public void ButtonC26()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC26", 0.5f);
        Invoke("InvokerAchievements25", 6.5f);
    }
    public void InvokerC26()
    {
        Charter26UI(25);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements25()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter26UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[25].AllAnim();
        }
    }
    //26A
    public void AButtonC26()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[24].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC26", 1.1f);
        Invoke("AInvokerAchievements25", 2.2f);
    }
    private void AInvokerC26()
    {
        ACharter26UI(25);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements25()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter26UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[25].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //27
    public void ButtonC27()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC27", 0.5f);
        Invoke("InvokerAchievements26", 6.5f);
    }
    public void InvokerC27()
    {
        Charter27UI(26);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements26()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter27UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = true;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[26].AllAnim();
        }
    }
    //27A
    public void AButtonC27()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[24].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC27", 1.1f);
        Invoke("AInvokerAchievements26", 2.2f);
    }
    private void AInvokerC27()
    {
        ACharter27UI(26);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements26()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter27UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[26].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //28
    public void ButtonC28()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC28", 0.5f);
        Invoke("InvokerAchievements27", 6.5f);
    }
    public void InvokerC28()
    {
        Charter28UI(27);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements27()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter28UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = true;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[27].AllAnim();
        }
    }
    //28A
    public void AButtonC28()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[24].AllAnim1();
        animContent[25].AllAnim1();
        animContent[26].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC28", 1.1f);
        Invoke("AInvokerAchievements27", 2.2f);
    }
    private void AInvokerC28()
    {
        ACharter28UI(27);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements27()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter28UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[27].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //29
    public void ButtonC29()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC29", 0.5f);
        Invoke("InvokerAchievements28", 6.5f);
    }
    public void InvokerC29()
    {
        Charter29UI(28);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements28()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter29UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = true;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[28].AllAnim();
        }
    }

    //30
    public void ButtonC30()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC30", 0.5f);
        Invoke("InvokerAchievements29", 6.5f);
    }
    public void InvokerC30()
    {
        Charter30UI(29);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements29()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter30UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[29].AllAnim();
        }
    }
    //30A
    public void AButtonC30()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[28].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC30", 1.1f);
        Invoke("AInvokerAchievements29", 2.2f);
    }
    private void AInvokerC30()
    {
        ACharter30UI(29);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements29()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter30UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[29].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //31
    public void ButtonC31()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC31", 0.5f);
        Invoke("InvokerAchievements30", 6.5f);
    }
    public void InvokerC31()
    {
        Charter31UI(30);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements30()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter31UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[30].AllAnim();
        }
    }
    //31A
    public void AButtonC31()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[28].AllAnim1();
        animContent[29].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC31", 1.1f);
        Invoke("AInvokerAchievements30", 2.2f);
    }
    private void AInvokerC31()
    {
        ACharter31UI(30);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements30()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter31UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[30].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //32
    public void ButtonC32()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC32", 0.5f);
        Invoke("InvokerAchievements31", 6.5f);
    }
    public void InvokerC32()
    {
        Charter32UI(31);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements31()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter32UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[31].AllAnim();
        }
    }
    //32A
    public void AButtonC32()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[29].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC32", 1.1f);
        Invoke("AInvokerAchievements31", 2.2f);
    }
    private void AInvokerC32()
    {
        ACharter32UI(31);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements31()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter32UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[31].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //33
    public void ButtonC33()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC33", 0.5f);
        Invoke("InvokerAchievements32", 6.5f);
    }
    public void InvokerC33()
    {
        Charter33UI(32);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements32()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter33UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[32].AllAnim();
        }
    }
    //33A
    public void AButtonC33()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[31].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC33", 1.1f);
        Invoke("AInvokerAchievements32", 2.2f);
    }
    private void AInvokerC33()
    {
        ACharter33UI(32);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements32()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter33UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[32].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //34
    public void ButtonC34()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC34", 0.5f);
        Invoke("InvokerAchievements33", 6.5f);
    }
    public void InvokerC34()
    {
        Charter34UI(33);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements33()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter34UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[33].AllAnim();
        }
    }
    //34A
    public void AButtonC34()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[32].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC34", 1.1f);
        Invoke("AInvokerAchievements33", 2.2f);
    }
    private void AInvokerC34()
    {
        ACharter34UI(33);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements33()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter34UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[33].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //35
    public void ButtonC35()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC35", 0.5f);
        Invoke("InvokerAchievements34", 6.5f);
    }
    public void InvokerC35()
    {
        Charter35UI(34);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements34()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter35UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Ask_About_Her_Toys();

        if (gameManager.b_make_conversation == 0)
        {
            buttonIf[1].gameObject.SetActive(true);
        }
        else if (gameManager.b_make_conversation == 1)
        {
            buttonIf[1].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[34].AllAnim();
        }
    }
    //35A
    public void AButtonC35()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[33].AllAnim1();
        animContent[35].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC35", 1.1f);
        Invoke("AInvokerAchievements34", 2.2f);
    }
    private void AInvokerC35()
    {
        ACharter35UI(34);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements34()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter35UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Ask_About_Her_Toys();

        if (gameManager.b_make_conversation == 0)
        {
            buttonIf[1].gameObject.SetActive(true);
        }
        else if (gameManager.b_make_conversation == 1)
        {
            buttonIf[1].gameObject.SetActive(false);
        }

        animContent[34].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //36
    public void ButtonC36()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC36", 0.5f);
        Invoke("InvokerAchievements35", 6.5f);
    }
    public void InvokerC36()
    {
        Charter36UI(35);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements35()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter36UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Make_Conversation();

        if (gameManager.b_ask_about_her_toys == 0)
        {
            buttonIf[2].gameObject.SetActive(true);
        }
        else if (gameManager.b_ask_about_her_toys == 1)
        {
            buttonIf[2].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[35].AllAnim();
        }
    }
    //36A
    public void AButtonC36()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[33].AllAnim1();
        animContent[34].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC36", 1.1f);
        Invoke("AInvokerAchievements35", 2.2f);
    }
    private void AInvokerC36()
    {
        ACharter36UI(35);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements35()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter36UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Make_Conversation();

        if (gameManager.b_ask_about_her_toys == 0)
        {
            buttonIf[2].gameObject.SetActive(true);
        }
        else if (gameManager.b_ask_about_her_toys == 1)
        {
            buttonIf[2].gameObject.SetActive(false);
        }

        animContent[35].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //37
    public void ButtonC37()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC37", 0.5f);
        Invoke("InvokerAchievements36", 6.5f);
    }
    public void InvokerC37()
    {
        Charter37UI(36);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements36()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter37UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Try_To_Find_Her_Parents();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[36].AllAnim();
        }
    }

    //38
    public void ButtonC38()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC38", 0.5f);
        Invoke("InvokerAchievements37", 6.5f);
    }
    public void InvokerC38()
    {
        Charter38UI(37);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements37()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter38UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[37].AllAnim();
        }
    }
    //38A
    public void AButtonC38()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[36].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC38", 1.1f);
        Invoke("AInvokerAchievements37", 2.2f);
    }
    private void AInvokerC38()
    {
        ACharter38UI(37);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements37()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter38UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[37].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //39
    public void ButtonC39()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC39", 0.5f);
        Invoke("InvokerAchievements38", 6.5f);
    }
    public void InvokerC39()
    {
        Charter39UI(38);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements38()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements1();
    }
    public void Charter39UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_We_Were_Looking();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[38].AllAnim();
        }
    }
    //39A
    public void AButtonC39()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[37].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC39", 1.1f);
        Invoke("AInvokerAchievements38", 2.2f);
    }
    private void AInvokerC39()
    {
        ACharter39UI(38);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements38()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements1();
    }
    private void ACharter39UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_We_Were_Looking();

        animContent[38].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //40
    public void ButtonC40()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC40", 0.5f);
        Invoke("InvokerAchievements39", 6.5f);
    }
    public void InvokerC40()
    {
        Charter40UI(39);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements39()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter40UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[39].AllAnim();
        }
    }
    //40A
    public void AButtonC40()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[37].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC40", 1.1f);
        Invoke("AInvokerAchievements39", 2.2f);
    }
    private void AInvokerC40()
    {
        ACharter40UI(39);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements39()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter40UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[39].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //41
    public void ButtonC41()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC41", 0.5f);
        Invoke("InvokerAchievements40", 6.5f);
    }
    public void InvokerC41()
    {
        Charter41UI(40);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements40()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter41UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        logicValuesChapters.B_Take_The_Girl_To_An_Officer();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[40].AllAnim();
        }
    }

    //42
    public void ButtonC42()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC42", 0.5f);
        Invoke("InvokerAchievements41", 6.5f);
    }
    public void InvokerC42()
    {
        Charter42UI(41);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements41()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter42UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[41].AllAnim();
        }
    }
    //42A
    public void AButtonC42()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[40].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC42", 1.1f);
        Invoke("AInvokerAchievements41", 2.2f);
    }
    private void AInvokerC42()
    {
        ACharter42UI(41);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements41()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter42UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[41].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //43
    public void ButtonC43()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC43", 0.5f);
        Invoke("InvokerAchievements42", 6.5f);
    }
    public void InvokerC43()
    {
        Charter43UI(42);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements42()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter43UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_ask_about_her_toys == 1 && gameManager.b_make_conversation == 1)
        {
            buttonIf[3].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[3].gameObject.SetActive(false);
        }

        if (gameManager.b_ask_about_her_toys == 0 || gameManager.b_make_conversation == 0)
        {
            buttonIf[4].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[4].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[42].AllAnim();
        }
    }
    //43A
    public void AButtonC43()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[41].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC43", 1.1f);
        Invoke("AInvokerAchievements42", 2.2f);
    }
    private void AInvokerC43()
    {
        ACharter43UI(42);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements42()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter43UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_ask_about_her_toys == 1 && gameManager.b_make_conversation == 1)
        {
            buttonIf[3].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[3].gameObject.SetActive(false);
        }

        if (gameManager.b_ask_about_her_toys == 0 || gameManager.b_make_conversation == 0)
        {
            buttonIf[4].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[4].gameObject.SetActive(false);
        }

        animContent[42].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //44
    public void ButtonC44()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC44", 0.5f);
        Invoke("InvokerAchievements43", 6.5f);
    }
    public void InvokerC44()
    {
        Charter44UI(43);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements43()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements2();
    }
    public void Charter44UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[43].AllAnim();
        }
    }
    //44A
    public void AButtonC44()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[42].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC44", 1.1f);
        Invoke("AInvokerAchievements43", 2.2f);
    }
    private void AInvokerC44()
    {
        ACharter44UI(43);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements43()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements2();
    }
    private void ACharter44UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[43].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //45
    public void ButtonC45()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC45", 0.5f);
        Invoke("InvokerAchievements44", 6.5f);
    }
    public void InvokerC45()
    {
        Charter45UI(44);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements44()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter45UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[6].gameObject.SetActive(false);
            buttonIf[5].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[5].gameObject.SetActive(false);
            buttonIf[6].gameObject.SetActive(true);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[44].AllAnim();
        }
    }

    //46
    public void ButtonC46()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC46", 0.5f);
        Invoke("InvokerAchievements45", 6.5f);
    }
    public void InvokerC46()
    {
        Charter46UI(45);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements45()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter46UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Go_To_The_Bookstore();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[45].AllAnim();
        }
    }

    //47
    public void ButtonC47()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC47", 0.5f);
        Invoke("InvokerAchievements46", 6.5f);
    }
    public void InvokerC47()
    {
        Charter47UI(46);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements46()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter47UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Buy_Book();



        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[7].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[7].gameObject.SetActive(false);
        }


        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[8].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[8].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[9].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[9].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[46].AllAnim();
        }
        sound.PlaySound(6);
    }
    //47A
    public void AButtonC47()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[45].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC47", 1.1f);
        Invoke("AInvokerAchievements46", 2.2f);
    }
    private void AInvokerC47()
    {
        ACharter47UI(46);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements46()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter47UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Buy_Book();



        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[7].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[7].gameObject.SetActive(false);
        }


        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[8].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[8].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[9].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[9].gameObject.SetActive(false);
        }


        sound.PlaySound(6);
        animContent[46].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //48
    public void ButtonC48()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC48", 0.5f);
        Invoke("InvokerAchievements47", 6.5f);
    }
    public void InvokerC48()
    {
        Charter48UI(47);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements47()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter48UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[10].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[10].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[11].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[11].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[12].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[12].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[47].AllAnim();
        }
    }
    //48A
    public void AButtonC48()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[45].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC48", 1.1f);
        Invoke("AInvokerAchievements47", 2.2f);
    }
    private void AInvokerC48()
    {
        ACharter48UI(47);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements47()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter48UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[10].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[10].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[11].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[11].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[12].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[12].gameObject.SetActive(false);
        }

        animContent[47].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //49
    public void ButtonC49()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC49", 0.5f);
        Invoke("InvokerAchievements48", 6.5f);
    }
    public void InvokerC49()
    {
        Charter49UI(48);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements48()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter49UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Talk_With_A_Stranger();

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[13].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[13].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[14].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[14].gameObject.SetActive(false);
        }

        if (gameManager.b_go_to_the_bookstore == 0)
        {
            buttonIf[15].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[15].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[48].AllAnim();
        }
    }
    //49A
    public void AButtonC49()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[46].AllAnim1();
        animContent[47].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC49", 1.1f);
        Invoke("AInvokerAchievements48", 2.2f);
    }
    private void AInvokerC49()
    {
        ACharter49UI(48);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements48()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter49UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Talk_With_A_Stranger();

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[13].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[13].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[14].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[14].gameObject.SetActive(false);
        }

        if (gameManager.b_go_to_the_bookstore == 0)
        {
            buttonIf[15].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[15].gameObject.SetActive(false);
        }

        animContent[48].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //50
    public void ButtonC50()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC50", 0.5f);
        Invoke("InvokerAchievements49", 6.5f);
    }
    public void InvokerC50()
    {
        Charter50UI(49);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements49()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter50UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[49].AllAnim();
        }
        sound.PlaySound(25);
    }

    //51
    public void ButtonC51()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC51", 0.5f);
        Invoke("InvokerAchievements50", 6.5f);
    }
    public void InvokerC51()
    {
        Charter51UI(50);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements50()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter51UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[50].AllAnim();
        }
        sound.PlaySound(25);
    }

    //52
    public void ButtonC52()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC52", 0.5f);
        Invoke("InvokerAchievements51", 6.5f);
    }
    public void InvokerC52()
    {
        Charter52UI(51);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements51()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter52UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[51].AllAnim();
        }
    }

    //53
    public void ButtonC53()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC53", 0.5f);
        Invoke("InvokerAchievements52", 6.5f);
    }
    public void InvokerC53()
    {
        Charter53UI(52);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements52()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter53UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[52].AllAnim();
        }
    }

    //54
    public void ButtonC54()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC54", 0.5f);
        Invoke("InvokerAchievements53", 6.5f);
    }
    public void InvokerC54()
    {
        Charter54UI(53);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements53()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter54UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[53].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
        sound.PlaySound(7);
    }

    //55
    public void ButtonC55()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC55", 0.5f);
        Invoke("InvokerAchievements54", 6.5f);
    }
    public void InvokerC55()
    {
        Charter55UI(54);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements54()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter55UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[54].AllAnim();
        }
    }

    //56
    public void ButtonC56()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC56", 0.5f);
        Invoke("InvokerAchievements55", 6.5f);
    }
    public void InvokerC56()
    {
        Charter56UI(55);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements55()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter56UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[55].AllAnim();
        }
    }

    //57
    public void ButtonC57()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC57", 0.5f);
        Invoke("InvokerAchievements56", 6.5f);
    }
    public void InvokerC57()
    {
        Charter57UI(56);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements56()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter57UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[56].AllAnim();
        }
    }

    //58
    public void ButtonC58()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC58", 0.5f);
        Invoke("InvokerAchievements57", 6.5f);
    }
    public void InvokerC58()
    {
        Charter58UI(57);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements57()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter58UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[57].AllAnim();
        }
    }
    //58A
    public void AButtonC58()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[55].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC58", 1.1f);
        Invoke("AInvokerAchievements57", 2.2f);
    }
    private void AInvokerC58()
    {
        ACharter58UI(57);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements57()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter58UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[57].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //59
    public void ButtonC59()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC59", 0.5f);
        Invoke("InvokerAchievements58", 6.5f);
    }
    public void InvokerC59()
    {
        Charter59UI(58);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements58()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter59UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[58].AllAnim();
        }
    }
    //59A
    public void AButtonC59()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[56].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC59", 1.1f);
        Invoke("AInvokerAchievements58", 2.2f);
    }
    private void AInvokerC59()
    {
        ACharter59UI(58);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements58()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter59UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[58].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //60
    public void ButtonC60()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC60", 0.5f);
        Invoke("InvokerAchievements59", 6.5f);
    }
    public void InvokerC60()
    {
        Charter60UI(59);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements59()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter60UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[59].AllAnim();
        }
    }
    //60A
    public void AButtonC60()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[55].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC60", 1.1f);
        Invoke("AInvokerAchievements59", 2.2f);
    }
    private void AInvokerC60()
    {
        ACharter60UI(59);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements59()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter60UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[59].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //61
    public void ButtonC61()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC61", 0.5f);
        Invoke("InvokerAchievements60", 6.5f);
    }
    public void InvokerC61()
    {
        Charter61UI(60);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements60()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter61UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[60].AllAnim();
        }
    }
    //61A
    public void AButtonC61()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[56].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC61", 1.1f);
        Invoke("AInvokerAchievements60", 2.2f);
    }
    private void AInvokerC61()
    {
        ACharter61UI(60);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements60()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter61UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[60].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //62
    public void ButtonC62()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC62", 0.5f);
        Invoke("InvokerAchievements61", 6.5f);
    }
    public void InvokerC62()
    {
        Charter62UI(61);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements61()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter62UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[61].AllAnim();
        }
    }
    //62A
    public void AButtonC62()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[55].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC62", 1.1f);
        Invoke("AInvokerAchievements61", 2.2f);
    }
    private void AInvokerC62()
    {
        ACharter62UI(61);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements61()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter62UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[61].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //63
    public void ButtonC63()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC63", 0.5f);
        Invoke("InvokerAchievements62", 6.5f);
    }
    public void InvokerC63()
    {
        Charter63UI(62);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements62()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter63UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[62].AllAnim();
        }
    }

    //64
    public void ButtonC64()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC64", 0.5f);
        Invoke("InvokerAchievements63", 6.5f);
    }
    public void InvokerC64()
    {
        Charter64UI(63);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements63()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter64UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[63].AllAnim();
        }
    }
    //64A
    public void AButtonC64()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[62].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC64", 1.1f);
        Invoke("AInvokerAchievements63", 2.2f);
    }
    private void AInvokerC64()
    {
        ACharter64UI(63);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements63()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter64UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[63].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //65
    public void ButtonC65()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC65", 0.5f);
        Invoke("InvokerAchievements64", 6.5f);
    }
    public void InvokerC65()
    {
        Charter65UI(64);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements64()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements3();
    }
    public void Charter65UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_buy_book == 0)
        {
            buttonIf[16].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[16].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[17].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[17].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[18].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[18].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[19].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[19].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[64].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //66
    public void ButtonC66()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC66", 0.5f);
        Invoke("InvokerAchievements65", 6.5f);
    }
    public void InvokerC66()
    {
        Charter66UI(65);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements65()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter66UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[65].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //66A
    public void AButtonC66()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[51].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC66", 1.1f);
        Invoke("AInvokerAchievements65", 2.2f);
    }
    private void AInvokerC66()
    {
        ACharter66UI(65);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements65()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter66UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[65].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //67
    public void ButtonC67()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC67", 0.5f);
        Invoke("InvokerAchievements66", 6.5f);
    }
    public void InvokerC67()
    {
        Charter67UI(66);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements66()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter67UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[66].AllAnim();
        }
    }
    //67A
    public void AButtonC67()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[65].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC67", 1.1f);
        Invoke("AInvokerAchievements66", 2.2f);
    }
    private void AInvokerC67()
    {
        ACharter67UI(66);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements66()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter67UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[66].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //68
    public void ButtonC68()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC68", 0.5f);
        Invoke("InvokerAchievements67", 6.5f);
    }
    public void InvokerC68()
    {
        Charter68UI(67);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements67()
    {
        imgBlackout.gameObject.SetActive(false);
        if (gameManager.b_alcohol == 3)
        {
            achievements.Achievements4();
        }
    }
    public void Charter68UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[67].AllAnim();
        }
        sound.PlaySound(1);
    }
    //68A
    public void AButtonC68()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[66].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC68", 1.1f);
        Invoke("AInvokerAchievements67", 2.2f);
    }
    private void AInvokerC68()
    {
        ACharter68UI(67);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements67()
    {
        imgBlackout.gameObject.SetActive(false);
        if (gameManager.b_alcohol == 3)
        {
            achievements.Achievements4();
        }
    }
    private void ACharter68UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[67].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(1);
    }

    //69
    public void ButtonC69()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC69", 0.5f);
        Invoke("InvokerAchievements68", 6.5f);
    }
    public void InvokerC69()
    {
        Charter69UI(68);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements68()
    {
        imgBlackout.gameObject.SetActive(false);
        if (gameManager.b_alcohol == 0)
        {
            achievements.Achievements5();
        }
    }
    public void Charter69UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[68].AllAnim();
        }
    }
    //69A
    public void AButtonC69()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[66].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC69", 1.1f);
        Invoke("AInvokerAchievements68", 2.2f);
    }
    private void AInvokerC69()
    {
        ACharter69UI(68);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements68()
    {
        imgBlackout.gameObject.SetActive(false);
        if (gameManager.b_alcohol == 0)
        {
            achievements.Achievements5();
        }
    }
    private void ACharter69UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[68].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //70
    public void ButtonC70()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC70", 0.5f);
        Invoke("InvokerAchievements69", 6.5f);
    }
    public void InvokerC70()
    {
        Charter70UI(69);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements69()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter70UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[69].AllAnim();
        }
        sound.PlaySound(24);
    }
    //70A
    public void AButtonC70()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[67].AllAnim1();
        animContent[68].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC70", 1.1f);
        Invoke("AInvokerAchievements69", 2.2f);
    }
    private void AInvokerC70()
    {
        ACharter70UI(69);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements69()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter70UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[69].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(24);
    }

    //71
    public void ButtonC71()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC71", 0.5f);
        Invoke("InvokerAchievements70", 6.5f);
    }
    public void InvokerC71()
    {
        Charter71UI(70);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements70()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter71UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_alcohol == 0)
        {
            buttonIf[20].gameObject.SetActive(true);
            buttonIf[21].gameObject.SetActive(true);
            buttonIf[22].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[20].gameObject.SetActive(false);
            buttonIf[21].gameObject.SetActive(false);
            buttonIf[22].gameObject.SetActive(false);
        }

        if (gameManager.b_alcohol > 0)
        {
            buttonIf[23].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[23].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[70].AllAnim();
        }
    }
    //71A
    public void AButtonC71()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[69].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC71", 1.1f);
        Invoke("AInvokerAchievements70", 2.2f);
    }
    private void AInvokerC71()
    {
        ACharter71UI(70);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements70()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter71UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_alcohol == 0)
        {
            buttonIf[20].gameObject.SetActive(true);
            buttonIf[21].gameObject.SetActive(true);
            buttonIf[22].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[20].gameObject.SetActive(false);
            buttonIf[21].gameObject.SetActive(false);
            buttonIf[22].gameObject.SetActive(false);
        }

        if (gameManager.b_alcohol > 0)
        {
            buttonIf[23].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[23].gameObject.SetActive(false);
        }

        animContent[70].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //72
    public void ButtonC72()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC72", 0.5f);
        Invoke("InvokerAchievements71", 6.5f);
    }
    public void InvokerC72()
    {
        Charter72UI(71);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements71()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements6();
    }
    public void Charter72UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[71].AllAnim();
        }
    }
    //72A
    public void AButtonC72()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[69].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC72", 1.1f);
        Invoke("AInvokerAchievements71", 2.2f);
    }
    private void AInvokerC72()
    {
        ACharter72UI(71);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements71()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements6();
    }
    private void ACharter72UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        animContent[71].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //73
    public void ButtonC73()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC73", 0.5f);
        Invoke("InvokerAchievements72", 6.5f);
    }
    public void InvokerC73()
    {
        Charter73UI(72);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements72()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter73UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[72].AllAnim();
        }
    }
    //73A
    public void AButtonC73()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[70].AllAnim1();
        animContent[80].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC73", 1.1f);
        Invoke("AInvokerAchievements72", 2.2f);
    }
    private void AInvokerC73()
    {
        ACharter73UI(72);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements72()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter73UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[72].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //74
    public void ButtonC74()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC74", 0.5f);
        Invoke("InvokerAchievements73", 6.5f);
    }
    public void InvokerC74()
    {
        Charter74UI(73);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements73()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter74UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Too_Much_Of_A_Risk();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[73].AllAnim();
        }
    }
    //74A
    public void AButtonC74()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[70].AllAnim1();
        animContent[80].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC74", 1.1f);
        Invoke("AInvokerAchievements73", 2.2f);
    }
    private void AInvokerC74()
    {
        ACharter74UI(73);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements73()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter74UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Too_Much_Of_A_Risk();

        animContent[73].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //75
    public void ButtonC75()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC75", 0.5f);
        Invoke("InvokerAchievements74", 6.5f);
    }
    public void InvokerC75()
    {
        Charter75UI(74);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements74()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter75UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Give_Me_Some_Time();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[74].AllAnim();
        }
    }
    //75A
    public void AButtonC75()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[70].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC75", 1.1f);
        Invoke("AInvokerAchievements74", 2.2f);
    }
    private void AInvokerC75()
    {
        ACharter75UI(74);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements74()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter75UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Give_Me_Some_Time();

        animContent[74].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //76
    public void ButtonC76()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC76", 0.5f);
        Invoke("InvokerAchievements75", 6.5f);
    }
    public void InvokerC76()
    {
        Charter76UI(75);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements75()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter76UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[75].AllAnim();
        }
    }

    //77
    public void ButtonC77()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC77", 0.5f);
        Invoke("InvokerAchievements76", 6.5f);
    }
    public void InvokerC77()
    {
        Charter77UI(76);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements76()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter77UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[76].AllAnim();
        }
    }
    //77A
    public void AButtonC77()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[70].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC77", 1.1f);
        Invoke("AInvokerAchievements76", 2.2f);
    }
    private void AInvokerC77()
    {
        ACharter77UI(76);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements76()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter77UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[76].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //78
    public void ButtonC78()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC78", 0.5f);
        Invoke("InvokerAchievements77", 6.5f);
    }
    public void InvokerC78()
    {
        Charter78UI(77);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements77()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter78UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[77].AllAnim();
        }
        sound.PlaySound(8);
    }

    //79
    public void ButtonC79()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC79", 0.5f);
        Invoke("InvokerAchievements78", 6.5f);
    }
    public void InvokerC79()
    {
        Charter79UI(78);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements78()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter79UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Nevermind();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[78].AllAnim();
        }
    }
    //79A
    public void AButtonC79()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[75].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC79", 1.1f);
        Invoke("AInvokerAchievements78", 2.2f);
    }
    private void AInvokerC79()
    {
        ACharter79UI(78);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements78()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter79UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Nevermind();

        animContent[78].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //80
    public void ButtonC80()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC80", 0.5f);
        Invoke("InvokerAchievements79", 6.5f);
    }
    public void InvokerC80()
    {
        Charter80UI(79);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements79()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter80UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_too_much_of_a_risk == 0 && gameManager.b_nevermind == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[24].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[24].gameObject.SetActive(false);
        }

        if (gameManager.b_give_me_some_time == 1 && gameManager.b_check_the_weather == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[25].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[25].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[79].AllAnim();
        }
    }
    //80A
    public void AButtonC80()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[72].AllAnim1();
        animContent[74].AllAnim1();
        animContent[75].AllAnim1();
        animContent[77].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC80", 1.1f);
        Invoke("AInvokerAchievements79", 2.2f);
    }
    private void AInvokerC80()
    {
        ACharter80UI(79);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements79()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter80UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_too_much_of_a_risk == 0 && gameManager.b_nevermind == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[24].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[24].gameObject.SetActive(false);
        }

        if (gameManager.b_give_me_some_time == 1 && gameManager.b_check_the_weather == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[25].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[25].gameObject.SetActive(false);
        }

        animContent[79].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //81
    public void ButtonC81()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC81", 0.5f);
        Invoke("InvokerAchievements80", 6.5f);
    }
    public void InvokerC81()
    {
        Charter81UI(80);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements80()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter81UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[80].AllAnim();
        }
    }
    //81A
    public void AButtonC81()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[79].AllAnim1();
        animContent[81].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC81", 1.1f);
        Invoke("AInvokerAchievements80", 2.2f);
    }
    private void AInvokerC81()
    {
        ACharter81UI(80);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements80()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter81UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[80].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //82
    public void ButtonC82()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC82", 0.5f);
        Invoke("InvokerAchievements81", 6.5f);
    }
    public void InvokerC82()
    {
        Charter82UI(81);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements81()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements7();
    }
    public void Charter82UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        logicValuesChapters.B_Check_The_Weather();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[81].AllAnim();
        }
    }
    //82A
    public void AButtonC82()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[79].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC82", 1.1f);
        Invoke("AInvokerAchievements81", 2.2f);
    }
    private void AInvokerC82()
    {
        ACharter82UI(81);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements81()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements7();
    }
    private void ACharter82UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        logicValuesChapters.B_Check_The_Weather();

        animContent[81].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //83
    public void ButtonC83()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC83", 0.5f);
        Invoke("InvokerAchievements82", 6.5f);
    }
    public void InvokerC83()
    {
        Charter83UI(82);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements82()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter83UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[82].AllAnim();
        }
    }
    //83A
    public void AButtonC83()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[51].AllAnim1();
        animContent[79].AllAnim1();
        animContent[81].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC83", 1.1f);
        Invoke("AInvokerAchievements82", 2.2f);
    }
    private void AInvokerC83()
    {
        ACharter83UI(82);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements82()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter83UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[82].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //84
    public void ButtonC84()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC84", 0.5f);
        Invoke("InvokerAchievements83", 6.5f);
    }
    public void InvokerC84()
    {
        Charter84UI(83);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements83()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter84UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_The_Lounge();

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[26].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[26].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[27].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[27].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[28].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[28].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[29].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[29].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[83].AllAnim();
        }
    }
    //84A
    public void AButtonC84()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[82].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC84", 1.1f);
        Invoke("AInvokerAchievements83", 2.2f);
    }
    private void AInvokerC84()
    {
        ACharter84UI(83);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements83()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter84UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_The_Lounge();

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[26].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[26].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[27].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[27].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[28].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[28].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[29].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[29].gameObject.SetActive(false);
        }

        animContent[83].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //85
    public void ButtonC85()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC85", 0.5f);
        Invoke("InvokerAchievements84", 6.5f);
    }
    public void InvokerC85()
    {
        Charter85UI(84);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements84()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter85UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_The_Food_Court();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[30].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[30].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[31].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[31].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[32].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[32].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[33].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[33].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[84].AllAnim();
        }
    }

    //86
    public void ButtonC86()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC86", 0.5f);
        Invoke("InvokerAchievements85", 6.5f);
    }
    public void InvokerC86()
    {
        Charter86UI(85);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements85()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter86UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Halls();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[34].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[34].gameObject.SetActive(false);
        }

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[35].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[35].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[36].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[36].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[37].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[37].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[85].AllAnim();
        }
    }

    //87
    public void ButtonC87()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC87", 0.5f);
        Invoke("InvokerAchievements86", 6.5f);
    }
    public void InvokerC87()
    {
        Charter87UI(86);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements86()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter87UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Gates();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[38].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[38].gameObject.SetActive(false);
        }

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[39].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[39].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[40].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[40].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[41].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[41].gameObject.SetActive(false);
        }
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[86].AllAnim();
        }
    }

    //88
    public void ButtonC88()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC88", 0.5f);
        Invoke("InvokerAchievements87", 6.5f);
    }
    public void InvokerC88()
    {
        Charter88UI(87);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements87()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter88UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[87].AllAnim();
        }
    }
    //88A
    public void AButtonC88()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[86].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC88", 1.1f);
        Invoke("AInvokerAchievements87", 2.2f);
    }
    private void AInvokerC88()
    {
        ACharter88UI(87);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements87()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter88UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[87].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //89
    public void ButtonC89()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC89", 0.5f);
        Invoke("InvokerAchievements88", 6.5f);
    }
    public void InvokerC89()
    {
        Charter89UI(88);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements88()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter89UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_buy_book == 0)
        {
            buttonIf[42].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[42].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[43].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[43].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[44].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[44].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[45].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[45].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[88].AllAnim();
        }
    }

    //90
    public void ButtonC90()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC90", 0.5f);
        Invoke("InvokerAchievements89", 6.5f);
    }
    public void InvokerC90()
    {
        Charter90UI(89);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements89()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter90UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_buy_book == 0)
        {
            buttonIf[46].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[46].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[47].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[47].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[48].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[48].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[49].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[49].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[89].AllAnim();
        }
    }
    //90A
    public void AButtonC90()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[64].AllAnim1();
        animContent[88].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC90", 1.1f);
        Invoke("AInvokerAchievements89", 2.2f);
    }
    private void AInvokerC90()
    {
        ACharter90UI(89);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements89()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter90UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_buy_book == 0)
        {
            buttonIf[46].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[46].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[47].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[47].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[48].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[48].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[49].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[49].gameObject.SetActive(false);
        }

        animContent[89].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //91
    public void ButtonC91()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC91", 0.5f);
        Invoke("InvokerAchievements90", 6.5f);
    }
    public void InvokerC91()
    {
        Charter91UI(90);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements90()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements8();
    }
    public void Charter91UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[90].AllAnim();
        }
    }
    //91A
    public void AButtonC91()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[64].AllAnim1();
        animContent[88].AllAnim1();
        animContent[89].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC91", 1.1f);
        Invoke("AInvokerAchievements90", 2.2f);
    }
    private void AInvokerC91()
    {
        ACharter91UI(90);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements90()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements8();
    }
    private void ACharter91UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[90].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //92
    public void ButtonC92()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC92", 0.5f);
        Invoke("InvokerAchievements91", 6.5f);
    }
    public void InvokerC92()
    {
        Charter92UI(91);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements91()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter92UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[91].AllAnim();
        }
    }
    //92A
    public void AButtonC92()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[64].AllAnim1();
        animContent[88].AllAnim1();
        animContent[89].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC92", 1.1f);
        Invoke("AInvokerAchievements91", 2.2f);
    }
    private void AInvokerC92()
    {
        ACharter92UI(91);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements91()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter92UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[91].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //93
    public void ButtonC93()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC93", 0.5f);
        Invoke("InvokerAchievements92", 6.5f);
    }
    public void InvokerC93()
    {
        Charter93UI(92);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements92()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements9();
    }
    public void Charter93UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[92].AllAnim();
        }
    }
    //93A
    public void AButtonC93()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[64].AllAnim1();
        animContent[88].AllAnim1();
        animContent[89].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC93", 1.1f);
        Invoke("AInvokerAchievements92", 2.2f);
    }
    private void AInvokerC93()
    {
        ACharter93UI(92);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements92()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements9();
    }
    private void ACharter93UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[92].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //94
    public void ButtonC94()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC94", 0.5f);
        Invoke("InvokerAchievements93", 6.5f);
    }
    public void InvokerC94()
    {
        Charter94UI(93);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements93()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter94UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[93].AllAnim();
        }
    }
    //94A
    public void AButtonC94()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[64].AllAnim1();
        animContent[88].AllAnim1();
        animContent[89].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC94", 1.1f);
        Invoke("AInvokerAchievements93", 2.2f);
    }
    private void AInvokerC94()
    {
        ACharter94UI(93);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements93()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter94UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[93].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //95
    public void ButtonC95()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC95", 0.5f);
        Invoke("InvokerAchievements94", 6.5f);
    }
    public void InvokerC95()
    {
        Charter95UI(94);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements94()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter95UI(int index)
    {
        toBeContinued.text = "Chapter 1";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[94].AllAnim();
        }
    }
    //96_2
    public void ButtonC96_2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("ActiveImg2", 0.5f);
        Invoke("Bda2", 8.0f);
        Invoke("InvokerC96_3", 8.5f);
        Invoke("InvokerAchievements96_2", 13.5f);
    }
    public void ActiveImg2()
    {
        Img2.gameObject.SetActive(true);
        Img_charter_2.gameObject.SetActive(true);
        charter[90].SetActive(false);
        charter[92].SetActive(false);
        panel.SetActive(false);
        animContent[184].AllAnim();
        musicCharter.StopMusic();
        sound.PlaySound(9);
    }
    public void Bda2()
    {
        anim.Play("BlackoutDarkAnimation");
    }
    public void InvokerC96_3()
    {
        Charter96_2UI(95);
        panel.SetActive(true);
        Img_charter_2.gameObject.SetActive(false);
        Img2.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements96_2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter96_2UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //96
    public void ButtonC96()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC96", 0.5f);
        Invoke("InvokerAchievements95", 6.5f);
    }
    public void InvokerC96()
    {
        Charter96UI(95);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements95()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter96UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[95].AllAnim();
        }
        //sound.PlaySound(9);
    }

    //97
    public void ButtonC97()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC97", 0.5f);
        Invoke("InvokerAchievements96", 6.5f);
    }
    public void InvokerC97()
    {
        Charter97UI(96);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements96()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter97UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[96].AllAnim();
        }
    }
    //97A
    public void AButtonC97()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[95].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC97", 1.1f);
        Invoke("AInvokerAchievements96", 2.2f);
    }
    private void AInvokerC97()
    {
        ACharter97UI(96);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements96()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter97UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[96].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //98
    public void ButtonC98()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC98", 0.5f);
        Invoke("InvokerAchievements97", 6.5f);
    }
    public void InvokerC98()
    {
        Charter98UI(97);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements97()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements10();
    }
    public void Charter98UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[97].AllAnim();
        }
    }
    //98A
    public void AButtonC98()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[96].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC98", 1.1f);
        Invoke("AInvokerAchievements97", 2.2f);
    }
    private void AInvokerC98()
    {
        ACharter98UI(97);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements97()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements10();
    }
    private void ACharter98UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[97].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //99
    public void ButtonC99()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC99", 0.5f);
        Invoke("InvokerAchievements98", 6.5f);
    }
    public void InvokerC99()
    {
        Charter99UI(98);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements98()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter99UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[98].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //100
    public void ButtonC100()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC100", 0.5f);
        Invoke("InvokerAchievements99", 6.5f);
    }
    public void InvokerC100()
    {
        Charter100UI(99);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements99()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter100UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[99].AllAnim();
        }
    }
    //100A
    public void AButtonC100()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[98].AllAnim1();
        animContent[121].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC100", 1.1f);
        Invoke("AInvokerAchievements99", 2.2f);
    }
    private void AInvokerC100()
    {
        ACharter100UI(99);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements99()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter100UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[99].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //101
    public void ButtonC101()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC101", 0.5f);
        Invoke("InvokerAchievements100", 6.5f);
    }
    public void InvokerC101()
    {
        Charter101UI(100);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements100()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter101UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[100].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //101A
    public void AButtonC101()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[97].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC101", 1.1f);
        Invoke("AInvokerAchievements100", 2.2f);
    }
    private void AInvokerC101()
    {
        ACharter101UI(100);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements100()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter101UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[100].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //102
    public void ButtonC102()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC102", 0.5f);
        Invoke("InvokerAchievements101", 6.5f);
    }
    public void InvokerC102()
    {
        Charter102UI(101);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements101()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter102UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[101].AllAnim();
        }
    }

    //103
    public void ButtonC103()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC103", 0.5f);
        Invoke("InvokerAchievements102", 6.5f);
    }
    public void InvokerC103()
    {
        Charter103UI(102);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements102()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter103UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[102].AllAnim();
        }
    }
    //103A
    public void AButtonC103()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[99].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC103", 1.1f);
        Invoke("AInvokerAchievements102", 2.2f);
    }
    private void AInvokerC103()
    {
        ACharter103UI(102);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements102()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter103UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[102].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //104
    public void ButtonC104()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC104", 0.5f);
        Invoke("InvokerAchievements103", 6.5f);
    }
    public void InvokerC104()
    {
        Charter104UI(103);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements103()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter104UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[103].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //104A
    public void AButtonC104()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[99].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC104", 1.1f);
        Invoke("AInvokerAchievements103", 2.2f);
    }
    private void AInvokerC104()
    {
        ACharter104UI(103);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements103()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter104UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[103].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //105
    public void ButtonC105()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC105", 0.5f);
        Invoke("InvokerAchievements104", 6.5f);
    }
    public void InvokerC105()
    {
        Charter105UI(104);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements104()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter105UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[104].AllAnim();
        }
    }
    //105A
    public void AButtonC105()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[98].AllAnim1();
        animContent[121].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC105", 1.1f);
        Invoke("AInvokerAchievements104", 2.2f);
    }
    private void AInvokerC105()
    {
        ACharter105UI(104);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements104()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter105UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[104].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //106
    public void ButtonC106()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC106", 0.5f);
        Invoke("InvokerAchievements105", 6.5f);
    }
    public void InvokerC106()
    {
        Charter106UI(105);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements105()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter106UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[105].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //106A
    public void AButtonC106()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[98].AllAnim1();
        animContent[121].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC106", 1.1f);
        Invoke("AInvokerAchievements105", 2.2f);
    }
    private void AInvokerC106()
    {
        ACharter106UI(105);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements105()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter106UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[105].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //107
    public void ButtonC107()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC107", 0.5f);
        Invoke("InvokerAchievements106", 6.5f);
    }
    public void InvokerC107()
    {
        Charter107UI(106);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements106()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter107UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[106].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //107A
    public void AButtonC107()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[100].AllAnim1();
        animContent[127].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC107", 1.1f);
        Invoke("AInvokerAchievements106", 2.2f);
    }
    private void AInvokerC107()
    {
        ACharter107UI(106);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements106()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter107UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[106].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //108
    public void ButtonC108()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC108", 0.5f);
        Invoke("InvokerAchievements107", 6.5f);
    }
    public void InvokerC108()
    {
        Charter108UI(107);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements107()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter108UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[107].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //109
    public void ButtonC109()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC109", 0.5f);
        Invoke("InvokerAchievements108", 6.5f);
    }
    public void InvokerC109()
    {
        Charter109UI(108);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements108()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter109UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[108].AllAnim();
        }
    }
    //109A
    public void AButtonC109()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[107].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC109", 1.1f);
        Invoke("AInvokerAchievements108", 2.2f);
    }
    private void AInvokerC109()
    {
        ACharter109UI(108);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements108()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter109UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[108].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //110
    public void ButtonC110()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC110", 0.5f);
        Invoke("InvokerAchievements109", 6.5f);
    }
    public void InvokerC110()
    {
        Charter110UI(109);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements109()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter110UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[109].AllAnim();
        }
    }
    //110A
    public void AButtonC110()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[108].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC110", 1.1f);
        Invoke("AInvokerAchievements109", 2.2f);
    }
    private void AInvokerC110()
    {
        ACharter110UI(109);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements109()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter110UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[109].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //111
    public void ButtonC111()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC111", 0.5f);
        Invoke("InvokerAchievements110", 6.5f);
    }
    public void InvokerC111()
    {
        Charter111UI(110);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements110()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter111UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[110].AllAnim();
        }
    }
    //111A
    public void AButtonC111()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[109].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC111", 1.1f);
        Invoke("AInvokerAchievements110", 2.2f);
    }
    private void AInvokerC111()
    {
        ACharter111UI(110);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements110()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter111UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[110].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //112
    public void ButtonC112()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC112", 0.5f);
        Invoke("InvokerAchievements111", 6.5f);
    }
    public void InvokerC112()
    {
        Charter112UI(111);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements111()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter112UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[111].AllAnim();
        }
    }
    //112A
    public void AButtonC112()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[110].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC112", 1.1f);
        Invoke("AInvokerAchievements111", 2.2f);
    }
    private void AInvokerC112()
    {
        ACharter112UI(111);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements111()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter112UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[111].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //113
    public void ButtonC113()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC113", 0.5f);
        Invoke("InvokerAchievements112", 6.5f);
    }
    public void InvokerC113()
    {
        Charter113UI(112);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements112()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter113UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[112].AllAnim();
        }
    }
    //113A
    public void AButtonC113()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[111].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC113", 1.1f);
        Invoke("AInvokerAchievements112", 2.2f);
    }
    private void AInvokerC113()
    {
        ACharter113UI(112);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements112()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter113UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[112].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //114
    public void ButtonC114()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC114", 0.5f);
        Invoke("InvokerAchievements113", 6.5f);
    }
    public void InvokerC114()
    {
        Charter114UI(113);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements113()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter114UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[113].AllAnim();
        }
    }
    //114A
    public void AButtonC114()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[112].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC114", 1.1f);
        Invoke("AInvokerAchievements113", 2.2f);
    }
    private void AInvokerC114()
    {
        ACharter114UI(113);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements113()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter114UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[113].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //115
    public void ButtonC115()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC115", 0.5f);
        Invoke("InvokerAchievements114", 6.5f);
    }
    public void InvokerC115()
    {
        Charter115UI(114);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements114()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter115UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[114].AllAnim();
        }
    }
    //115A
    public void AButtonC115()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[113].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC115", 1.1f);
        Invoke("AInvokerAchievements114", 2.2f);
    }
    private void AInvokerC115()
    {
        ACharter115UI(114);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements114()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter115UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[114].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //116
    public void ButtonC116()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC116", 0.5f);
        Invoke("InvokerAchievements115", 6.5f);
    }
    public void InvokerC116()
    {
        Charter116UI(115);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements115()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter116UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[115].AllAnim();
        }
    }
    //116A
    public void AButtonC116()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[114].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC116", 1.1f);
        Invoke("AInvokerAchievements115", 2.2f);
    }
    private void AInvokerC116()
    {
        ACharter116UI(115);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements115()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter116UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[115].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //117
    public void ButtonC117()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC117", 0.5f);
        Invoke("InvokerAchievements116", 6.5f);
    }
    public void InvokerC117()
    {
        Charter117UI(116);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements116()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter117UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[116].AllAnim();
        }
    }
    //117A
    public void AButtonC117()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[115].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC117", 1.1f);
        Invoke("AInvokerAchievements116", 2.2f);
    }
    private void AInvokerC117()
    {
        ACharter117UI(116);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements116()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter117UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[116].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //118
    public void ButtonC118()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC118", 0.5f);
        Invoke("InvokerAchievements117", 6.5f);
    }
    public void InvokerC118()
    {
        Charter118UI(117);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements117()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter118UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[117].AllAnim();
        }
    }
    //118A
    public void AButtonC118()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[116].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC118", 1.1f);
        Invoke("AInvokerAchievements117", 2.2f);
    }
    private void AInvokerC118()
    {
        ACharter118UI(117);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements117()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter118UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[117].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //119
    public void ButtonC119()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC119", 0.5f);
        Invoke("InvokerAchievements118", 6.5f);
    }
    public void InvokerC119()
    {
        Charter119UI(118);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements118()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter119UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[118].AllAnim();
        }
    }
    //119A
    public void AButtonC119()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[117].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC119", 1.1f);
        Invoke("AInvokerAchievements118", 2.2f);
    }
    private void AInvokerC119()
    {
        ACharter119UI(118);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements118()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter119UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[118].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //120
    public void ButtonC120()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC120", 0.5f);
        Invoke("InvokerAchievements119", 6.5f);
    }
    public void InvokerC120()
    {
        Charter120UI(119);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements119()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter120UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[119].AllAnim();
        }
    }
    //120A
    public void AButtonC120()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[118].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC120", 1.1f);
        Invoke("AInvokerAchievements119", 2.2f);
    }
    private void AInvokerC120()
    {
        ACharter120UI(119);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements119()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter120UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[119].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //121
    public void ButtonC121()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC121", 0.5f);
        Invoke("InvokerAchievements120", 6.5f);
    }
    public void InvokerC121()
    {
        Charter121UI(120);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements120()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter121UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[120].AllAnim();
        }
    }
    //121A
    public void AButtonC121()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[107].AllAnim1();
        animContent[109].AllAnim1();
        animContent[113].AllAnim1();
        animContent[115].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC121", 1.1f);
        Invoke("AInvokerAchievements120", 2.2f);
    }
    private void AInvokerC121()
    {
        ACharter121UI(120);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements120()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter121UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[120].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //122
    public void ButtonC122()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC122", 0.5f);
        Invoke("InvokerAchievements121", 6.5f);
    }
    public void InvokerC122()
    {
        Charter122UI(121);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements121()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter122UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[121].AllAnim();
        }
    }
    //122A
    public void AButtonC122()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[120].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC122", 1.1f);
        Invoke("AInvokerAchievements121", 2.2f);
    }
    private void AInvokerC122()
    {
        ACharter122UI(121);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements121()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter122UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[121].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //123
    public void ButtonC123()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC123", 0.5f);
        Invoke("InvokerAchievements122", 6.5f);
    }
    public void InvokerC123()
    {
        Charter123UI(122);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements122()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter123UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[122].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //123A
    public void AButtonC123()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[107].AllAnim1();
        animContent[109].AllAnim1();
        animContent[111].AllAnim1();
        animContent[113].AllAnim1();
        animContent[115].AllAnim1();
        animContent[117].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC123", 1.1f);
        Invoke("AInvokerAchievements122", 2.2f);
    }
    private void AInvokerC123()
    {
        ACharter123UI(122);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements122()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter123UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[122].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //124
    public void ButtonC124()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC124", 0.5f);
        Invoke("InvokerAchievements123", 6.5f);
    }
    public void InvokerC124()
    {
        Charter124UI(123);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements123()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements11();
    }
    public void Charter124UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[123].AllAnim();
        }
        sound.PlaySound(10);
    }
    //124A
    public void AButtonC124()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[111].AllAnim1();
        animContent[117].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC124", 1.1f);
        Invoke("AInvokerAchievements123", 2.2f);
    }
    private void AInvokerC124()
    {
        ACharter124UI(123);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements123()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements11();
    }
    private void ACharter124UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[123].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(10);
    }

    //125
    public void ButtonC125()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC125", 0.5f);
        Invoke("InvokerAchievements124", 6.5f);
    }
    public void InvokerC125()
    {
        Charter125UI(124);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements124()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter125UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[124].AllAnim();
        }
    }
    //125A
    public void AButtonC125()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[123].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC125", 1.1f);
        Invoke("AInvokerAchievements124", 2.2f);
    }
    private void AInvokerC125()
    {
        ACharter125UI(124);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements124()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter125UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[124].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //126
    public void ButtonC126()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC126", 0.5f);
        Invoke("InvokerAchievements125", 6.5f);
    }
    public void InvokerC126()
    {
        Charter126UI(125);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements125()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements12();
    }
    public void Charter126UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        logicValuesChapters.B_Take_The_Knife();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[125].AllAnim();
        }
    }
    //126A
    public void AButtonC126()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[124].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC126", 1.1f);
        Invoke("AInvokerAchievements125", 2.2f);
    }
    private void AInvokerC126()
    {
        ACharter126UI(125);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements125()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements12();
    }
    private void ACharter126UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        logicValuesChapters.B_Take_The_Knife();

        animContent[125].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //127
    public void ButtonC127()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC127", 0.5f);
        Invoke("InvokerAchievements126", 6.5f);
    }
    public void InvokerC127()
    {
        Charter127UI(126);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements126()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter127UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[126].AllAnim();
        }
    }
    //127A
    public void AButtonC127()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[125].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC127", 1.1f);
        Invoke("AInvokerAchievements126", 2.2f);
    }
    private void AInvokerC127()
    {
        ACharter127UI(126);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements126()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter127UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[126].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //128
    public void ButtonC128()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC128", 0.5f);
        Invoke("InvokerAchievements127", 6.5f);
    }
    public void InvokerC128()
    {
        Charter128UI(127);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements127()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter128UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[127].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //129
    public void ButtonC129()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC129", 0.5f);
        Invoke("InvokerAchievements128", 6.5f);
    }
    public void InvokerC129()
    {
        Charter129UI(128);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements128()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter129UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[128].AllAnim();
        }
    }
    //129A
    public void AButtonC129()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[124].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC129", 1.1f);
        Invoke("AInvokerAchievements128", 2.2f);
    }
    private void AInvokerC129()
    {
        ACharter129UI(128);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements128()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter129UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[128].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //130
    public void ButtonC130()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC130", 0.5f);
        Invoke("InvokerAchievements129", 6.5f);
    }
    public void InvokerC130()
    {
        Charter130UI(129);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements129()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter130UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[129].AllAnim();
        }
    }
    //130A
    public void AButtonC130()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[126].AllAnim1();
        animContent[128].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC130", 1.1f);
        Invoke("AInvokerAchievements129", 2.2f);
    }
    private void AInvokerC130()
    {
        ACharter130UI(129);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements129()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter130UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[129].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //131
    public void ButtonC131()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC131", 0.5f);
        Invoke("InvokerAchievements130", 6.5f);
    }
    public void InvokerC131()
    {
        Charter131UI(130);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements130()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter131UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Fight();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[130].AllAnim();
        }
    }
    //131A
    public void AButtonC131()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[129].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC131", 1.1f);
        Invoke("AInvokerAchievements130", 2.2f);
    }
    private void AInvokerC131()
    {
        ACharter131UI(130);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements130()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter131UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Fight();

        animContent[130].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //132
    public void ButtonC132()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC132", 0.5f);
        Invoke("InvokerAchievements131", 6.5f);
    }
    public void InvokerC132()
    {
        Charter132UI(131);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements131()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements13();
    }
    public void Charter132UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[131].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //132A
    public void AButtonC132()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[129].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC132", 1.1f);
        Invoke("AInvokerAchievements131", 2.2f);
    }
    private void AInvokerC132()
    {
        ACharter132UI(131);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements131()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements13();
    }
    private void ACharter132UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 3;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[131].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //133
    public void ButtonC133()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC133", 0.5f);
        Invoke("InvokerAchievements132", 6.5f);
    }
    public void InvokerC133()
    {
        Charter133UI(132);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements132()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter133UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[132].AllAnim();
        }
        sound.PlaySound(11);
    }
    //133A
    public void AButtonC133()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[131].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC133", 1.1f);
        Invoke("AInvokerAchievements132", 2.2f);
    }
    private void AInvokerC133()
    {
        ACharter133UI(132);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements132()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter133UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[132].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(11);
    }

    //134
    public void ButtonC134()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC134", 0.5f);
        Invoke("InvokerAchievements133", 6.5f);
    }
    public void InvokerC134()
    {
        Charter134UI(133);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements133()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter134UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[133].AllAnim();
        }
        sound.PlaySound(12);
    }
    //134A
    public void AButtonC134()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[131].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC134", 1.1f);
        Invoke("AInvokerAchievements133", 2.2f);
    }
    private void AInvokerC134()
    {
        ACharter134UI(133);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements133()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter134UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[133].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(12);
    }

    //135
    public void ButtonC135()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC135", 0.5f);
        Invoke("InvokerAchievements134", 6.5f);
    }
    public void InvokerC135()
    {
        Charter135UI(134);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements134()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter135UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[134].AllAnim();
        }
        sound.PlaySound(11);
    }
    //135A
    public void AButtonC135()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[131].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC135", 1.1f);
        Invoke("AInvokerAchievements134", 2.2f);
    }
    private void AInvokerC135()
    {
        ACharter135UI(134);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements134()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter135UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[134].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(11);
    }

    //136
    public void ButtonC136()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC136", 0.5f);
        Invoke("InvokerAchievements135", 6.5f);
    }
    public void InvokerC136()
    {
        Charter136UI(135);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements135()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter136UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[135].AllAnim();
        }
    }
    //136A
    public void AButtonC136()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[132].AllAnim1();
        animContent[133].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC136", 1.1f);
        Invoke("AInvokerAchievements135", 2.2f);
    }
    private void AInvokerC136()
    {
        ACharter136UI(135);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements135()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter136UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[135].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //137
    public void ButtonC137()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC137", 0.5f);
        Invoke("InvokerAchievements136", 6.5f);
    }
    public void InvokerC137()
    {
        Charter137UI(136);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements136()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter137UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_take_the_knife == 0)
        {
            buttonIf[82].gameObject.SetActive(false);
        }
        else
        {
            buttonIf[82].gameObject.SetActive(true);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[136].AllAnim();
        }
    }
    //137A
    public void AButtonC137()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[133].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC137", 1.1f);
        Invoke("AInvokerAchievements136", 2.2f);
    }
    private void AInvokerC137()
    {
        ACharter137UI(136);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements136()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter137UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_take_the_knife == 0)
        {
            buttonIf[82].gameObject.SetActive(false);
        }
        else
        {
            buttonIf[82].gameObject.SetActive(true);
        }

        animContent[136].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //138
    public void ButtonC138()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC138", 0.5f);
        Invoke("InvokerAchievements137", 6.5f);
    }
    public void InvokerC138()
    {
        Charter138UI(137);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements137()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter138UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[137].AllAnim();
        }
    }
    //138A
    public void AButtonC138()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[136].AllAnim1();
        animContent[138].AllAnim1();
        animContent[139].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC138", 1.1f);
        Invoke("AInvokerAchievements137", 2.2f);
    }
    private void AInvokerC138()
    {
        ACharter138UI(137);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements137()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter138UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[137].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //139
    public void ButtonC139()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC139", 0.5f);
        Invoke("InvokerAchievements138", 6.5f);
    }
    public void InvokerC139()
    {
        Charter139UI(138);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements138()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter139UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_take_the_knife == 0)
        {
            buttonIf[83].gameObject.SetActive(false);
        }
        else
        {
            buttonIf[83].gameObject.SetActive(true);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[138].AllAnim();
        }
    }
    //139A
    public void AButtonC139()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[132].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC139", 1.1f);
        Invoke("AInvokerAchievements138", 2.2f);
    }
    private void AInvokerC139()
    {
        ACharter139UI(138);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements138()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter139UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        if (gameManager.b_take_the_knife == 0)
        {
            buttonIf[83].gameObject.SetActive(false);
        }
        else
        {
            buttonIf[83].gameObject.SetActive(true);
        }

        animContent[138].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //140
    public void ButtonC140()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC140", 0.5f);
        Invoke("InvokerAchievements139", 6.5f);
    }
    public void InvokerC140()
    {
        Charter140UI(139);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements139()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter140UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[139].AllAnim();
        }
        sound.PlaySound(11);
    }
    //140A
    public void AButtonC140()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[136].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC140", 1.1f);
        Invoke("AInvokerAchievements139", 2.2f);
    }
    private void AInvokerC140()
    {
        ACharter140UI(139);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements139()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter140UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[139].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(11);
    }

    //141
    public void ButtonC141()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC141", 0.5f);
        Invoke("InvokerAchievements140", 6.5f);
    }
    public void InvokerC141()
    {
        Charter141UI(140);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements140()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter141UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[140].AllAnim();
        }
    }
    //141A
    public void AButtonC141()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[136].AllAnim1();
        animContent[138].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC141", 1.1f);
        Invoke("AInvokerAchievements140", 2.2f);
    }
    private void AInvokerC141()
    {
        ACharter141UI(140);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements140()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter141UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[140].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //142
    public void ButtonC142()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC142", 0.5f);
        Invoke("InvokerAchievements141", 6.5f);
    }
    public void InvokerC142()
    {
        Charter142UI(141);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements141()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter142UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[141].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //142A
    public void AButtonC142()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[138].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC142", 1.1f);
        Invoke("AInvokerAchievements141", 2.2f);
    }
    private void AInvokerC142()
    {
        ACharter142UI(141);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements141()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter142UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        gameManager.numberMusic = 1;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[141].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //143
    public void ButtonC143()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC143", 0.5f);
        Invoke("InvokerAchievements142", 6.5f);
    }
    public void InvokerC143()
    {
        Charter143UI(142);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements142()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter143UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[142].AllAnim();
        }
    }
    //143A
    public void AButtonC143()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[136].AllAnim1();
        animContent[138].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC143", 1.1f);
        Invoke("AInvokerAchievements142", 2.2f);
    }
    private void AInvokerC143()
    {
        ACharter143UI(142);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements142()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter143UI(int index)
    {
        toBeContinued.text = "Chapter 2";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[142].AllAnim2();
        animContentPanel.AllAnimP();
    }
    //144_2
    public void ButtonC144_2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("ActiveImg3", 0.5f);
        Invoke("Bda3", 8.0f);
        Invoke("InvokerC144_3", 8.5f);
        Invoke("InvokerAchievements144_2", 13.5f);
    }
    public void ActiveImg3()
    {
        Img2.gameObject.SetActive(true);
        Img_charter_3.gameObject.SetActive(true);
        charter[106].SetActive(false);
        charter[137].SetActive(false);
        charter[140].SetActive(false);
        panel.SetActive(false);
        animContent[185].AllAnim();
        musicCharter.StopMusic();
        sound.PlaySound(23);
    }
    public void Bda3()
    {
        anim.Play("BlackoutDarkAnimation");
    }
    public void InvokerC144_3()
    {
        Charter144_2UI(143);
        panel.SetActive(true);
        Img_charter_3.gameObject.SetActive(false);
        Img2.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements144_2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter144_2UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //144
    public void ButtonC144()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC144", 0.5f);
        Invoke("InvokerAchievements143", 6.5f);
    }
    public void InvokerC144()
    {
        Charter144UI(143);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements143()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter144UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        gameManager.numberMusic = 0;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[143].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //145
    public void ButtonC145()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC145", 0.5f);
        Invoke("InvokerAchievements144", 6.5f);
    }
    public void InvokerC145()
    {
        Charter145UI(144);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements144()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter145UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Looking_Around();

        if (gameManager.b_check_for_survivors == 0)
        {
            buttonIf[50].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[50].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[144].AllAnim();
        }
    }
    //145A
    public void AButtonC145()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[143].AllAnim1();
        animContent[145].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC145", 1.1f);
        Invoke("AInvokerAchievements144", 2.2f);
    }
    private void AInvokerC145()
    {
        ACharter145UI(144);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements144()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter145UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Looking_Around();

        if (gameManager.b_check_for_survivors == 0)
        {
            buttonIf[50].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[50].gameObject.SetActive(false);
        }

        animContent[144].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //146
    public void ButtonC146()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC146", 0.5f);
        Invoke("InvokerAchievements145", 6.5f);
    }
    public void InvokerC146()
    {
        Charter146UI(145);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements145()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter146UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Check_For_Survivors();

        if (gameManager.b_looking_around == 0)
        {
            buttonIf[51].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[51].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[145].AllAnim();
        }
    }
    //146A
    public void AButtonC146()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[143].AllAnim1();
        animContent[144].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC146", 1.1f);
        Invoke("AInvokerAchievements145", 2.2f);
    }
    private void AInvokerC146()
    {
        ACharter146UI(145);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements145()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter146UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Check_For_Survivors();

        if (gameManager.b_looking_around == 0)
        {
            buttonIf[51].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[51].gameObject.SetActive(false);
        }

        animContent[145].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //147
    public void ButtonC147()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC147", 0.5f);
        Invoke("InvokerAchievements146", 6.5f);
    }
    public void InvokerC147()
    {
        Charter147UI(146);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements146()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter147UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[146].AllAnim();
        }
    }
    //147A
    public void AButtonC147()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[147].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC147", 1.1f);
        Invoke("AInvokerAchievements146", 2.2f);
    }
    private void AInvokerC147()
    {
        ACharter147UI(146);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements146()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter147UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[146].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //148
    public void ButtonC148()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC148", 0.5f);
        Invoke("InvokerAchievements147", 6.5f);
    }
    public void InvokerC148()
    {
        Charter148UI(147);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements147()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter148UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[147].AllAnim();
        }
    }

    //149
    public void ButtonC149()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC149", 0.5f);
        Invoke("InvokerAchievements148", 6.5f);
    }
    public void InvokerC149()
    {
        Charter149UI(148);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements148()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter149UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[148].AllAnim();
        }
    }

    //150
    public void ButtonC150()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC150", 0.5f);
        Invoke("InvokerAchievements149", 6.5f);
    }
    public void InvokerC150()
    {
        Charter150UI(149);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements149()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter150UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[149].AllAnim();
        }
        sound.PlaySound(13);
    }
    //150A
    public void AButtonC150()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[148].AllAnim1();
        animContent[151].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC150", 1.1f);
        Invoke("AInvokerAchievements149", 2.2f);
    }
    private void AInvokerC150()
    {
        ACharter150UI(149);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements149()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter150UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[149].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(13);
    }

    //151
    public void ButtonC151()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC151", 0.5f);
        Invoke("InvokerAchievements150", 6.5f);
    }
    public void InvokerC151()
    {
        Charter151UI(150);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements150()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter151UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[150].AllAnim();
        }
        sound.PlaySound(14);
    }
    //151A
    public void AButtonC151()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[148].AllAnim1();
        animContent[151].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC151", 1.1f);
        Invoke("AInvokerAchievements150", 2.2f);
    }
    private void AInvokerC151()
    {
        ACharter151UI(150);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements150()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter151UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[150].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(14);
    }

    //152
    public void ButtonC152()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC152", 0.5f);
        Invoke("InvokerAchievements151", 6.5f);
    }
    public void InvokerC152()
    {
        Charter152UI(151);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements151()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter152UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[151].AllAnim();
        }
    }
    //152A
    public void AButtonC152()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[148].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC152", 1.1f);
        Invoke("AInvokerAchievements151", 2.2f);
    }
    private void AInvokerC152()
    {
        ACharter152UI(151);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements151()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter152UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[151].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //153
    public void ButtonC153()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC153", 0.5f);
        Invoke("InvokerAchievements152", 6.5f);
    }
    public void InvokerC153()
    {
        Charter153UI(152);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements152()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter153UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[152].AllAnim();
        }
    }
    //153A
    public void AButtonC153()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[149].AllAnim1();
        animContent[150].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC153", 1.1f);
        Invoke("AInvokerAchievements152", 2.2f);
    }
    private void AInvokerC153()
    {
        ACharter153UI(152);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements152()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter153UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[152].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //154
    public void ButtonC154()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC154", 0.5f);
        Invoke("InvokerAchievements153", 6.5f);
    }
    public void InvokerC154()
    {
        Charter154UI(153);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements153()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter154UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[153].AllAnim();
        }
    }
    //154A
    public void AButtonC154()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[152].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC154", 1.1f);
        Invoke("AInvokerAchievements153", 2.2f);
    }
    private void AInvokerC154()
    {
        ACharter154UI(153);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements153()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter154UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[153].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //155
    public void ButtonC155()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC155", 0.5f);
        Invoke("InvokerAchievements154", 6.5f);
    }
    public void InvokerC155()
    {
        Charter155UI(154);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements154()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter155UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[154].AllAnim();
        }
    }

    //156
    public void ButtonC156()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC156", 0.5f);
        Invoke("InvokerAchievements155", 6.5f);
    }
    public void InvokerC156()
    {
        Charter156UI(155);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements155()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter156UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[155].AllAnim();
        }
    }
    //156A
    public void AButtonC156()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[154].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC156", 1.1f);
        Invoke("AInvokerAchievements155", 2.2f);
    }
    private void AInvokerC156()
    {
        ACharter156UI(155);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements155()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter156UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[155].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //157
    public void ButtonC157()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC157", 0.5f);
        Invoke("InvokerAchievements156", 6.5f);
    }
    public void InvokerC157()
    {
        Charter157UI(156);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements156()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter157UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[156].AllAnim();
        }
    }
    //157A
    public void AButtonC157()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[155].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC157", 1.1f);
        Invoke("AInvokerAchievements156", 2.2f);
    }
    private void AInvokerC157()
    {
        ACharter157UI(156);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements156()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter157UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[156].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //158
    public void ButtonC158()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC158", 0.5f);
        Invoke("InvokerAchievements157", 6.5f);
    }
    public void InvokerC158()
    {
        Charter158UI(157);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements157()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter158UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[157].AllAnim();
        }
        sound.PlaySound(15);
    }
    //158A
    public void AButtonC158()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[155].AllAnim1();
        animContent[156].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC158", 1.1f);
        Invoke("AInvokerAchievements157", 2.2f);
    }
    private void AInvokerC158()
    {
        ACharter158UI(157);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements157()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter158UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[157].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(15);
    }

    //159
    public void ButtonC159()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC159", 0.5f);
        Invoke("InvokerAchievements158", 6.5f);
    }
    public void InvokerC159()
    {
        Charter159UI(158);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements158()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter159UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[158].AllAnim();
        }
    }
    //159A
    public void AButtonC159()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[155].AllAnim1();
        animContent[156].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC159", 1.1f);
        Invoke("AInvokerAchievements158", 2.2f);
    }
    private void AInvokerC159()
    {
        ACharter159UI(158);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements158()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter159UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[158].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //160
    public void ButtonC160()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC160", 0.5f);
        Invoke("InvokerAchievements159", 6.5f);
    }
    public void InvokerC160()
    {
        Charter160UI(159);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements159()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter160UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[159].AllAnim();
        }
    }

    //161
    public void ButtonC161()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC161", 0.5f);
            Invoke("InvokerAchievements160", 6.5f);
        }
    }
    public void InvokerC161()
    {
        Charter161UI(160);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements160()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter161UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Push_The_Chair();

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[52].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[52].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[53].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[53].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[54].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[54].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[55].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[55].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[56].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[56].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[57].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[57].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[160].AllAnim();
        }
        sound.PlaySound(16);
    }
    //161A
    public void AButtonC161()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[159].AllAnim1();
            animContent[161].AllAnim1();
            animContent[162].AllAnim1();
            animContent[163].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC161", 1.1f);
            Invoke("AInvokerAchievements160", 2.2f);
        }
    }
    private void AInvokerC161()
    {
        ACharter161UI(160);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements160()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter161UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Push_The_Chair();

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[52].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[52].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[53].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[53].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[54].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[54].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[55].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[55].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[56].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[56].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[57].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[57].gameObject.SetActive(false);
        }

        animContent[160].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(16);
    }

    //162
    public void ButtonC162()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC162", 0.5f);
            Invoke("InvokerAchievements161", 6.5f);
        }
    }
    public void InvokerC162()
    {
        Charter162UI(161);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements161()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter162UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        logicValuesChapters.B_Move_The_Luggage();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[58].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[58].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[59].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[59].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[60].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[60].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[61].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[61].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[62].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[62].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[63].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[63].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[161].AllAnim();
        }
        sound.PlaySound(17);
    }
    //162A
    public void AButtonC162()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[159].AllAnim1();
            animContent[160].AllAnim1();
            animContent[162].AllAnim1();
            animContent[163].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC162", 1.1f);
            Invoke("AInvokerAchievements161", 2.2f);
        }
    }
    private void AInvokerC162()
    {
        ACharter162UI(161);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements161()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter162UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        logicValuesChapters.B_Move_The_Luggage();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[58].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[58].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[59].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[59].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[60].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[60].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[61].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[61].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[62].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[62].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[63].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[63].gameObject.SetActive(false);
        }

        animContent[161].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(17);
    }

    //163
    public void ButtonC163()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC163", 0.5f);
            Invoke("InvokerAchievements162", 6.5f);
        }
    }
    public void InvokerC163()
    {
        Charter163UI(162);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements162()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter163UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        logicValuesChapters.B_Pick_Up_The_Tray_Table();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[64].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[64].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[65].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[65].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[66].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[66].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[67].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[67].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[68].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[68].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[69].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[69].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[162].AllAnim();
        }
        sound.PlaySound(21);
    }
    //163A
    public void AButtonC163()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[159].AllAnim1();
            animContent[160].AllAnim1();
            animContent[161].AllAnim1();
            animContent[163].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC163", 1.1f);
            Invoke("AInvokerAchievements162", 2.2f);
        }
    }
    private void AInvokerC163()
    {
        ACharter163UI(162);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements162()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter163UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }


        logicValuesChapters.B_Pick_Up_The_Tray_Table();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[64].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[64].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[65].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[65].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[66].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[66].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[67].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[67].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[68].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[68].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[69].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[69].gameObject.SetActive(false);
        }

        animContent[162].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(21);
    }

    //164
    public void ButtonC164()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC164", 0.5f);
            Invoke("InvokerAchievements163", 6.5f);
        }
    }
    public void InvokerC164()
    {
        Charter164UI(163);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements163()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter164UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Pick_Up_The_Bent_Metal();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[70].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[70].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[71].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[71].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[72].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[72].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[73].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[73].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[74].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[74].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[75].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[75].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[163].AllAnim();
        }
        sound.PlaySound(18);
    }
    //164A
    public void AButtonC164()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[159].AllAnim1();
            animContent[160].AllAnim1();
            animContent[161].AllAnim1();
            animContent[162].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC164", 1.1f);
            Invoke("AInvokerAchievements163", 2.2f);
        }
    }
    private void AInvokerC164()
    {
        ACharter164UI(163);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements163()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter164UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Pick_Up_The_Bent_Metal();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[70].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[70].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[71].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[71].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[72].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[72].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[73].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[73].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[74].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[74].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[75].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[75].gameObject.SetActive(false);
        }

        animContent[163].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(18);
    }

    //165
    public void ButtonC165()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC165", 0.5f);
            Invoke("InvokerAchievements164", 6.5f);
        }
    }
    public void InvokerC165()
    {
        Charter165UI(164);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements164()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter165UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Tuck_In_The_Loose_Wires();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[76].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[76].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[77].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[77].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[78].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[78].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[79].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[79].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[80].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[80].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[81].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[81].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[164].AllAnim();
        }

        sound.PlaySound(22);
    }
    //165A
    public void AButtonC165()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[159].AllAnim1();
            animContent[160].AllAnim1();
            animContent[161].AllAnim1();
            animContent[162].AllAnim1();
            animContent[163].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC165", 1.1f);
            Invoke("AInvokerAchievements164", 2.2f);
        }
    }
    private void AInvokerC165()
    {
        ACharter165UI(164);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements164()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter165UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        logicValuesChapters.B_Tuck_In_The_Loose_Wires();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[76].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[76].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[77].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[77].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[78].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[78].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[79].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[79].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[80].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[80].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[81].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[81].gameObject.SetActive(false);
        }

        animContent[164].AllAnim2();
        animContentPanel.AllAnimP();
        sound.PlaySound(22);
    }

    //166
    public void ButtonC166()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC166", 0.5f);
            Invoke("InvokerAchievements165", 6.5f);
        }
    }
    public void InvokerC166()
    {
        Charter166UI(165);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements165()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter166UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[165].AllAnim();
        }
    }
    //166A
    public void AButtonC166()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[160].AllAnim1();
            animContent[161].AllAnim1();
            animContent[162].AllAnim1();
            animContent[163].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC166", 1.1f);
            Invoke("AInvokerAchievements165", 2.2f);
        }
    }
    private void AInvokerC166()
    {
        ACharter166UI(165);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements165()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter166UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[165].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //167
    public void ButtonC167()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC167", 0.5f);
            Invoke("InvokerAchievements166", 6.5f);
        }
    }
    public void InvokerC167()
    {
        Charter167UI(166);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements166()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter167UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[166].AllAnim();
        }
    }
    //167A
    public void AButtonC167()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[160].AllAnim1();
            animContent[161].AllAnim1();
            animContent[162].AllAnim1();
            animContent[163].AllAnim1();
            animContent[164].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC167", 1.1f);
            Invoke("AInvokerAchievements166", 2.2f);
        }
    }
    private void AInvokerC167()
    {
        ACharter167UI(166);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements166()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter167UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[166].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //168
    public void ButtonC168()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC168", 0.5f);
            Invoke("InvokerAchievements167", 6.5f);
        }
    }
    public void InvokerC168()
    {
        Charter168UI(167);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements167()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter168UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_fight == 0)
        {
            buttonIf[82].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[82].gameObject.SetActive(false);
        }

        if (gameManager.b_fight == 1)
        {
            buttonIf[83].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[83].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[167].AllAnim();
        }
    }
    //168A
    public void AButtonC168()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[165].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC168", 1.1f);
            Invoke("AInvokerAchievements167", 2.2f);
        }
    }
    private void AInvokerC168()
    {
        ACharter168UI(167);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements167()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter168UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        if (gameManager.b_fight == 0)
        {
            buttonIf[82].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[82].gameObject.SetActive(false);
        }

        if (gameManager.b_fight == 1)
        {
            buttonIf[83].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[83].gameObject.SetActive(false);
        }


        animContent[167].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //169 - NOOOOOO
    public void ButtonC169()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC169", 0.5f);
        Invoke("InvokerAchievements168", 6.5f);
    }
    public void InvokerC169()
    {
        Charter169UI(168);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements168()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter169UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[168].AllAnim();
        }
    }

    //170 - NOOOOOO
    public void ButtonC170()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC170", 0.5f);
        Invoke("InvokerAchievements169", 6.5f);
    }
    public void InvokerC170()
    {
        Charter170UI(169);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements169()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter170UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[169].AllAnim();
        }
    }

    //171
    public void ButtonC171()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC171", 0.5f);
            Invoke("InvokerAchievements170", 6.5f);
        }
    }
    public void InvokerC171()
    {
        Charter171UI(170);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements170()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter171UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[170].AllAnim();
        }
    }

    //172
    public void ButtonC172()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC172", 0.5f);
            Invoke("InvokerAchievements171", 6.5f);
        }
    }
    public void InvokerC172()
    {
        Charter172UI(171);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements171()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter172UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[171].AllAnim();
        }
        sound.PlaySound(19);
    }

    //173
    public void ButtonC173()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC173", 0.5f);
            Invoke("InvokerAchievements172", 6.5f);
        }
    }
    public void InvokerC173()
    {
        Charter173UI(172);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements172()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements15();
    }
    public void Charter173UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[172].AllAnim();
        }
    }

    //174
    public void ButtonC174()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC174", 0.5f);
            Invoke("InvokerAchievements173", 6.5f);
        }
    }
    public void InvokerC174()
    {
        Charter174UI(173);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements173()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements14();
    }
    public void Charter174UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[173].AllAnim();
        }
    }
    //174A
    public void AButtonC174()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[170].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC174", 1.1f);
            Invoke("AInvokerAchievements173", 2.2f);
        }
    }
    private void AInvokerC174()
    {
        ACharter174UI(173);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements173()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements14();
    }
    private void ACharter174UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[173].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //175
    public void ButtonC175()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC175", 0.5f);
            Invoke("InvokerAchievements174", 6.5f);
        }
    }
    public void InvokerC175()
    {
        Charter175UI(174);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements174()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter175UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[174].AllAnim();
        }
    }
    //175A
    public void AButtonC175()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[173].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC175", 1.1f);
            Invoke("AInvokerAchievements174", 2.2f);
        }
    }
    private void AInvokerC175()
    {
        ACharter175UI(174);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements174()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter175UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[174].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //176
    public void ButtonC176()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC176", 0.5f);
            Invoke("InvokerAchievements175", 6.5f);
        }
    }
    public void InvokerC176()
    {
        Charter176UI(175);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements175()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter176UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[175].AllAnim();
        }
    }

    //177
    public void ButtonC177()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            anim.Play("BlackoutDarkAnimation");
            Invoke("InvokerC177", 0.5f);
            Invoke("InvokerAchievements176", 6.5f);
        }
    }
    public void InvokerC177()
    {
        Charter177UI(176);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements176()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter177UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[176].AllAnim();
        }
    }
    //177A
    public void AButtonC177()
    {
        if (gameManager.b_the_end == 18)
        {
            ButtonC180();
        }
        else if (gameManager.b_the_end < 18)
        {
            imgBlackout.gameObject.SetActive(true);
            animContent[173].AllAnim1();
            animContent[174].AllAnim1();
            animContentPanel.AllAnimP();
            Invoke("AInvokerC177", 1.1f);
            Invoke("AInvokerAchievements176", 2.2f);
        }
    }
    private void AInvokerC177()
    {
        ACharter177UI(176);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements176()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    private void ACharter177UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[176].AllAnim2();
        animContentPanel.AllAnimP();
    }

    //178
    public void ButtonC178()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC178", 0.5f);
        Invoke("InvokerAchievements177", 6.5f);
    }
    public void InvokerC178()
    {
        Charter178UI(177);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements177()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter178UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[177].AllAnim();
        }
        sound.PlaySound(19);
    }

    //179
    public void ButtonC179()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC179", 0.5f);
        Invoke("InvokerAchievements178", 6.5f);
    }
    public void InvokerC179()
    {
        Charter179UI(178);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements178()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter179UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[178].AllAnim();
        }
        sound.PlaySound(20);
    }

    //180 LOGIC
    public void ButtonC180()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC180", 0.5f);
        Invoke("InvokerAchievements179", 6.5f);
    }
    public void InvokerC180()
    {
        Charter180UI(179);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements179()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter180UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[179].AllAnim();
        }
        sound.PlaySound(20);
    }

    //181
    public void ButtonC181()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC181", 0.5f);
        Invoke("InvokerAchievements180", 6.5f);
    }
    public void InvokerC181()
    {
        Charter181UI(180);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements180()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements15();
    }
    public void Charter181UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        gameManager.numberMusic = 4;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[180].AllAnim();
        }
        musicCharter.PlayMusic(gameManager.numberMusic);
    }
    //181A
    public void AButtonC181()
    {
        imgBlackout.gameObject.SetActive(true);
        animContent[172].AllAnim1();
        animContent[177].AllAnim1();
        animContentPanel.AllAnimP();
        Invoke("AInvokerC181", 1.1f);
        Invoke("AInvokerAchievements180", 2.2f);
    }
    private void AInvokerC181()
    {
        ACharter181UI(180);
        gameManager.SavePlayer();
    }
    private void AInvokerAchievements180()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements15();
    }
    private void ACharter181UI(int index)
    {
        toBeContinued.text = "Chapter 3";
        gameManager.numberMusic = 4;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        animContent[180].AllAnim2();
        animContentPanel.AllAnimP();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //182
    public void ButtonC182()
    {

        FireBaseAnalyticsEvents.EventsWinGame("WinGame");
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC182", 0.5f);
        Invoke("InvokerAchievements181", 6.5f);
    }
    public void InvokerC182()
    {
        Charter182UI(181);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements181()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter182UI(int index)
    {
        toBeContinued.text = "To be continued...";
        gameManager.numberMusic = 2;
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[181].AllAnim();
        }
        animStar.StarAnim();
        musicCharter.PlayMusic(gameManager.numberMusic);
    }

    //Лагерь
    public void CampCharter13UI(int index)
    {
        sound.StopSound();
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        panel.gameObject.SetActive(false);
        saveAndLoad.continueGame = 0;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        musicCharter.StopMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    //Кнопка МЕНЮ на панели
    public void MenuCharterPanel(int index)
    {

        //sound.StopSound();

        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }

        toBeContinued.text = "Chapter 1";


        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        panel.gameObject.SetActive(false);
        musicCharter.StopMusic();
        activeMenu.BackMenu();
    }

    //Оценить
    public void RateUs()
    {
        rateUs.gameObject.SetActive(true);
    }
    public void RateUsClose()
    {
        rateUs.gameObject.SetActive(false);
        Star5();
    }
    public void RateUsNot()
    {
        rateUs.gameObject.SetActive(false);
        rateUsNot.gameObject.SetActive(true);
    }
    public void RateUsNotClose()
    {
        rateUsNot.gameObject.SetActive(false);
    }
    public void Star1()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starNo;
        star3.image.sprite = starNo;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star2()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starNo;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star3()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star4()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starYes;
        star5.image.sprite = starNo;
    }
    public void Star5()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starYes;
        star5.image.sprite = starYes;
    }
}
