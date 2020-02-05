using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace SpaseFormISPDn
{
    public delegate void MyDelegateWord(Word._Document oDoc);
    
    public partial class FormDocumentAll : Form
    {
        public FormDocumentAll()
        {
            InitializeComponent();
        }

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void buttonCreateAllDoc_Click(object sender, EventArgs e)
        {
            //*****************ЖУРНАЛЫ*********************************************
            // класс методов сохранения шаблонов 
            ClassMetodDocumentCreate DocCreateClass = new ClassMetodDocumentCreate();

            // сохраняем журнал проверки 1
            MyDelegateWord delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalProverok);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaProverokStolb.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaProverokStolb.doc", delegateTempl);
            
            // сохраняем журнал проверки в табличном виде 2
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalProverokTable);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaProverokTable.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaProverokTable.doc", delegateTempl);
            
            // сохраняем журнал запросов субъектов 3
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalZaprosSubj);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalRegistrZaprosovSubject.dot",
                "\\GotovDoc\\Gurnal\\GurnalRegistrZaprosovSubject.doc", delegateTempl);

            // сохраняем журнал разового пропуска 4
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalRazPropusk);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalRazovogoPropuska.dot",
                "\\GotovDoc\\Gurnal\\GurnalRazovogoPropuska.doc", delegateTempl);

            // сохраняем журнал ключевых носителей 5
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalKeyNositeli);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaKluthevihNositeley.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaKluthevihNositeley.doc", delegateTempl);

            // сохраняем журнал учета криптосредств 6
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalUchetKriptosredstv);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaKriptosredstv.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaKriptosredstv.doc", delegateTempl);

            // сохраняем журнал учета паролей 7
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalUchetPassw);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaParoley.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaParoley.doc", delegateTempl);

            // сохраняем журнал учета средств защиты 8
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalUchetSredstvZashita);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaParoley.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaParoley.doc", delegateTempl);

            // сохраняем журнал учета материальных носителей ПД 9
            delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateGurnalUchetaNositeley);
            DocCreateClass.OpenSaveDocMethod("\\Sabl\\Gurnal\\sGurnalUchetaNositeley.dot",
                "\\GotovDoc\\Gurnal\\GurnalUchetaNositeley.doc", delegateTempl);
            
            ////**********************ПРИКАЗЫ*********************************************************

            //// сохраняем приказ ответственного за безопасность 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazOtvetstvZaBezopasn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazNaznachenieOtvetstvenZaBezopasnost.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazNaznachenieOtvetstvenZaBezopasnost.doc", delegateTempl);

            //// сохраняем приказ ответственного за техническую защиту 2
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazOtvetstvTehZashita);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazNaznachenieOtvetstvenZaTehnZahituKripto.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazNaznachenieOtvetstvenZaTehnZahituKripto.doc", delegateTempl);

            //// сохраняем приказ по мероприятиям по защите 3
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazMeropriyatiePoZashite);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazMeropriyatiPoZashite.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazMeropriyatiPoZashite.doc", delegateTempl);

            //// сохраняем приказ по форме обязательства конфид инфы 4
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazKonfidencObezatelstvo);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikaziObiazatelstvoKonfidencial.dot",
            //    "\\GotovDoc\\Prikaz\\PrikaziObiazatelstvoKonfidencial.doc", delegateTempl);

            //// сохраняем приказ о назначении админа без-ти 5
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazAdminBezopasn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazNaznacheniyaAdminaBezopasnosty.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazNaznacheniyaAdminaBezopasnosty.doc", delegateTempl);

            //// сохраняем приказ Об электронном журнале за обращением к ПД 6
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazElektrGurnZaPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazObElektronnomGurnale.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazObElektronnomGurnale.doc", delegateTempl);

            //// сохраняем приказ о выделении помещений конфиденциальной инфы 7
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazKabinetKonfidenc);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazVidileniePomesheniKonfidencial.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazVidileniePomesheniKonfidencial.doc", delegateTempl);

            //// сохраняем ответственных за обработку 8
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazOtvetZaObrabotku);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazOtvetstvenZaObrabotku.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazOtvetstvenZaObrabotku.doc", delegateTempl);
            
            //// сохраняем приказ о выделении помещений обработки ПД 9
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePrikazKabinetPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Prikaz\\sPrikazVidilenPomesheniObrabotkiPD.dot",
            //    "\\GotovDoc\\Prikaz\\PrikazVidilenPomesheniObrabotkiPD.doc", delegateTempl);



            ////**********************ИНСТРУКЦИИ*********************************************************
            
            //// сохраняем инструкцию пользователей ЛВС 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateInstruktUserLVS);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Instruction\\sInstrukciaPolzovateleyLVS.dot",
            //    "\\GotovDoc\\Instruction\\InstrukciaPolzovateleyLVS.doc", delegateTempl);

            //// сохраняем инструкцию Админа 2
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateInstruktAdminLVS);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Instruction\\sInstrukciyaAdmina.dot",
            //    "\\GotovDoc\\Instruction\\InstrukciyaAdmina.doc", delegateTempl);

            //// сохраняем инструкцию Резервирования ПД 3
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateRezervPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Instruction\\sInstrukciyaRezervirovaniia.dot",
            //    "\\GotovDoc\\Instruction\\InstrukciyaRezervirovaniia.doc", delegateTempl);

            //// сохраняем инструкцию Антивирусной парольной защиты 4
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAntivirPasswd);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Instruction\\sInstruktionAntivirusParol.dot",
            //    "\\GotovDoc\\Instruction\\InstruktionAntivirusParol.doc", delegateTempl);

            ////**********************ПЕРЕЧНИ******************************************************
            //// сохраняем перечень средств защиты 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAntivirPasswd);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Perechni\\sPerechenSredstvZashit.dot",
            //    "\\GotovDoc\\Perechni\\PerechenSredstvZashit.doc", delegateTempl);

            //// сохраняем перечень средств защиты 2
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePerKnfInfo);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Perechni\\sPerechenKonfidencialPDn.dot",
            //    "\\GotovDoc\\Perechni\\PerechenKonfidencialPDn.doc", delegateTempl);

            //// сохраняем перечень автоматизир систем 3
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePerAutoISPDn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Perechni\\sPerechenASystem.dot",
            //    "\\GotovDoc\\Perechni\\PerechenASystem.doc", delegateTempl);

            //// сохраняем перечень лиц допущеных к ПД в Архив и серверную
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePerOtvetstvLica);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Perechni\\sPerehenLicDopushenServeriArhiv.dot",
            //    "\\GotovDoc\\Perechni\\PerehenLicDopushenServeriArhiv.doc", delegateTempl);

            ////*********************ПЛАНЫ******************************************************
            //// сохраняем план внутренних проверок защиты 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePlanProverokZash);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Plan\\sPlanVnutrennikhProverokZachitaPD.dot",
            //    "\\GotovDoc\\Plan\\PlanVnutrennikhProverokZachitaPD.doc", delegateTempl);

            //// сохраняем план мероприятий по защите
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePlanMerZashit);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Plan\\sPlanMeropriyatiPoZashite.dot",
            //    "\\GotovDoc\\Plan\\sPlanMeropriyatiPoZashite.doc", delegateTempl);
            
            ////*********************ТЕХ ЗАЩИТА*****************************************************
            //// сохраняем Акт установки средств защиты 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAktUstanovkiSZ);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sAktUstanovkiSZI.dot",
            //    "\\GotovDoc\\TehZashita\\AktUstanovkiSZI.doc", delegateTempl);

            //// сохраняем заключение возможности эксплуатации СЗ 2
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAktUstanovkiSZ);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sZakluchenieOvozmognostiEkspluatacii.dot",
            //    "\\GotovDoc\\TehZashita\\ZakluchenieOvozmognostiEkspluatacii.doc", delegateTempl);

            //// сохраняем технический паспорт объекта Инф 3
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateTehPaspObject);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sTehnicheskiPasportObjectaInf.dot",
            //    "\\GotovDoc\\TehZashita\\TehnicheskiPasportObjectaInf.doc", delegateTempl);

            //// сохраняем техническое задание ПД 4
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateTehZadaniePD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sTehZadaniePD.dot",
            //    "\\GotovDoc\\TehZashita\\TehZadaniePD.doc", delegateTempl);

            //// сохраняем тех паспорт ИСПДн 5
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateTehPaspISPDn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sTehnicheskiPasportISPDn.dot",
            //    "\\GotovDoc\\TehZashita\\TehnicheskiPasportISPDn.doc", delegateTempl);

            //// сохраняем топология ИСПДн 6
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateTopologiISPDn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sTopologiISPDn.dot",
            //    "\\GotovDoc\\TehZashita\\TopologiISPDn.doc", delegateTempl);

            //// сохраняем контролируемая зона ИСПДн 7
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateKontrolZonaISPDn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sKontrolZona.dot",
            //    "\\GotovDoc\\TehZashita\\KontrolZona.doc", delegateTempl);
            
            //// сохраняем проэкт системы защиты 8
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateProectZashitaPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sProektNaBezopasnostPD.dot",
            //    "\\GotovDoc\\TehZashita\\ProektNaBezopasnostPD.doc", delegateTempl);

            //// сохраняем концепция тех защиты 9
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateKonceptZashitaPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sKoncepciaInfBezopasnosti.dot",
            //    "\\GotovDoc\\TehZashita\\KoncepciaInfBezopasnosti.doc", delegateTempl);
            
            //// сохраняем политика ИБ
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePolitikaIB);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sPolitikaInformBezopasnPD.dot",
            //    "\\GotovDoc\\TehZashita\\PolitikaInformBezopasnPD.doc", delegateTempl);

            //// сохраняем матрица доступа
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateMatricaDostupa);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\TehZashita\\sMatritsaDostupa.dot",
            //    "\\GotovDoc\\TehZashita\\MatritsaDostupa.doc", delegateTempl);

            ////*********************ПОЛОЖЕНИЯ*****************************************************
            //// сохраняем положение о защите ПД 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePolZashita);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sPolozhenieZashchiteKI.dot",
            //    "\\GotovDoc\\Pologenie\\PolozhenieZashchiteKI.doc", delegateTempl);

            //// сохраняем положение организации прав доступа 2
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePolPravaDostupa);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sPologenieOrazgranicheniiPravDostupa.dot",
            //    "\\GotovDoc\\Pologenie\\PologenieOrazgranicheniiPravDostupa.doc", delegateTempl);

            //// сохраняем положение об обработки ПД 3
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplatePolObrabotkaPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sPolozhenieObabotkaPDnObshee.dot",
            //    "\\GotovDoc\\Pologenie\\sPolozhenieObabotkaPDnObshee.doc", delegateTempl);

            //// сохраняем Акт уничтожения ПД 4
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAktUnichtogeniaPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sAktUnichtozheniyaPDn.dot",
            //    "\\GotovDoc\\Pologenie\\AktUnichtozheniyaPDn.doc", delegateTempl);

            //// сохраняем уничтожение из ИСПДн 5
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateUnichtogeniaPDISPDn);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sUdaleniePDizISPDn.dot",
            //    "\\GotovDoc\\Pologenie\\UdaleniePDizISPDn.doc", delegateTempl);

            //// сохраняем порядок резервного копирования 6
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateReservCopyPD);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sPoriadokRezervKopir.dot",
            //    "\\GotovDoc\\Pologenie\\PoriadokRezervKopir.doc", delegateTempl);

            //// сохраняем руководство админа по безопасности ИСПДн 7
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateRukvoAdmina);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sRukovodstvoAdministratoraISPDn.dot",
            //    "\\GotovDoc\\Pologenie\\RukovodstvoAdministratoraISPDn.doc", delegateTempl);

            //// сохраняем руководство пользователей ИСПДн 8
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateRukvoUser);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Pologenie\\sRukovodstvoPolzovatelyaISPDn.dot",
            //    "\\GotovDoc\\Pologenie\\RukovodstvoPolzovatelyaISPDn.doc", delegateTempl);


            ////*********************АУДИТ*****************************************************
            //// сохраняем отчет об аудите 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateAuditOtchet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Audit\\sOtchetPoAuditu.dot",
            //    "\\GotovDoc\\Audit\\OtchetPoAuditu.doc", delegateTempl);

            //// сохраняем рекомендации по минимизации защиты ИСПДн
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateMinZatratZashita);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Audit\\sMinimizationZatratNaZashitu.dot",
            //    "\\GotovDoc\\Audit\\MinimizationZatratNaZashitu.doc", delegateTempl);


            ////*********************МОДЕЛИ****************************************************
            //// сохраняем модель нарушителя 1
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelNarushitel);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelNaruschitel.dot",
            //    "\\GotovDoc\\Modeli\\ModelNaruschitel.doc", delegateTempl);

            //// сохраняем модель АРМ без подключения к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozARMnoNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozARMnoInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozARMnoInet.doc", delegateTempl);
            
            //// сохраняем модель АРМ с подключением к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozARMyesNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozARMyesInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozARMyesInet.doc", delegateTempl);
           
            //// сохраняем модель ЛВС без подключения к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozLVSnosNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozLVSnoInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozLVSnoInet.doc", delegateTempl);

            //// сохраняем модель ЛВС с подключением к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozLVSyesNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozLVSyesInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozLVSyesInet.doc", delegateTempl);

            //// сохраняем модель ЛВС распределенная без подключения к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozLVSRaspredNoNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozRasprednoInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozRasprednoInet.doc", delegateTempl);

            //// сохраняем модель ЛВС распределенная c подключением к И-нет
            //delegateTempl = new MyDelegateWord(DocCreateClass.SetTemplateModelUgrozLVSRaspredYesNet);
            //DocCreateClass.OpenSaveDocMethod("\\Sabl\\Modeli\\sModelUgrozRaspredyesInet.dot",
            //    "\\GotovDoc\\Modeli\\ModelUgrozRaspredyesInet.doc", delegateTempl);

            DocCreateClass.oWord.Quit();
            MessageBox.Show("Все документы созданы");
        }
    }
}
