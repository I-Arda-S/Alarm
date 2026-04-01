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
            btn.Text = zamanlayiciBaslat;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MouseWheel += dateTimePicker1_MouseWheel;
        }

        private string sureDoldu = "Süre Doldu";
        private string zamanlayiciBaslat= "Zamanlayıcıyı Başlat";
        private string zamanlayiciDurdur = "Zamanlayıcıyı Durdur";

        private string alarmBaslat = "Alarmı Başlat";
        private string alarmDurdur = "Alarmı Durdur";
        private string alarmKapat = "Alarmı Kapat";

        private void dateTimePicker1_MouseWheel(object sender,MouseEventArgs e)
        {
            if(e.Delta > 0) 
            {
                SendKeys.Send("{UP}");
            }
            else if(e.Delta < 0)
            {
                SendKeys.Send("{DOWN}");
            }

            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void btn_Click(object sender,EventArgs e)
        {
            if(btn.Text==sureDoldu || zamanlayiciCaliyor)
            {
                alarmCal.Stop();
                tmrSayac.Enabled = false;
                btn.Text = zamanlayiciBaslat;
                return;
            }

            if(!tmrSayac.Enabled)// Zamanlayıcı başlayacakken
            {
                tmrSayac.Enabled = true;
                btn.Text = zamanlayiciDurdur;
                

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
            else // Zamanlayıcı durdurulacakken
            {
                durdurZamanlayici();
            }
        }

        private void durdurZamanlayici()
        {
            tmrSayac.Enabled= false;
            btn.Text = zamanlayiciBaslat;

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

        private void btnAlarm_Click(object sender,EventArgs e)
        {
            if(btnAlarm.Text == alarmKapat)
            {
                alarmCal.Stop();
                btnAlarm.Text = alarmBaslat;
                return;
            }

            if(tmrAlarm.Enabled) // 
            {
                tmrAlarm.Enabled = false;
                btnAlarm.Text = alarmBaslat;

                dateTimePicker1.Enabled = true;

            }
            else //
            {
                tmrAlarm.Enabled = true;
                btnAlarm.Text = alarmDurdur;

                dateTimePicker1.Enabled= false;
            }
        }

        private void tmrAlarm_Tick(object sender,EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            TimeSpan fark = dateTimePicker1.Value - simdi;

            if(simdi > dateTimePicker1.Value)
                fark += TimeSpan.FromDays(1);
            else if (fark.Hours==0 && fark.Minutes==0 && fark.Seconds==0)
            {
                alarmCal.PlayLooping();

                btnAlarm.Text = alarmKapat;

                tabCntrl.SelectedIndex = 1;
                // Tab değişmeycek
                tmrAlarm.Enabled = false;


                if(tmrSayac.Enabled)
                {
                    durdurZamanlayici();
                    MessageBox.Show("Zamanlayıcı durduruldu, alarm çalıyor.");
                }// Alarm bitince zamanlayıcyı durdur.
            }

            textBox1.Text = fark.ToString(@"hh\:mm\:ss");
        }

        private void tabCntrl_SelectedIndexChanged(object sender,EventArgs e)
        {
            if(tabCntrl.SelectedIndex != 1 && btnAlarm.Text == alarmKapat)
            {
                tabCntrl.SelectedIndex = 1;
            }// Alarm sekmesi çalarken oradan çıkışı engelle.

            // Zamanlayıcı çalarken tabı sabitlemeye çalışmıycam, ikiside aynı anda çalarsa sıkıntı vercek gibi.
        }

        private void ekranGuncelle()
        {
            dmnSaat.Value = saat;
            dmnDakika.Value = dakika;
            dmnSaniye.Value = saniye;
        }

        private bool zamanlayiciCaliyor = false;
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

                        alarmCal.PlayLooping();
                        btn.Text = sureDoldu;
                        zamanlayiciCaliyor = true;

                    }// zamanlayıcının çalacağı yer
                }
            }
                
            ekranGuncelle(); // en son değerler ayarlandıktan sonra ekranı yansımalı.
        }
    }
}
