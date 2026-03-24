using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm2v
{
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
            trckBar.Value = 3; lblHiz.Text = "Hız: 1.00";
        }

        private void btn_Click(object sender,EventArgs e)
        {
            if(tmrAlarmSesDongu.Enabled)
            {
                tmrAlarmSesDongu.Enabled = false;
                alarmCal.Stop();
                btn.Text = "Zamanlayıcıyı Başlat";
                return;
            }

            if(!tmrSayac.Enabled)
            {
                tmrSayac.Enabled = true;
                btn.Text = "Zamanlayıcıyı Durdur";
                

                dmnSaat.ReadOnly = true;
                dmnSaat.Increment = 0;
                dmnDakika.ReadOnly = true;
                dmnDakika.Increment = 0;
                dmnSaniye.ReadOnly = true;
                dmnSaniye.Increment = 0;

                saat = dmnSaat.Value;
                dakika = dmnDakika.Value;
                saniye = dmnSaniye.Value;
            }
            else
            {
                tmrSayac.Enabled = false;
                btn.Text = "Zamanlayıcıyı Başlat";

                dmnSaat.ReadOnly = false;
                dmnSaat.Increment = 1;
                dmnDakika.ReadOnly = false;
                dmnDakika.Increment=1;
                dmnSaniye.ReadOnly = false;
                dmnSaniye.Increment=1;

                dmnSaat.Value = saat;
                dmnDakika.Value = dakika;
                dmnSaniye.Value = saniye;
            }
        }

        private decimal saat, dakika, saniye;
        private SoundPlayer alarmCal = new SoundPlayer(Properties.Resources.alarm_sound);

        private void trckBar_Scroll(object sender,EventArgs e)
        {
            switch(trckBar.Value)
            {
                case 1:
                    lblHiz.Text = "Hız: 0.25";
                    tmrSayac.Interval = 2000;
                    break;
                case 2:
                    lblHiz.Text = "Hız: 0.50";
                    tmrSayac.Interval = 1500;
                    break;
                case 3:
                    lblHiz.Text = "Hız: 1.00";
                    tmrSayac.Interval = 1000;
                    break;
                case 4:
                    lblHiz.Text = "Hız: 1.50";
                    tmrSayac.Interval = 500;
                    break;
                case 5:
                    lblHiz.Text = "Hız: 2.00";
                    tmrSayac.Interval = 250;
                    break;
            }
        }

        private void tmrAlarmSesDongu_Tick(object sender,EventArgs e)
        {
            alarmCal.Stop();
            alarmCal.Play();
            btn.Text = "Süre Doldu";
            tmrAlarmSesDongu.Interval = 6200;
        }

        private void tabCntrl_SelectedIndexChanged(object sender,EventArgs e)
        {
            if(tabCntrl.SelectedIndex == 0)
            {
                btn.Text = "Zamanlayıcıyı Başlat";
            }
            else if(tabCntrl.SelectedIndex == 1)
            {
                btn.Text = "Alarmı başlat";
            }
        }

        private void tabCntrl_Selecting(object sender,TabControlCancelEventArgs e)
        {
            if(tmrSayac.Enabled && tabCntrl.SelectedIndex == 1)
            {
                e.Cancel = true;
            }
        }

        private void ekranGuncelle()
        {
            dmnSaat.Value = saat;
            dmnDakika.Value = dakika;
            dmnSaniye.Value = saniye;
        }

        private void tmrSayac_Tick(object sender,EventArgs e)
        {
            saniye--;
            if(saniye < 0)
            {
                saniye = 59;
                dakika--;
                if(dakika < 0)
                {
                    dakika = 59;
                    saat--;
                    if(saat < 0)
                    {
                        saat = 0;
                        dakika = 0;
                        saniye = 0;

                        btn.PerformClick();

                        tmrAlarmSesDongu.Interval = 10;
                        tmrAlarmSesDongu.Enabled = true;
                        
                    }// zamanlayıcının çalacağı yer
                }
            }
                
            ekranGuncelle(); // en son değerler ayarlandıktan sonra ekranı yansımalı.
        }
    }
}
