using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraScheduler;


namespace Stomatološka_ordinacija
{
    public partial class Form2 : RibbonForm
    {
        public Form2()
        {
            InitializeComponent();
            InitSkinGallery();
            Kalendar.Start = System.DateTime.Now;
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        private void Pacijenti_ItemClick(object sender, ItemClickEventArgs e)
        {         
            Pacijenti pacijenti = new Pacijenti();
            pacijenti.ShowDialog();         
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            //DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this,typeof(Panel),false,false,true);
            //DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Pričekajte molim...");
            try
            {  
                this.resourcesTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.Resources);                
                //this.appointmentsTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.Appointments);
                System.Windows.Forms.Timer sat = new System.Windows.Forms.Timer();
                sat.Tick += new EventHandler(this.vrijeme);
                sat.Interval = 1000;
                sat.Enabled = true;

            }
           
            finally
            {
                //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            }

        }
        private void vrijeme(object sender, EventArgs e)
        {
            Sat.Text = System.DateTime.Now.ToString("HH:mm:ss ");
        }
        private void Kalendar_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Stomatološka_ordinacija.OutlookAppointmentForm form = new Stomatološka_ordinacija.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
                
            }
            finally
            {
                form.Dispose();
            }

        }
        private void OnAppointmentChangedInsertedDelited(object sender, PersistentObjectsEventArgs e)
        {
            
            appointmentsTableAdapter.Update(stomatoloskaOrdinacijaDataSet);
            stomatoloskaOrdinacijaDataSet.AcceptChanges();
        }
        private void Kalendar_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Stomatološka_ordinacija.OutlookAppointmentForm form = new Stomatološka_ordinacija.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 prijava = new Form1();
            prijava.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}