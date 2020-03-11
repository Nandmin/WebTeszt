using Microsoft.Office.InfoPath;
using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using mshtml;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows;
using System.Net.NetworkInformation;
using System.IO;
//using System.Threading;

namespace WebTester
{

    public partial class FormCode
    {
       
        public int v = 1;
        public int szamlalo = 1;
        public string kerdes;
        

        public void InternalStartup()
        {
            EventManager.XmlEvents["/my:sajátMezők/my:Alapadatok/my:Kerdesek_szama"].Changed += new XmlChangedEventHandler(Kerdesek_szama_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_1/my:mező6"].Changed += new XmlChangedEventHandler(mező6_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_2/my:mező6_1"].Changed += new XmlChangedEventHandler(mező6_1_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_3/my:mező6_2"].Changed += new XmlChangedEventHandler(mező6_2_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_4/my:mező6_3"].Changed += new XmlChangedEventHandler(mező6_3_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_5/my:mező6_4"].Changed += new XmlChangedEventHandler(mező6_4_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_6/my:mező6_5"].Changed += new XmlChangedEventHandler(mező6_5_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_7/my:mező6_6"].Changed += new XmlChangedEventHandler(mező6_6_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_8/my:mező6_7"].Changed += new XmlChangedEventHandler(mező6_7_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_9/my:mező6_8"].Changed += new XmlChangedEventHandler(mező6_8_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_10/my:mező6_9"].Changed += new XmlChangedEventHandler(mező6_9_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_11/my:mező6_10"].Changed += new XmlChangedEventHandler(mező6_10_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_12/my:mező6_11"].Changed += new XmlChangedEventHandler(mező6_11_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_13/my:mező6_12"].Changed += new XmlChangedEventHandler(mező6_12_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_14/my:mező6_13"].Changed += new XmlChangedEventHandler(mező6_13_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_15/my:mező6_14"].Changed += new XmlChangedEventHandler(mező6_14_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_16/my:mező6_15"].Changed += new XmlChangedEventHandler(mező6_15_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_17/my:mező6_16"].Changed += new XmlChangedEventHandler(mező6_16_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_18/my:mező6_17"].Changed += new XmlChangedEventHandler(mező6_17_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_19/my:mező6_18"].Changed += new XmlChangedEventHandler(mező6_18_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_20/my:mező6_19"].Changed += new XmlChangedEventHandler(mező6_19_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_21/my:mező6_20"].Changed += new XmlChangedEventHandler(mező6_20_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_22/my:mező6_21"].Changed += new XmlChangedEventHandler(mező6_21_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_23/my:mező6_22"].Changed += new XmlChangedEventHandler(mező6_22_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_24/my:mező6_23"].Changed += new XmlChangedEventHandler(mező6_23_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_25/my:mező6_24"].Changed += new XmlChangedEventHandler(mező6_24_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_26/my:mező6_25"].Changed += new XmlChangedEventHandler(mező6_25_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_27/my:mező6_26"].Changed += new XmlChangedEventHandler(mező6_26_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_28/my:mező6_27"].Changed += new XmlChangedEventHandler(mező6_27_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_29/my:mező6_28"].Changed += new XmlChangedEventHandler(mező6_28_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_30/my:mező6_29"].Changed += new XmlChangedEventHandler(mező6_29_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_31/my:mező6_30"].Changed += new XmlChangedEventHandler(mező6_30_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_32/my:mező6_31"].Changed += new XmlChangedEventHandler(mező6_31_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_33/my:mező6_32"].Changed += new XmlChangedEventHandler(mező6_32_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_34/my:mező6_33"].Changed += new XmlChangedEventHandler(mező6_33_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_35/my:mező6_34"].Changed += new XmlChangedEventHandler(mező6_34_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_36/my:mező6_35"].Changed += new XmlChangedEventHandler(mező6_35_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_37/my:mező6_36"].Changed += new XmlChangedEventHandler(mező6_36_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_38/my:mező6_37"].Changed += new XmlChangedEventHandler(mező6_37_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_39/my:mező6_38"].Changed += new XmlChangedEventHandler(mező6_38_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_40/my:mező6_39"].Changed += new XmlChangedEventHandler(mező6_39_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_41/my:mező6_40"].Changed += new XmlChangedEventHandler(mező6_40_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_42/my:mező6_41"].Changed += new XmlChangedEventHandler(mező6_41_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_43/my:mező6_42"].Changed += new XmlChangedEventHandler(mező6_42_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_44/my:mező6_43"].Changed += new XmlChangedEventHandler(mező6_43_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_45/my:mező6_44"].Changed += new XmlChangedEventHandler(mező6_44_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_46/my:mező6_45"].Changed += new XmlChangedEventHandler(mező6_45_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_47/my:mező6_46"].Changed += new XmlChangedEventHandler(mező6_46_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_48/my:mező6_47"].Changed += new XmlChangedEventHandler(mező6_47_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_49/my:mező6_48"].Changed += new XmlChangedEventHandler(mező6_48_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_50/my:mező6_49"].Changed += new XmlChangedEventHandler(mező6_49_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_51/my:mező6_50"].Changed += new XmlChangedEventHandler(mező6_50_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_52/my:mező6_51"].Changed += new XmlChangedEventHandler(mező6_51_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_53/my:mező6_52"].Changed += new XmlChangedEventHandler(mező6_52_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_54/my:mező6_53"].Changed += new XmlChangedEventHandler(mező6_53_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_55/my:mező6_54"].Changed += new XmlChangedEventHandler(mező6_54_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_56/my:mező6_55"].Changed += new XmlChangedEventHandler(mező6_55_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_57/my:mező6_56"].Changed += new XmlChangedEventHandler(mező6_56_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_58/my:mező6_57"].Changed += new XmlChangedEventHandler(mező6_57_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_59/my:mező6_58"].Changed += new XmlChangedEventHandler(mező6_58_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_60/my:mező6_59"].Changed += new XmlChangedEventHandler(mező6_59_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_61/my:mező6_60"].Changed += new XmlChangedEventHandler(mező6_60_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_62/my:mező6_61"].Changed += new XmlChangedEventHandler(mező6_61_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_63/my:mező6_62"].Changed += new XmlChangedEventHandler(mező6_62_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_64/my:mező6_63"].Changed += new XmlChangedEventHandler(mező6_63_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_65/my:mező6_64"].Changed += new XmlChangedEventHandler(mező6_64_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_66/my:mező6_65"].Changed += new XmlChangedEventHandler(mező6_65_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_67/my:mező6_66"].Changed += new XmlChangedEventHandler(mező6_66_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_68/my:mező6_67"].Changed += new XmlChangedEventHandler(mező6_67_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_69/my:mező6_68"].Changed += new XmlChangedEventHandler(mező6_68_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Feladatlap/my:sajátMezők_70/my:mező6_69"].Changed += new XmlChangedEventHandler(mező6_69_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Alapadatok/my:Logba_Esemeny"].Changed += new XmlChangedEventHandler(Logba_Esemeny_Changed);
            ((ButtonEvent)EventManager.ControlEvents["CTRL777_10"]).Clicked += new ClickedEventHandler(CTRL777_10_Clicked);
            ((ButtonEvent)EventManager.ControlEvents["CTRL5_16"]).Clicked += new ClickedEventHandler(CTRL5_16_Clicked);
            ((ButtonEvent)EventManager.ControlEvents["CTRL6_16"]).Clicked += new ClickedEventHandler(CTRL6_16_Clicked);
            EventManager.XmlEvents["/my:sajátMezők/my:Eredmenyek/my:Lezarva"].Changed += new XmlChangedEventHandler(Lezarva_Changed);
            ((ButtonEvent)EventManager.ControlEvents["CTRL1_5"]).Clicked += new ClickedEventHandler(CTRL1_5_Clicked);
            EventManager.XmlEvents["/my:sajátMezők/my:Alapadatok/my:Chk_start"].Changed += new XmlChangedEventHandler(Chk_start_Changed);
            EventManager.XmlEvents["/my:sajátMezők/my:Alapadatok/my:Mentett_db"].Changed += new XmlChangedEventHandler(Mentett_db_Changed);
            EventManager.FormEvents.Loading += new LoadingEventHandler(FormEvents_Loading);

            EventManager.XmlEvents["/my:sajátMezők/my:Eredmenyek/my:Check"].Changed += new XmlChangedEventHandler(Check_Changed);
            ((ButtonEvent)EventManager.ControlEvents["btn_csv_export"]).Clicked += new ClickedEventHandler(btn_csv_export_Clicked);
        }


        public void Kerdesek_szama_Changed(object sender, XmlEventArgs e)
        {
            string kerdesLista = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Kerdes_lista", NamespaceManager).Value;
            List<int> számok = new List<int>();
            string maxNum = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Kerdesek_szama", NamespaceManager).Value; //tabla.Count;  A legngyobb kérdés sorszáma a tesztlapon, ez lehet a legnagyobb véletlen szám is
            string sorok = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Megjelenitendo_kerdesek_szama", NamespaceManager).Value; //tabla.Count;
            int i = 0;
            int j;

            int[] adatok = new int[Convert.ToInt32(sorok.ToString())];
            while (i < Convert.ToInt32(sorok.ToString()))
            {
                j = 0;
                int k = i + 1;
                Random Veletlen;
                Veletlen = new Random();
                int sorszam = Veletlen.Next(1, (Convert.ToInt32(maxNum.ToString())) + 1);

                while (sorszam != adatok[j] && j < i)
                {
                    ++j;
                }

                if (j < i)
                {

                }
                else
                {
                    adatok[i] = sorszam;
                    XPathNavigator kerdes = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager);
                    kerdes.SetValue(sorszam.ToString());
                    string kerdesErtek = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value;
                    kerdesLista = kerdesLista + "," + kerdesErtek.Substring(0, kerdesErtek.LastIndexOf('.'));
                    ++i;
                }
            }
            
            if (kerdesLista.Substring(0, 1) == ",") //Kérdéslista összeállítása és mezőbe kiírása
                {
                    kerdesLista = kerdesLista.Remove(0, 1);
                    MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Kerdes_lista", NamespaceManager).SetValue(kerdesLista.ToString());
                }
                else
                {
                    MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Kerdes_lista", NamespaceManager).SetValue(kerdesLista.ToString());
                }
        }

