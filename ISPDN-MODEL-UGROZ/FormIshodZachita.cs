using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaseFormISPDn
{
    partial class FormIshodZachita : Form
    {
        public FormIshodZachita()
        {
            InitializeComponent();
        }


        private void buttonIshodZashita_Click(object sender, EventArgs e)
        {

            // Проверяем все ли чекбоксы параметров исходной защищенности отмечены

            if (RadioButtonTerGosudarstvo.Checked == false && RadioButtonTerGorod.Checked == false && RadioButtonTerKorparation.Checked == false
    && RadioButtonTerLocal.Checked == false && RadioButtonTerRadioButtonTerLocalZdanie.Checked == false)
            {
                MessageBox.Show("Определите параметры по терр размещению ИСПДн");
                goto konec;
            }
            else if (RadioButtonSInetMnogotochie.Checked == false && RadioButtonSInetOdnotochie.Checked == false && RadioButtonSInetOtdelno.Checked == false)
            {
                MessageBox.Show("Определите параметры по наличию соединений с др. Сетями");
                goto konec;
            }
            else if (RadioButtonLegalChtenie.Checked == false && RadioButtonLegalZapis.Checked == false && RadioButtonLegalPeredacha.Checked == false)
            {
                MessageBox.Show("Определите параметры По встроенным(Легальным) операциям с базами ПД");
                goto konec;
            }
            else if (RadioButtonDostupPerechen.Checked == false && RadioButtonDostupVseSotrud.Checked == false && RadioButtonDostupOtkrit.Checked == false)
            {
                MessageBox.Show("Определите параметры По разграничению доступа к ПД");
                goto konec;
            }
            else if (RadioButtonDrugieBDInteger.Checked == false && RadioButtonDrugieOdnaBD.Checked == false)
            {
                MessageBox.Show("Определите параметры По наличию с другими БД  иных ИСПДн");
                goto konec;
            }
            else if (RadioButtonBezlicRegion.Checked == false && RadioButtonBezlicOrganization.Checked == false && RadioButtonBezlicNo.Checked == false)
            {
                MessageBox.Show("Определите параметры По уровню обобщения (обезличивания)");
                goto konec;
            }
            else if (RadioButtonObyemAll.Checked == false && RadioButtonObyemChastPD.Checked == false && RadioButtonObyemNo.Checked == false)
            {
                MessageBox.Show("Определите параметры По объему предостовляемых ПД другими лицами");
                goto konec;
            }
            else
            {
                int ispdnID;
                ispdnID = 0;
                DataTable tableIspdn = iSPDnBDDataSet.Tables["ISPDnOperator"];
                if (tableIspdn.Rows.Count == 0)
                {
                    MessageBox.Show("Нет ИСПДн для определения исходной защищенности");
                    goto konec;
                }
                else
                {
                    foreach (DataRow dataRow in tableIspdn.Rows)
                    {
                        string forName;
                        forName = dataRow["ISPDnOperatorName"].ToString();
                        string forISPDnID;
                        forISPDnID = dataRow["ISPDnOperatorID"].ToString();
                        if (this.comboBoxISPDnIshod.Text == forName) // Если  Имя Поля названиеИС равно имени в Базе
                        {
                            ispdnID = Convert.ToInt32(forISPDnID);
                        }
                    }

                    // для начала очищаем связную таблицу
                    this.mnogieHarakteristikiIshodTableAdapter.DeleteQueryMnogieISPDnIshod(ispdnID);

                    Boolean[,] ModelArray = new Boolean[22, 3];
                    // по территориальному размещению
                    ModelArray[0, 2] = RadioButtonTerGosudarstvo.Checked;   //распределенная ИСПДн, которая охватывает несколько областей, краев, округов или государство в целом;
                    ModelArray[1, 2] = RadioButtonTerGorod.Checked;   //городская ИСПДн, охватывающая не более одного населенного пункта [города, поселка];
                    ModelArray[2, 1] = RadioButtonTerKorparation.Checked;  //корпоративная распределенная ИСПДн, охватывающая многие подразделения одной организации;
                    ModelArray[3, 1] = RadioButtonTerLocal.Checked;  //окальная [кампусная] ИСПДн, развернутая в пределах нескольких близко расположенных зданий;
                    ModelArray[4, 0] = RadioButtonTerRadioButtonTerLocalZdanie.Checked;  //локальная ИСПДн, развернутая в пределах одного здания

                    // по наличию соединений с сетями общего пользования
                    ModelArray[5, 2] = RadioButtonSInetMnogotochie.Checked; //ИСПДн, имеющая многоточечный выход в сеть общего пользования;
                    ModelArray[6, 1] = RadioButtonSInetOdnotochie.Checked;  //ИСПДн, имеющая одноточечный выход в сеть общего пользования;
                    ModelArray[7, 0] = RadioButtonSInetOtdelno.Checked;  //ИСПДн, физически отделенная от сети общего пользования

                    // По легальным операциям
                    ModelArray[8, 0] = RadioButtonLegalChtenie.Checked;  // чтение, поиск;
                    ModelArray[9, 1] = RadioButtonLegalZapis.Checked;  //запись, удаление, сортировка;
                    ModelArray[10, 2] = RadioButtonLegalPeredacha.Checked;  //модификация, передача

                    // По разграничению доступа
                    ModelArray[11, 1] = RadioButtonDostupPerechen.Checked;  //ИСПДн, к которой имеют доступ определенные переченем сотрудники организации, являющейся владельцем ИСПДн, либо субъект ПДн;
                    ModelArray[12, 2] = RadioButtonDostupVseSotrud.Checked;  //ИСПДн, к которой имеют доступ все сотрудники организации, являющейся владельцем ИСПДн;
                    ModelArray[13, 2] = RadioButtonDostupOtkrit.Checked;  //ИСПДн с открытым доступом

                    //По наличию соединения с другими базами ИСПДн
                    ModelArray[14, 2] = RadioButtonDrugieBDInteger.Checked;  //интегрированная ИСПДн [организация использует несколько баз ПДн ИСПДн, при этом организация не является владельцем всех используемых баз ПДн];
                    ModelArray[15, 0] = RadioButtonDrugieOdnaBD.Checked;  //ИСПДн, в которой используется одна база ПДн, принадлежащая организации – владельцу данной ИСПДн


                    //По уровню обобщения [обезличивания] ПДн
                    ModelArray[16, 0] = RadioButtonBezlicRegion.Checked;  //ИСПДн, в которой предоставляемые пользователю данные являются обезличенными [на уровне организации, отрасли, области, региона и т.д.];
                    ModelArray[17, 1] = RadioButtonBezlicOrganization.Checked;  //ИСПДн, в которой данные обезличиваются только при передаче в другие организации и не обезличены при предоставлении пользователю в организации;
                    ModelArray[18, 2] = RadioButtonBezlicNo.Checked;  //ИСПДн, в которой предоставляемые пользователю данные не являются обезличенными [т.е. присутствует информация, позволяющая идентифицировать субъекта ПДн]

                    // по объему ПДн, которые предостовляются другим
                    ModelArray[19, 2] = RadioButtonObyemAll.Checked;  //ИСПДн, предоставляющая всю базу данных с ПДн;
                    ModelArray[20, 1] = RadioButtonObyemChastPD.Checked;  //ИСПДн, предоставляющая часть ПДн;
                    ModelArray[21, 0] = RadioButtonObyemNo.Checked; //ИСПДн, не предоставляющая никакой информации.


                    if (ModelArray[5, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(1, ispdnID);
                    if (ModelArray[1, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(2, ispdnID);
                    if (ModelArray[2, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(3, ispdnID);
                    if (ModelArray[3, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(4, ispdnID);
                    if (ModelArray[4, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(5, ispdnID);

                    if (ModelArray[5, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(6, ispdnID);
                    if (ModelArray[6, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(7, ispdnID);
                    if (ModelArray[7, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(8, ispdnID);

                    if (ModelArray[8, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(9, ispdnID);
                    if (ModelArray[9, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(10, ispdnID);
                    if (ModelArray[10, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(11, ispdnID);

                    if (ModelArray[11, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(12, ispdnID);
                    if (ModelArray[12, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(13, ispdnID);
                    if (ModelArray[13, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(14, ispdnID);

                    if (ModelArray[14, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(15, ispdnID);
                    if (ModelArray[15, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(16, ispdnID);

                    if (ModelArray[16, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(17, ispdnID);
                    if (ModelArray[17, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(18, ispdnID);
                    if (ModelArray[18, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(19, ispdnID);

                    if (ModelArray[19, 2] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(20, ispdnID);
                    if (ModelArray[20, 1] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(21, ispdnID);
                    if (ModelArray[21, 0] == true) mnogieHarakteristikiIshodTableAdapter.InsertHarakteristicISPDnIshod(22, ispdnID);


                    int SumV; // переменная для сбоора количества положительных решений Выс уровень
                    int SumS;//' переменная для сбоора количества положительных решений Средний уровень
                    int SumN; //' переменная для сбоора количества положительных решений Низкий уровень
                    SumV = 0;
                    SumS = 0;
                    SumN = 0;

                    // СЧИТАЕМ ПОЛОЖИТ РЕШЕНИЯ ПО ВЫСОКОМУ УРОВНЮ
                    for (int v = 0; v < ModelArray.GetLength(0); v++)
                    {
                        if (ModelArray[v, 0] == true)
                        {
                            SumV = SumV + 1;

                        }
                    }

                    //СЧИТАЕМ ПОЛОЖИТ РЕШЕНИЯ ПО СРЕДНЕМУ УРОВНЮ
                    for (int s = 0; s < ModelArray.GetLength(0); s++)
                    {
                        if (ModelArray[s, 1] == true)
                        {
                            SumS = SumS + 1;
                        }
                    }

                    // СЧИТАЕМ ПОЛОЖИТ РЕШЕНИЯ ПО НИЗКОМУ УРОВНЮ
                    for (int n = 0; n < ModelArray.GetLength(0); n++)
                    {
                        if (ModelArray[n, 2] == true)
                        {
                            SumN = SumN + 1;
                        }
                    }

                    // КАКОЙ УРОВЕНЬ ЗАЩИЩЕНОСТИ ИМЕЕТ ИСПДН В ИТОГЕ

                    //int koofIshod; // коэфициэнт уровня защищенности         //'  коофициэнты исходной защищенности
                    double VurovenZachit = (7.0 * 70) / 100; //' высчитываем сколько характеристик будет состовлять 70 процентов от общего числа решений
                    // а если к отношение к числу положительных решений а не к орбщему то  VurovenZachit = 6 / 100 * 70 = 4,2 решения

                    //проверка условия на процент положит высокой защиты
                    if ((SumV >= VurovenZachit) && (SumN == 0))
                    {
                        MessageBox.Show("ИСПДН имеет ВЫСОКИЙ уровень исходной защищености");
                        ispDnOperatorTableAdapter.UpdateIshZachita(1, ispdnID, ClassGlobalVar.OrgID);
                    }
                    else if ((((SumV >= VurovenZachit) && (SumN == 0)) == false) && ((SumV +SumS) >= VurovenZachit))
                    {
                        MessageBox.Show("ИСПДН имеет СРЕДНИЙ уровень исходной защищености");
                        ispDnOperatorTableAdapter.UpdateIshZachita(2, ispdnID, ClassGlobalVar.OrgID);
                    }
                    else
                    {
                        MessageBox.Show("ИСПДН имеет НИЗКИЙ уровень исходной защищености");
                        ispDnOperatorTableAdapter.UpdateIshZachita(3, ispdnID, ClassGlobalVar.OrgID);
                    }
                }
            }
            konec: ; // переход от проверки все ли параметры отмечены к выходу из программы
        }


        private void FormIshodZachita_Load(object sender, EventArgs e)
        {
            this.ispDnOperatorTableAdapter.Fill(iSPDnBDDataSet.ISPDnOperator);
        }

        private void FormIshodZachita_Activated(object sender, EventArgs e)
        {
            this.ispDnOperatorTableAdapter.Fill(iSPDnBDDataSet.ISPDnOperator);
        }
    }
}
