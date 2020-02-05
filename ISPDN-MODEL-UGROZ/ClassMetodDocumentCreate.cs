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
    // Класс для работы с вордом
    class ClassMetodDocumentCreate
    {
        public Word._Application oWord = new Word.Application(); // создаем документ Ворд

        public void OpenSaveDocMethod(string pathopen, string pathsave, MyDelegateWord temp)
        {
            // Берем шаблон присваиваем закладкам параметры и сохраняем его
            _Document oDoc = oWord.Documents.Add(Environment.CurrentDirectory + pathopen);
            temp.DynamicInvoke(oDoc);
            oDoc.SaveAs(Environment.CurrentDirectory + pathsave);
            oDoc.Close();
        }


        /*
         *************** ШАБЛОНЧИКИ ДОКУМЕНТОВ******************************************* 
         * 
         */
        //***********************РАЗДЕЛ ЖУРНАЛОВ*******************
       
        // шаблончик журнала проверок 1
        public void SetTemplateGurnalProverok(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала проверок таблица 2
        public void SetTemplateGurnalProverokTable(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала запроса субъектов 3
        public void SetTemplateGurnalZaprosSubj(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала разового пропуска 4
        public void SetTemplateGurnalRazPropusk(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала ключевых носителей 5
        public void SetTemplateGurnalKeyNositeli(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала учета криптосредств 6
        public void SetTemplateGurnalUchetKriptosredstv(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала учета паролей  7
        public void SetTemplateGurnalUchetPassw(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала учета паролей 8
        public void SetTemplateGurnalUchetSredstvZashita(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        // шаблончик журнала учета средств защиты 9
        public void SetTemplateGurnalUchetaNositeley(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ ШАБЛОНОВ ПРИКАЗОВ***************************************

        //шаблончик Приказ назначения ответственного за безопасность 1
        public void SetTemplatePrikazOtvetstvZaBezopasn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ назначения ответственного за безопасность 2
        public void SetTemplatePrikazOtvetstvTehZashita(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ проведении мероприятий по защите мероприятий 3
        public void SetTemplatePrikazMeropriyatiePoZashite(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ по форме обязательства конфиденциальности ПД 4
        public void SetTemplatePrikazKonfidencObezatelstvo(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ назнач админа безопасности 5
        public void SetTemplatePrikazAdminBezopasn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ электронном журнале обращений за ПД 6
        public void SetTemplatePrikazElektrGurnZaPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ о выделении помещений для конфиденциальной инфы 7
        public void SetTemplatePrikazKabinetKonfidenc(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ назначения ответственных за ПД 8
        public void SetTemplatePrikazOtvetZaObrabotku(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик Приказ о выделении помещений для обработки ПД 9
        public void SetTemplatePrikazKabinetPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ ШАБЛОНОВ ИНСТРУКЦИЙ***************************************
        //шаблончик инструкция юзера ЛВС 1
        public void SetTemplateInstruktUserLVS(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик инструкция Админа ЛВС 2
        public void SetTemplateInstruktAdminLVS(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик инструкция резервного копирования 3
        public void SetTemplateRezervPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик инструкция антивирусного и парольного контроля 4
        public void SetTemplateAntivirPasswd(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик инструкция учета носителей ПД 5
        public void SetTemplateUchetNositelei(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ ШАБЛОНОВ ПЕРЕЧНЕЙ***************************************
        //шаблончик перечня средств защиты 1
        public void SetTemplatePerSredstvZashita(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик перечня сведений конфиденциального характера 2
        public void SetTemplatePerKnfInfo(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик перечня ИСПДн 3
        public void SetTemplatePerAutoISPDn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //шаблончик перечня допущеных лиц 4
        public void SetTemplatePerOtvetstvLica(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ ШАБЛОНОВ ПЛАНОВ***************************************
        //шаблончик перечня ИСПДн 1
        public void SetTemplatePlanProverokZash(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик плана мероприяти по защите 2
        public void SetTemplatePlanMerZashit(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ ШАБЛОНОВ по ТЕХ ЗАЩИТЕ***************************************
        
        //шаблончик Акта установки средств защиты 1
        public void SetTemplateAktUstanovkiSZ(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик заключения возможности эксплуатации СЗ 2
        public void SetTemplateZakluthEkspluatacSZ(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик тех паспорта объекта информ-ции 3
        public void SetTemplateTehPaspObject(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик тех задание 4
        public void SetTemplateTehZadaniePD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик тех паспорт ИСПДн 5
        public void SetTemplateTehPaspISPDn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик топология ИСПДн 6
        public void SetTemplateTopologiISPDn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик контролируемая зона ИСПДн 7
        public void SetTemplateKontrolZonaISPDn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик птроэкт защиты ПД 8
        public void SetTemplateProectZashitaPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик концепции защиты ПД 9
        public void SetTemplateKonceptZashitaPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик политика ИБ 10
        public void SetTemplatePolitikaIB(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик матрицы доступа 11
        public void SetTemplateMatricaDostupa(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //***********РАЗДЕЛ ШАБЛОНОВ ПОЛОЖЕНИЙ***************************************

        //шаблончик положение по мероприятиям защиты 1
        public void SetTemplatePolZashita(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик положение права доступа 2
        public void SetTemplatePolPravaDostupa(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик положение обработки ПД 3
        public void SetTemplatePolObrabotkaPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        } 
        //шаблончик Акт уничтожения ПД 4 
        public void SetTemplateAktUnichtogeniaPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик уничтожения ПД из ИСПДн 5
        public void SetTemplateUnichtogeniaPDISPDn(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик порядка резервного копирования 6
        public void SetTemplateReservCopyPD(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик руководства Админа по без-ти ИСПДн
        public void SetTemplateRukvoAdmina(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик руководства пользователей ИСПДн
        public void SetTemplateRukvoUser(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        
        //***********РАЗДЕЛ АУДИТА***************************************

        //шаблончик отчет по аудиту 1
        public void SetTemplateAuditOtchet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик рекомендации по минимизации защиты 2
        public void SetTemplateMinZatratZashita(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ МОДЕЛЕЙ***************************************

        //шаблончик модели нарушителя 1
        public void SetTemplateModelNarushitel(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз АРМ без подключения к И-нет 2
        public void SetTemplateModelUgrozARMnoNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз АРМ с подключением к И-нет 3
        public void SetTemplateModelUgrozARMyesNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз ЛВС без подключения к И-нет 4
        public void SetTemplateModelUgrozLVSnosNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз ЛВС с подключением к И-нет 5
        public void SetTemplateModelUgrozLVSyesNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз ЛВС распределенной без подключения к И-нет 6
        public void SetTemplateModelUgrozLVSRaspredNoNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }
        //шаблончик модели угроз ЛВС распределенной с подключением к И-нет 7
        public void SetTemplateModelUgrozLVSRaspredYesNet(Word._Document oDoc)
        {
            //oDoc.Bookmarks["FioRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
        }

        //***********РАЗДЕЛ КЛАССИФИКАЦИИ ИСПДН***************************************

        // Присвоение шаблону приказа текста в закладки ------------
        public void SetTemplatePrikazKlass(Word._Document oDoc)
        {
            // Добовляем данные в закладки приказа на классификацию ИСПДн
            oDoc.Bookmarks["ISPDnName"].Range.Text = "Название ИСПДН";
            oDoc.Bookmarks["FioRuk1"].Range.Text = ClassMetodOrg.RukFIOMetod();
            oDoc.Bookmarks["FioRuk2"].Range.Text = ClassMetodOrg.RukFIOMetod();
            oDoc.Bookmarks["DolgnRuk1"].Range.Text = ClassMetodOrg.RukDolgnMetod(ClassGlobalVar.OrgID);
            oDoc.Bookmarks["DolgnRuk2"].Range.Text = ClassMetodOrg.RukDolgnMetod(ClassGlobalVar.OrgID);
            oDoc.Bookmarks["FioChlenKomiss"].Range.Text = ClassGlobalVar.KomisKlassIS;
        }
        // Присвоение шаблону акта текста в закладки ------------
        public void SetTemplateAktKlass(Word._Document oDocAktKlass)
        {
            oDocAktKlass.Bookmarks["RukName"].Range.Text = ClassMetodOrg.RukFIOMetod();
            oDocAktKlass.Bookmarks["ISPDnName"].Range.Text = "Название ИСПДН";
            oDocAktKlass.Bookmarks["OrgName"].Range.Text = "Роскомнадзор";
            oDocAktKlass.Bookmarks["AdressOrg"].Range.Text = "Интернациональная 72";
            oDocAktKlass.Bookmarks["PredsedatelKlass"].Range.Text = "Жданов";
            oDocAktKlass.Bookmarks["ChlenKommis"].Range.Text = ClassGlobalVar.KomisKlassIS;
            oDocAktKlass.Bookmarks["ChlenKommis1"].Range.Text = ClassGlobalVar.KomisKlassIS;
            oDocAktKlass.Bookmarks["KategoryPD"].Range.Text = "Специальн";
            oDocAktKlass.Bookmarks["KategoryPDX"].Range.Text = "4";
            oDocAktKlass.Bookmarks["ObiemPD"].Range.Text = "1000";
            oDocAktKlass.Bookmarks["ObiemPDX"].Range.Text = "3";
            oDocAktKlass.Bookmarks["TipIS"].Range.Text = "Типовая";
            oDocAktKlass.Bookmarks["RaspredIS"].Range.Text = "Распределенная";
            oDocAktKlass.Bookmarks["InetIS"].Range.Text = "Поключена к Нету";
            oDocAktKlass.Bookmarks["RegimPD"].Range.Text = "Многопользовательский";
            oDocAktKlass.Bookmarks["RegimPrav"].Range.Text = "Разграниченный";
            oDocAktKlass.Bookmarks["NahogdenieIS"].Range.Text = "Россия";
            oDocAktKlass.Bookmarks["ISPDnNameItog"].Range.Text = "К1";
            oDocAktKlass.Bookmarks["PredsedatelKlass1"].Range.Text = "Петров";

        }

        //***********РАЗДЕЛ УВЕДОМЛЕНИЯ ОБ ОБРАБОТКЕ***************************************

        // шаблон уведомления об обработке ПД
        public void SetTemplateUv(Word._Document oDocUv)
        {
            // Добовляем данные в закладки Уведомления для портала
            oDocUv.Bookmarks["NameOper"].Range.Text = ClassMetodOrg.NameOrgPolnMetod();
            oDocUv.Bookmarks["KratkNameOper"].Range.Text = ClassMetodOrg.NameOrgKratkMetod();
            oDocUv.Bookmarks["AdressOper"].Range.Text = ClassMetodOrg.AdressOrgMetod();
            oDocUv.Bookmarks["RekvisitOper"].Range.Text = ClassMetodOrg.INNOrgMetod();
            oDocUv.Bookmarks["PravoPD"].Range.Text = "нет";
            oDocUv.Bookmarks["CeliPD"].Range.Text = ClassMetodCeli.CeliOrgMetod(ClassGlobalVar.OrgID);
            oDocUv.Bookmarks["KategoryPD"].Range.Text = ClassMetodKategoryPD.KategoryPdAllMetod();
            oDocUv.Bookmarks["SubjectPD"].Range.Text = ClassMetodSubj.SubjAllMetod();
            oDocUv.Bookmarks["JobPD"].Range.Text = "Действий нет";
            oDocUv.Bookmarks["GranicaPD"].Range.Text = "трансграничной нет";
            oDocUv.Bookmarks["MeraOpasnostyPD"].Range.Text = "Мер безопасности нет";
            oDocUv.Bookmarks["OtvetstvZachitaPD"].Range.Text = "Ответственных нет";
            oDocUv.Bookmarks["SvedeniyaOpasnPD"].Range.Text = "Сведений защиты нет";
            oDocUv.Bookmarks["NachaloObrabotkiPD"].Range.Text = "Даты начала обработки нет";
            oDocUv.Bookmarks["KonecObrabotkiPD"].Range.Text = "Конца обработки нет";
        }
        // шаблон письма по статье 22 ч 2
        public void SetTemplate222(Word._Document oDoc222)
        {
           // Добовляем данные в закладки письмо 2-22
            oDoc222.Bookmarks["punktFZlink"].Range.Text = ClassGlobalVar.Punkt222;
            oDoc222.Bookmarks["nameOrg"].Range.Text = ClassMetodOrg.NameOrgKratkMetod();
            oDoc222.Bookmarks["dolgnRuk"].Range.Text = ClassMetodOrg.RukFIOMetod();
            oDoc222.Bookmarks["FIORuk"].Range.Text = ClassMetodOrg.RukDolgnMetod(ClassGlobalVar.OrgID);
            oDoc222.Bookmarks["INNorg"].Range.Text = ClassMetodOrg.INNOrgMetod();
        }

        //***********РАЗДЕЛ СОГЛАСИЯ**************************************
        
        // Присвоение шаблону согласия текста в закладки ------------
        public void SetTemplateSoglasie(Word._Document oDocSoglasie)
        {
            // Добовляем данные в закладки согласия
            oDocSoglasie.Bookmarks["rukdolgn"].Range.Text = ClassMetodOrg.RukDolgnMetod(ClassGlobalVar.OrgID);
            oDocSoglasie.Bookmarks["orgname"].Range.Text = ClassMetodOrg.NameOrgKratkMetod(); ;
            oDocSoglasie.Bookmarks["rukfio"].Range.Text = ClassMetodOrg.RukFIOMetod();
            oDocSoglasie.Bookmarks["orgnazvaniepoln"].Range.Text = ClassMetodOrg.NameOrgPolnMetod();
            oDocSoglasie.Bookmarks["pdobrabotkaceli"].Range.Text = ClassMetodCeli.CeliOrgMetod(ClassGlobalVar.OrgID);
            //oDocSoglasie.Bookmarks["persdanperechen"].Range.Text = "";
            //oDocSoglasie.Bookmarks["pdktoobrabativaet"].Range.Text = "";
            //oDocSoglasie.Bookmarks["persdandeistviya"].Range.Text = "";
        }
//--------------------------------------------------------------------------------
        //     private object internalWord;
        //     private object objCurDoc=null;
        //     private bool FAutoClose = false;
        //     private bool IsSuccesLast = false;
        //     public bool IsSucces
        //     {
        //         get { bool old = IsSuccesLast; IsSuccesLast = false; return old; }
        //     }
        //     public ClassMetodDocumentCreate(bool AutoClose)
        //     {
        //         FAutoClose = AutoClose;
        //         try
        //         {
        //             Type objClassType;
        //             objClassType = Type.GetTypeFromProgID("Word.Application");
        //             internalWord = Activator.CreateInstance(objClassType);
        //             IsSuccesLast = true;
        //         }
        //         catch
        //         {
        //             IsSuccesLast = false;
        //         }
        //     }
        //     ~ClassMetodDocumentCreate()
        //     {
        //         if ((FAutoClose) && (objCurDoc!=null))
        //         {
        //             this.CloseDoc();
        //         }
        //     }
        //     public bool CloseDoc()
        //     {

        //         try
        //         {
        //             //Close Active Document
        //             objCurDoc.GetType().InvokeMember("Close", BindingFlags.InvokeMethod,
        //                 null, objCurDoc, null);
        //             objCurDoc = null;
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }

        //    public bool Quit()
        //     {
        //         try
        //         {
        //             object[] Parameters;
        //             Parameters = new Object[3];
        //             Parameters[0] = 0;
        //             Parameters[1] = 0;
        //             Parameters[2] = false;
        //             internalWord.GetType().InvokeMember("Quit", BindingFlags.SetProperty,
        //                 null, internalWord, Parameters);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool ShowWord(bool is_visible)
        //     {
        //         try
        //         {
        //             object[] Parameters;
        //             Parameters = new Object[1];
        //             Parameters[0] = is_visible;
        //             internalWord.GetType().InvokeMember("Visible", BindingFlags.SetProperty,
        //                 null, internalWord, Parameters);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool OpenFile(string FileName)
        //     {
        //         try
        //         {
        //             object objDocs_Late = internalWord.GetType().InvokeMember(
        //               "Documents", BindingFlags.GetProperty, null, internalWord, null);
        //             object[] Parameters;
        //             Parameters = new Object[1];
        //             Parameters[0] = FileName;
        //             objCurDoc = objDocs_Late.GetType().InvokeMember("Open",
        //                 BindingFlags.InvokeMethod, null, objDocs_Late, Parameters);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool SaveDocument()
        //     {
        //         if (objCurDoc == null) return false;
        //         try
        //         {
        //             objCurDoc.GetType().InvokeMember("Save",
        //             BindingFlags.InvokeMethod, null, objCurDoc, null);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool FindReplace(string findtext, string replacetext)
        //     {
        //         try
        //         {
        //             object[] Parameters;
        //             object objSelection = internalWord.GetType().InvokeMember(
        //               "Selection", BindingFlags.GetProperty, null, internalWord, null);
        //             Parameters = new Object[2];
        //             Parameters[0] = 0;
        //             Parameters[1] = 0;
        //             objSelection.GetType().InvokeMember(
        //               "SetRange", BindingFlags.InvokeMethod, null, objSelection, Parameters);
        //             object objFind = objSelection.GetType().InvokeMember(
        //               "Find", BindingFlags.GetProperty, null, objSelection, null);
        //             Parameters = new Object[11];
        //             Parameters[0] = findtext; //find text
        //             Parameters[1] = false; //match case
        //             Parameters[2] = true; //match whole word
        //             Parameters[3] = false; //match wild card
        //             Parameters[4] = false; //match sounds like
        //             Parameters[5] = false; //match all word forms
        //             Parameters[6] = true; //forward
        //             Parameters[7] = false; //wrap
        //             Parameters[8] = false; //format
        //             Parameters[9] = replacetext; //replace text
        //             Parameters[10] = 2; //replace?
        //             objFind.GetType().InvokeMember("Execute",
        //                 BindingFlags.InvokeMethod, null, objFind, Parameters);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool SaveAs(string filename)
        //     {
        //         if (objCurDoc == null) return false;
        //         object[] Parameters = new Object[1];
        //         Parameters[0] = filename; //find text
        //         try
        //         {
        //             objCurDoc.GetType().InvokeMember("SaveAs",
        //                 BindingFlags.InvokeMethod, null, objCurDoc, Parameters);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool PrintPreview()
        //     {
        //         if (objCurDoc == null) return false;
        //         try
        //         {
        //             objCurDoc.GetType().InvokeMember("PrintPreview",
        //                 BindingFlags.InvokeMethod, null, objCurDoc, null);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        //     public bool Print()
        //     {
        //         if (objCurDoc == null) return false;
        //         try
        //         {
        //             object[] Parameters = new Object[14];
        //             Parameters[0] = false; //in bacground?
        //             Parameters[0] = Missing.Value; //append
        //             Parameters[0] = 0; //all document wdPrintAllDocument
        //             Parameters[0] = Missing.Value; //Output file name
        //             Parameters[0] = Missing.Value; //From
        //             Parameters[0] = Missing.Value; //To page
        //             Parameters[0] = Missing.Value; //Item?
        //             Parameters[0] = 1; //Copies
        //             Parameters[0] = Missing.Value; //Pages
        //             Parameters[0] = Missing.Value; //Page type?
        //             Parameters[0] = false; //print to file
        //             Parameters[0] = false; //collate
        //             Parameters[0] = Missing.Value; //only for MAC
        //             Parameters[0] = Missing.Value; //Manual duplex
        //             Parameters[0] = Missing.Value; //collate
        //             objCurDoc.GetType().InvokeMember("PrintOut",
        //                 BindingFlags.InvokeMethod, null, objCurDoc, null);
        //             return true;
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
    }
}