        public void eredmeny(object sender, XmlEventArgs e)
        {
            string eredmeny = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Eredmenyek/my:Eredmeny", NamespaceManager).Value;
            string helyes = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Eredmenyek/my:Helyes_valasz", NamespaceManager).Value;
            string helytelen = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Eredmenyek/my:Helytelen_valasz", NamespaceManager).Value;

            MessageBox.Show("Elért eredmény: \t\t" + eredmeny.ToString() + "\n\n" + "Helyes válaszok száma:\t\t " + helyes.ToString() + "\n\n" + "Hibás válaszok száma:\t\t " + helytelen.ToString(), "A teszt eredménye: ");
        }

        public void mező6_Changed(object sender, XmlEventArgs e)
        {

            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K1", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_1/my:mező6", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_1/my:mező7", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }



            //valaszadas(sender, e);
        }

        public void mező6_1_Changed(object sender, XmlEventArgs e)
        {
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K2", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_2/my:mező6_1", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_2/my:mező7_1", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_2_Changed(object sender, XmlEventArgs e)
        {
            int k = 3;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_3_Changed(object sender, XmlEventArgs e)
        {
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K4", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_4/my:mező6_3", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_4/my:mező7_3", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_4_Changed(object sender, XmlEventArgs e)
        {
            int k = 5;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_5_Changed(object sender, XmlEventArgs e)
        {
            int k = 6;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_6_Changed(object sender, XmlEventArgs e)
        {
            int k = 7;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_7_Changed(object sender, XmlEventArgs e)
        {
            int k = 8;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_8_Changed(object sender, XmlEventArgs e)
        {
            int k = 9;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_9_Changed(object sender, XmlEventArgs e)
        {
            int k = 10;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_10_Changed(object sender, XmlEventArgs e)
        {
            int k = 11;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_11_Changed(object sender, XmlEventArgs e)
        {
            int k = 12;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_12_Changed(object sender, XmlEventArgs e)
        {
            int k = 13;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_13_Changed(object sender, XmlEventArgs e)
        {
            int k = 14;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_14_Changed(object sender, XmlEventArgs e)
        {
            int k = 15;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_15_Changed(object sender, XmlEventArgs e)
        {
            int k = 16;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_16_Changed(object sender, XmlEventArgs e)
        {
            int k = 17;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_17_Changed(object sender, XmlEventArgs e)
        {
            int k = 18;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_18_Changed(object sender, XmlEventArgs e)
        {
            int k = 19;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_19_Changed(object sender, XmlEventArgs e)
        {
            int k = 20;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_20_Changed(object sender, XmlEventArgs e)
        {
            int k = 21;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_21_Changed(object sender, XmlEventArgs e)
        {
            int k = 22;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_22_Changed(object sender, XmlEventArgs e)
        {
            int k = 23;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_23_Changed(object sender, XmlEventArgs e)
        {
            int k = 24;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_24_Changed(object sender, XmlEventArgs e)
        {
            int k = 25;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_25_Changed(object sender, XmlEventArgs e)
        {
            int k = 26;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_26_Changed(object sender, XmlEventArgs e)
        {
            int k = 27;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_27_Changed(object sender, XmlEventArgs e)
        {
            int k = 28;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_28_Changed(object sender, XmlEventArgs e)
        {
            int k = 29;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_29_Changed(object sender, XmlEventArgs e)
        {
            int k = 30;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_30_Changed(object sender, XmlEventArgs e)
        {
            int k = 31;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_31_Changed(object sender, XmlEventArgs e)
        {
            int k = 32;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_32_Changed(object sender, XmlEventArgs e)
        {
            int k = 33;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_33_Changed(object sender, XmlEventArgs e)
        {
            int k = 34;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_34_Changed(object sender, XmlEventArgs e)
        {
            int k = 35;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_35_Changed(object sender, XmlEventArgs e)
        {
            int k = 36;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_36_Changed(object sender, XmlEventArgs e)
        {
            int k = 37;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_37_Changed(object sender, XmlEventArgs e)
        {
            int k = 38;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_38_Changed(object sender, XmlEventArgs e)
        {
            int k = 39;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_39_Changed(object sender, XmlEventArgs e)
        {
            int k = 40;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_40_Changed(object sender, XmlEventArgs e)
        {
            int k = 41;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_41_Changed(object sender, XmlEventArgs e)
        {
            int k = 42;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_42_Changed(object sender, XmlEventArgs e)
        {
            int k = 43;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_43_Changed(object sender, XmlEventArgs e)
        {
            int k = 44;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_44_Changed(object sender, XmlEventArgs e)
        {
            int k = 45;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_45_Changed(object sender, XmlEventArgs e)
        {
            int k = 46;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_46_Changed(object sender, XmlEventArgs e)
        {
            int k = 47;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_47_Changed(object sender, XmlEventArgs e)
        {
            int k = 48;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_48_Changed(object sender, XmlEventArgs e)
        {
            int k = 49;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_49_Changed(object sender, XmlEventArgs e)
        {
            int k = 50;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_50_Changed(object sender, XmlEventArgs e)
        {
            int k = 51;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_51_Changed(object sender, XmlEventArgs e)
        {
            int k = 52;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_52_Changed(object sender, XmlEventArgs e)
        {
            int k = 53;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_53_Changed(object sender, XmlEventArgs e)
        {
            int k = 54;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_54_Changed(object sender, XmlEventArgs e)
        {
            int k = 55;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_55_Changed(object sender, XmlEventArgs e)
        {
            int k = 56;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_56_Changed(object sender, XmlEventArgs e)
        {
            int k = 57;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_57_Changed(object sender, XmlEventArgs e)
        {
            int k = 58;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_58_Changed(object sender, XmlEventArgs e)
        {
            int k = 59;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_59_Changed(object sender, XmlEventArgs e)
        {
            int k = 60;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_60_Changed(object sender, XmlEventArgs e)
        {
            int k = 61;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_61_Changed(object sender, XmlEventArgs e)
        {
            int k = 62;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_62_Changed(object sender, XmlEventArgs e)
        {
            int k = 63;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_63_Changed(object sender, XmlEventArgs e)
        {
            int k = 64;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_64_Changed(object sender, XmlEventArgs e)
        {
            int k = 65;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_65_Changed(object sender, XmlEventArgs e)
        {
            int k = 66;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_66_Changed(object sender, XmlEventArgs e)
        {
            int k = 67;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_67_Changed(object sender, XmlEventArgs e)
        {
            int k = 68;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_68_Changed(object sender, XmlEventArgs e)
        {
            int k = 69;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }

        public void mező6_69_Changed(object sender, XmlEventArgs e)
        {
            int k = 70;
            int j = k - 1;
            string ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + k + "", NamespaceManager).Value; //kérdés sorszáma
            int ID1 = ID.LastIndexOf("."); // tizedesjegy elől kiveszi a számot
            string tipp = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező6_" + j + "", NamespaceManager).Value; //user válasza
            string helyesValasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_" + k + "/my:mező7_" + j + "", NamespaceManager).Value; // helyes válasz
            int i = Convert.ToInt32(ID.Substring(0, ID1)) - v;
            XPathNavigator valasz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Valaszok/my:Valasz_" + i + "", NamespaceManager);

            if (tipp.ToString() == helyesValasz.ToString())
            {
                valasz.SetValue("1");
            }
            else
            {
                valasz.SetValue("0");
            }
        }


        public void Logba_Esemeny_Changed(object sender, XmlEventArgs e) // -------- Események LOG-ba bejegyzése --------- \\
        {
            XPathNavigator Log = this.MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Logba_Esemeny", NamespaceManager);
            XPathNavigator User = this.MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Nev", NamespaceManager);
            XPathNavigator domNav = MainDataSource.CreateNavigator();
            XPathNavigator itemNav = domNav.SelectSingleNode("/my:sajátMezők/my:Log/my:LogData/my:Log_Date[1]", NamespaceManager);

            // Sortörlés
            if (itemNav == null)
                itemNav.DeleteSelf();

            string myNamespace = NamespaceManager.LookupNamespace("my");
            using (XmlWriter writer = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log", NamespaceManager).AppendChild())
            {
                writer.WriteStartElement("LogData", myNamespace);
                writer.WriteElementString("Log_Date", myNamespace, DateTime.Now.ToString());
                writer.WriteElementString("Log_Name", myNamespace, User.ToString());
                writer.WriteElementString("Log_Esemeny", myNamespace, Log.ToString());
                writer.WriteEndElement();
                writer.Close();
            }
        }

        public void CTRL777_10_Clicked(object sender, ClickedEventArgs e) // --------- Teszt befejezés jelzés írása az Mlog-ba --------- \\
        {
            Taskbar.Show();
        }

        public void CTRL5_16_Clicked(object sender, ClickedEventArgs e) // -------- Mentés helyének és PDF file nevének lekérdezése, beállítása --------- \\
        {
            XPathNavigator xnMain = this.MainDataSource.CreateNavigator();
            XPathNavigator Pdfcel = xnMain.SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:SaveToPC", NamespaceManager); // FONTOS!!! NEM KIHAGYNI!! Ez határozza meg a mentés helyét!!
            string fileName;
            XPathNavigator nameNode;

            nameNode = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:FileName", NamespaceManager);
            fileName = nameNode.Value + ".pdf";

            string path = @Pdfcel.ToString();
            try
            {
                System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(path);
            }
            catch (Exception c)
            {
                MessageBox.Show("A mentési folyamat megszakadt: {0}", c.ToString());
            }
            
            this.CurrentView.Export(Pdfcel.ToString() + fileName, ExportFormat.Pdf);

        }

        public void CTRL6_16_Clicked(object sender, ClickedEventArgs e) // -------- Mentés helyének és MHT file nevének lekérdezése, beállítása --------- \\
        {
            XPathNavigator xnMain = this.MainDataSource.CreateNavigator();
            XPathNavigator Pdfcel = xnMain.SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:SaveToPC", NamespaceManager); // FONTOS!!! NEM KIHAGYNI!! Ez határozza meg a mentés helyét!!
            string fileName;
            XPathNavigator nameNode;

            nameNode = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:FileName", NamespaceManager);
            fileName = nameNode.Value + ".mht";

            string path = @Pdfcel.ToString();
            try
            {
                System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(path);
            }
            catch (Exception c)
            {
                MessageBox.Show("A mentési folyamat megszakadt: {0}", c.ToString());
            }

            this.CurrentView.Export(Pdfcel.ToString() + fileName, ExportFormat.Mht);
        }

        public void Lezarva_Changed(object sender, XmlEventArgs e)
        {
        }

        public void CTRL1_5_Clicked(object sender, ClickedEventArgs e)
        {
            Taskbar.Hide(); // TESZT VÉGÉVEL EZT VISSZA KELL ÁLLÍTANI!!!!!
        }

        public void Chk_start_Changed(object sender, EventArgs e) // -------------------------- Mlog adat írása ----------------------------- \\
        {
            XPathNavigator Nev = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Nev", NamespaceManager);
            XPathNavigator Tesztlap = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Tesztlap_típus", NamespaceManager);
            string Statusz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Statusz", NamespaceManager).Value;
            string chk_data = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Chk_start", NamespaceManager).Value;
            string mentett_db = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Mentett_db", NamespaceManager).Value;

            if (chk_data.ToString().Length > 0 || Convert.ToInt32(mentett_db.ToString()) == 1)
            {
                try
                {
                    sitesWebServiceLists.Lists listService = new sitesWebServiceLists.Lists();
                    listService.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    listService.Url = "http://teamweb2/sites/TMEK/adatszolg/_vti_bin/Lists.asmx";
                    System.Xml.XmlNode ndListView = listService.GetListAndView("WebTester_Mlog", "");
                    string strListID = ndListView.ChildNodes[0].Attributes["Name"].Value;
                    string strViewID = ndListView.ChildNodes[1].Attributes["Name"].Value;

                    System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                    System.Xml.XmlElement batchElement = doc.CreateElement("Batch");
                    batchElement.SetAttribute("OnError", "Continue");
                    batchElement.SetAttribute("ListVersion", "1");
                    batchElement.SetAttribute("ViewName", strViewID);

                    batchElement.InnerXml = "<Method ID='4' Cmd='New'>" +
                        "<Field Name='Title'>" + Tesztlap.Value + "</Field>" +
                        "<Field Name='Munkatars_neve'>" + Nev.Value + "</Field>" +
                        "<Field Name='Adat'>" + Statusz.ToString() + "</Field></Method>";

                    try
                    {
                        listService.UpdateListItems(strListID, batchElement);
                    }
                    catch
                    {
                        MessageBox.Show(e.ToString());
                    }
                }

                catch
                {
                    //Taskbar.Show();
                }
            }
        }

        public void Mentett_db_Changed(object sender, XmlEventArgs e)
        {
            string mentett_db = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Mentett_db", NamespaceManager).Value;

            if (Convert.ToInt32(mentett_db.ToString()) == 1)
            {
                try
                {
                    Chk_start_Changed(sender, e); // Adatok Mlogba írása (a mező az "Alapadatok"-ban található
                }
                catch
                {
                }
            }
        }

        public void Check_Changed(object sender, EventArgs e)
        {
            if (szamlalo == 1)
            {
                szamlalo++;
                XPathNavigator mentett_db = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Eredmenyek/my:Check", NamespaceManager);
                mentett_db.SetValue("2");
                net_check(sender, e);
            }
        }

        public void net_check(object sender, EventArgs e) // hálózati kapcsolat ellenőrzése
        {
            //Ping p = new Ping();
            //PingReply r;
            //string s;
            //s = "teamweb2";

            try
            {
                //r = p.Send(s);
                //if (r.Status == IPStatus.Success)
                //{
                    //MessageBox.Show("Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                    //   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n");
                    
                    FileSubmitConnection fc = DataConnections["UpLoad"] as FileSubmitConnection;    // adatok Sharepoint-ba küldéshez deklaráció
                    fc.Execute();                                                                   // adatok Sharepoint-ba küldése
                    MessageBox.Show("Az adatok kiszolgálóra történő mentése sikeresen megtörtént!");
                //}
                //else
                //{
                //    MessageBox.Show("nemjó");
                //    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Cisco\Cisco AnyConnect Secure Mobility Client\vpnui.exe");
                //}
            }

            catch (System.Exception)
            {
                //MessageBox.Show("Nincs hálózat");
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Cisco\Cisco AnyConnect Secure Mobility Client\vpnui.exe");

                DialogResult dialogResult = MessageBox.Show
                ("A mentési folyamat során a WebTester hálózati hibát állapított meg! \n\n A hiba megszüntetése érdekében a VPN kapcsolat megszakítása, majd újkapcsolódás szükséges, " + 
                "ezért az ezt a folyamatot kezelő alkalmazás vezérlőfelülete ezen üzenettel párhuzamosan megjelent a képernyőn!" + 
                "\n Kérem, hogy az kapcsolat bontását/újrakapcsolódást elvégezni szíveskedj! \n\n Ha a kapcsolatot újra létrehoztad, kérem, hogy kattints az \"Igen\" gombra, majd várj a visszaigazoló üzenet megérkezéséig!", "Figyelem - Hálózati kapcsolódási probléma!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.Yes) //ha megcsinálta az újrakapcsolódást, akkor újabb mentés jön
                {
                    XPathNavigator Statusz = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Statusz", NamespaceManager);
                    XPathNavigator mentett_db = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Eredmenyek/my:Check", NamespaceManager);
                    
                    Statusz.SetValue("Befejezés (Hálózati hiba után)");
                    Chk_start_Changed(sender, e);
                    kepmentes();
                    net_check(sender, e);
                }
            }
        }

        private void kepmentes() // Az aktuális képernyőről készít egy mentést és a TW rejtett tárba move-olja. majd törli a létrehozott könyvtárat
        {
            try
            {
                string tesztlapNeve = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Tesztlap_típus", NamespaceManager).Value;
                string userName = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Nev", NamespaceManager).Value;
                string fileName = tesztlapNeve + "_" + userName + ".png";
                string forras = System.IO.Path.Combine(@"C:\WebTester_Temp\", fileName);
                string celmappa = System.IO.Path.Combine(@"\\teamweb2\sites\TMEK\adatszolg\WebTester_TMP\" + tesztlapNeve + "\\", fileName);
                int horizontal = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
                int vertical = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

                Bitmap captureBitmap = new Bitmap(horizontal, vertical, PixelFormat.Format32bppArgb);
                System.Drawing.Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                System.IO.DirectoryInfo mappa = System.IO.Directory.CreateDirectory(@"C:\\WebTester_Temp\\");
                mappa.Attributes = FileAttributes.Directory | FileAttributes.Hidden; // rejtett könyvtár kreálása
                captureBitmap.Save(@"C:\\WebTester_Temp\\" + fileName, ImageFormat.Png);

                try
                {
                    System.IO.DirectoryInfo tw_mappa = System.IO.Directory.CreateDirectory(@"\\teamweb2\sites\TMEK\adatszolg\WebTester_TMP\" + tesztlapNeve + "\\");
                }

                catch
                {
                }

                System.IO.File.Move(forras, celmappa);
                data_export();
                System.IO.Directory.Delete(@"C:\WebTester_Temp\");          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void data_export()   //adatok csv-be mentése a háttérben
        {
            string path = @"C:\WebTester_Temp\"; //folder name
            string tesztlapNeve = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Tesztlap_típus", NamespaceManager).Value;
            string userName = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Nev", NamespaceManager).Value;
            string fileName = tesztlapNeve + "_" + userName + ".csv";
            string forras = System.IO.Path.Combine(@"C:\WebTester_Temp\", fileName);
            string celmappa = System.IO.Path.Combine(@"\\teamweb2\sites\TMEK\adatszolg\WebTester_TMP\" + tesztlapNeve + "\\", fileName);

            //try
            //{

            //    if (Directory.Exists(path))
            //    {
            //        //DirectoryInfo di = Directory.CreateDirectory(path);
            //        if (!File.Exists(path + fileName))
            //        {
            //            XPathNodeIterator reptable = MainDataSource.CreateNavigator().Select("/my:sajátMezők/my:Log/my:LogData/my:Log_Date", NamespaceManager);
            //            int sor = reptable.Count;
                        
            //            int j = 1;
            //            string temp = string.Empty;
            //            string filePath = (path + fileName);
            //            string mezoNev = "Datum" + ";" + "Felhasznalo" + ";" + "Esemeny";
            //            File.AppendAllText(filePath, mezoNev + "\n");
            //            for (j = 2; j <= reptable.Count; j++)
            //            {
            //                string datum = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Date", NamespaceManager).Value;
            //                string felhasznalo = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Name", NamespaceManager).Value;
            //                string esemeny = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Esemeny", NamespaceManager).Value;

            //                string temp_sorszam = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Feladatlap/my:sajátMezők_1/my:mező6", NamespaceManager).Value;
            //                string sorszam = temp_sorszam.Substring(temp_sorszam.LastIndexOf(".")-2, 2);
            //                MessageBox.Show(sorszam, "hossza: " + sorszam.Length.ToString());
            //                //reptable.MoveNext();
            //                string con = datum + ";" + felhasznalo + ";" + esemeny;
            //                File.AppendAllText(filePath, con + "\n");
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //}

            try
            {
                if (Directory.Exists(path))
                {
                    //DirectoryInfo di = Directory.CreateDirectory(path);
                    //if (!File.Exists(path + fileName))
                    //{
                    XPathNodeIterator reptable = MainDataSource.CreateNavigator().Select("/my:sajátMezők/my:Log/my:LogData/my:Log_Date", NamespaceManager);
                    int sor = reptable.Count;

                    int j = 1;
                    string temp = string.Empty;
                    string filePath = (path + fileName);
                    string mezoNev = "Datum" + ";" + "Felhasznalo" + ";" + "Esemeny" + ";" + "Chk_sum";
                    File.AppendAllText(filePath, mezoNev + "\n");
                    for (j = 2; j <= reptable.Count; j++)
                    {
                        string datum = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Date", NamespaceManager).Value;
                        string felhasznalo = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Name", NamespaceManager).Value;
                        string esemeny = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Esemeny", NamespaceManager).Value;
                        string temp_sorszam = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Esemeny", NamespaceManager).Value;

                        if (temp_sorszam.Contains("."))
                        {
                            string sorszam = temp_sorszam.Substring(temp_sorszam.LastIndexOf(".") - 2, 2);
                            if (sorszam.Length > 1)
                            {
                                sorszam = sorszam.Replace(" ", "");
                            }
                            kerdes = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + sorszam, NamespaceManager).Value;
                        }

                        string con = datum + ";" + felhasznalo + ";" + esemeny + ";" + kerdes;
                        File.AppendAllText(filePath, con + "\n");
                    }
                    //}
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    data_export();
                }
            }
            catch
            {
            }

            System.IO.File.Move(forras, celmappa);
        }

        public void btn_csv_export_Clicked(object sender, ClickedEventArgs e)
        {
            string path = @"C:\WebTester_Temp\"; //folder name
            string tesztlapNeve = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Tesztlap_típus", NamespaceManager).Value;
            string userName = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Nev", NamespaceManager).Value;
            string fileName = tesztlapNeve + "_" + userName + ".csv";
            string forras = System.IO.Path.Combine(@"C:\WebTester_Temp\", fileName);
            string celmappa = System.IO.Path.Combine(@"\\teamweb2\sites\TMEK\adatszolg\WebTester_TMP\" + tesztlapNeve + "\\", fileName);
            
            try
            {
                if (Directory.Exists(path))
                {
                    //DirectoryInfo di = Directory.CreateDirectory(path);
                    //if (!File.Exists(path + fileName))
                    //{
                    XPathNodeIterator reptable = MainDataSource.CreateNavigator().Select("/my:sajátMezők/my:Log/my:LogData/my:Log_Date", NamespaceManager);
                    int sor = reptable.Count;

                    int j = 1;
                    string temp = string.Empty;
                    string filePath = (path + fileName);
                    string mezoNev = "Datum" + ";" + "Felhasznalo" + ";" + "Esemeny" + ";" + "Chk_sum";
                    File.AppendAllText(filePath, mezoNev + "\n");
                    for (j = 2; j <= reptable.Count; j++)
                    {
                        string datum = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Date", NamespaceManager).Value;
                        string felhasznalo = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Name", NamespaceManager).Value;
                        string esemeny = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Esemeny", NamespaceManager).Value;
                        string temp_sorszam = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Log/my:LogData[" + j + "]/my:Log_Esemeny", NamespaceManager).Value;

                        if (temp_sorszam.Contains("."))
                        {
                            string sorszam = temp_sorszam.Substring(temp_sorszam.LastIndexOf(".") - 2, 2);
                            if (sorszam.Length > 1)
                            {
                                sorszam = sorszam.Replace(" ", "");
                            }
                            
                            kerdes = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Random/my:K" + sorszam, NamespaceManager).Value;
                        }
                        string con = datum + ";" + felhasznalo + ";" + esemeny + ";" + kerdes;
                        File.AppendAllText(filePath, con + "\n");
                    }
                    //}
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    btn_csv_export_Clicked(sender, e);
                }
            }
            catch
            {
            }
        }

        public void FormEvents_Loading(object sender, LoadingEventArgs e)
        {
            string forras = @"C:\WebTester_Temp\";
            string celmappa = @"\\teamweb2\sites\TMEK\adatszolg\WebTester_TMP\";
            XPathNavigator PC_ID = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:Inform_ID", NamespaceManager);

            PC_ID.SetValue(System.Environment.MachineName);

            if (System.IO.Directory.Exists(forras)) //Ha talál a C-n mappát, akkor annak tartalmát a TW tárhelyre mozgatja a háttérben
            {
                try
                {
                    foreach (string srcPath in System.IO.Directory.GetFiles(forras))
                    {
                        System.IO.File.Move(srcPath, srcPath.Replace(forras, celmappa));//, true);
                    }
                    System.IO.Directory.Delete(@"C:\WebTester_Temp\");
                }
                catch
                {
                }
            }
            
            KeyboardHook(this, e);

            if (System.Environment.OSVersion.ToString().Contains("6.1")) //Ellenőrzi, hogy Win10 vagy Win7, majd beállítja a mentés helyét 6.1 --> Win7, 6.2 --> Win10
            {
            }
            else
            {
                XPathNavigator Drive = MainDataSource.CreateNavigator().SelectSingleNode("/my:sajátMezők/my:Alapadatok/my:SaveToPC", NamespaceManager);

                try
                {
                    System.IO.DirectoryInfo mappa = System.IO.Directory.CreateDirectory(Drive.ToString());
                }
                catch
                {
                }
                Drive.SetValue("C:\\Adatszolgáltatás\\WebTester\\");
            }
        }

        private delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi)]
        private static extern int SetWindowsHookEx
            (
           int idHook,
           LowLevelKeyboardProcDelegate lpfn,
           int hMod,
           int dwThreadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(int hHook);

        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Ansi)]
        private static extern int CallNextHookEx(
            int hHook, int nCode,
            int wParam, ref KBDLLHOOKSTRUCT lParam);

        const int WH_KEYBOARD_LL = 13;
        private int intLLKey;
        private KBDLLHOOKSTRUCT lParam;

        private struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        private int LowLevelKeyboardProc(
            int nCode, int wParam, 
            ref KBDLLHOOKSTRUCT lParam)
        {
            bool blnEat = false;
            switch (wParam)
            {
                case 256:
                case 257:
                case 260:
                case 261:
                    //Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key
                    if (((lParam.vkCode == 9) && (lParam.flags == 32)) ||
                        ((lParam.vkCode == 27) && (lParam.flags == 32)) ||
                        ((lParam.vkCode == 27) && (lParam.flags == 0)) ||
                        ((lParam.vkCode == 91) && (lParam.flags == 1)) ||
                        ((lParam.vkCode == 92) && (lParam.flags == 1)) ||
                        ((true) && (lParam.flags == 32))) //((true) && (lParam.flags == 1)) || 
                    
                    {
                        blnEat = true;
                    }
                    break;
            }

            if (blnEat)
                return 1;
            else return CallNextHookEx(0, nCode, wParam, ref lParam);
        }

        private void KeyboardHook(object sender, EventArgs e)
        {
            intLLKey = SetWindowsHookEx(WH_KEYBOARD_LL, new LowLevelKeyboardProcDelegate(LowLevelKeyboardProc),
                       System.Runtime.InteropServices.Marshal.GetHINSTANCE(
                       System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
        }

        private void ReleaseKeyboardHook()
        {
            intLLKey = UnhookWindowsHookEx(intLLKey);
        }

        //private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    KeyboardHook(this, e);
        //}




        
    }

    // --------------------------------------------------------- NEW CLASS!!!!! ----------------------------------------------------------------------------------- \\

    public class Taskbar // Tálca elrejtése és visszaállítása. Visszaállításkor a vágólap is törlésre kerül
    {
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

        [DllImport("user32.dll")]
        private static extern int GetDesktopWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        protected static int Handle
        {
            get
            {
                return FindWindow("Shell_TrayWnd", "");
            }
        }

        protected static int HandleOfStartButton
        {
            get
            {
                int handleOfDesktop = GetDesktopWindow();
                int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                return handleOfStartButton;
            }
        }

        private Taskbar()
        {

        }

        public static void Show()
        {
            ShowWindow(Handle, SW_SHOW);
            ShowWindow(HandleOfStartButton, SW_SHOW);
            Clipboard.Clear();
        }

        public static void Hide()
        {
            ShowWindow(Handle, SW_HIDE);
            ShowWindow(HandleOfStartButton, SW_HIDE);
            Clipboard.Clear();
        }
    }
}