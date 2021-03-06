﻿using DevExpress.XtraScheduler.UI;
namespace Stomatološka_ordinacija
{
    partial class OutlookAppointmentForm
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlookAppointmentForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvPrint = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dvInfo = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.bvtPrint = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.bvbSave = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbSaveAs = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbClose = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barLabel = new DevExpress.XtraBars.BarEditItem();
            this.riAppointmentLabel = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel();
            this.barStatus = new DevExpress.XtraBars.BarEditItem();
            this.riAppointmentStatus = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus();
            this.barReminder = new DevExpress.XtraBars.BarEditItem();
            this.riDuration = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.btnRecurrence = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimeZones = new DevExpress.XtraBars.BarButtonItem();
            this.rpAppointment = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.riAppointmentResource = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtStartTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.tbSubject = new DevExpress.XtraEditors.TextEdit();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.bvPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSaveAndClose,
            this.btnDelete,
            this.barLabel,
            this.barStatus,
            this.barReminder,
            this.btnRecurrence,
            this.btnSave,
            this.btnNext,
            this.btnPrevious,
            this.btnTimeZones});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAppointment});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riAppointmentLabel,
            this.riAppointmentResource,
            this.riAppointmentStatus,
            this.riDuration});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ApplicationButtonClick += new System.EventHandler(this.ribbonControl1_ApplicationButtonClick);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.bvPrint);
            this.backstageViewControl1.Items.Add(this.bvtPrint);
            this.backstageViewControl1.Items.Add(this.bvbSave);
            this.backstageViewControl1.Items.Add(this.bvbSaveAs);
            this.backstageViewControl1.Items.Add(this.bvbClose);
            resources.ApplyResources(this.backstageViewControl1, "backstageViewControl1");
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.bvtPrint;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            // 
            // bvPrint
            // 
            this.bvPrint.Controls.Add(this.btnPrint);
            this.bvPrint.Controls.Add(this.dvInfo);
            resources.ApplyResources(this.bvPrint, "bvPrint");
            this.bvPrint.Name = "bvPrint";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            // 
            // dvInfo
            // 
            this.dvInfo.AutoZoom = true;
            resources.ApplyResources(this.dvInfo, "dvInfo");
            this.dvInfo.Name = "dvInfo";
            // 
            // bvtPrint
            // 
            this.bvtPrint.ContentControl = this.bvPrint;
            this.bvtPrint.Name = "bvtPrint";
            this.bvtPrint.Selected = true;
            // 
            // bvbSave
            // 
            resources.ApplyResources(this.bvbSave, "bvbSave");
            this.bvbSave.Name = "bvbSave";
            this.bvbSave.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSave_ItemClick);
            // 
            // bvbSaveAs
            // 
            resources.ApplyResources(this.bvbSaveAs, "bvbSaveAs");
            this.bvbSaveAs.Name = "bvbSaveAs";
            this.bvbSaveAs.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSaveAs_ItemClick);
            // 
            // bvbClose
            // 
            resources.ApplyResources(this.bvbClose, "bvbClose");
            this.bvbClose.Name = "bvbClose";
            this.bvbClose.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbClose_ItemClick);
            // 
            // btnSaveAndClose
            // 
            resources.ApplyResources(this.btnSaveAndClose, "btnSaveAndClose");
            this.btnSaveAndClose.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSaveAndClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.Glyph")));
            this.btnSaveAndClose.Id = 3;
            this.btnSaveAndClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.LargeGlyph")));
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndClose_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDelete_ItemClick);
            // 
            // barLabel
            // 
            resources.ApplyResources(this.barLabel, "barLabel");
            this.barLabel.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barLabel.Edit = this.riAppointmentLabel;
            this.barLabel.Id = 8;
            this.barLabel.Name = "barLabel";
            // 
            // riAppointmentLabel
            // 
            resources.ApplyResources(this.riAppointmentLabel, "riAppointmentLabel");
            this.riAppointmentLabel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentLabel.Buttons"))))});
            this.riAppointmentLabel.Name = "riAppointmentLabel";
            // 
            // barStatus
            // 
            resources.ApplyResources(this.barStatus, "barStatus");
            this.barStatus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barStatus.Edit = this.riAppointmentStatus;
            this.barStatus.Id = 11;
            this.barStatus.Name = "barStatus";
            // 
            // riAppointmentStatus
            // 
            resources.ApplyResources(this.riAppointmentStatus, "riAppointmentStatus");
            this.riAppointmentStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentStatus.Buttons"))))});
            this.riAppointmentStatus.Name = "riAppointmentStatus";
            // 
            // barReminder
            // 
            resources.ApplyResources(this.barReminder, "barReminder");
            this.barReminder.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barReminder.Edit = this.riDuration;
            this.barReminder.Id = 12;
            this.barReminder.Name = "barReminder";
            // 
            // riDuration
            // 
            resources.ApplyResources(this.riDuration, "riDuration");
            this.riDuration.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riDuration.Buttons"))))});
            this.riDuration.DisabledStateText = null;
            this.riDuration.Name = "riDuration";
            this.riDuration.ShowEmptyItem = true;
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            resources.ApplyResources(this.btnRecurrence, "btnRecurrence");
            this.btnRecurrence.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnRecurrence.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRecurrence.Glyph")));
            this.btnRecurrence.Id = 17;
            this.btnRecurrence.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRecurrence.LargeGlyph")));
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRecurrence_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSave.Id = 1;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnNext.Id = 3;
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPrevious.Id = 4;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrevious_ItemClick);
            // 
            // btnTimeZones
            // 
            this.btnTimeZones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnTimeZones.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnTimeZones.Id = 1;
            this.btnTimeZones.Name = "btnTimeZones";
            this.btnTimeZones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimeZones_ItemClick);
            // 
            // rpAppointment
            // 
            this.rpAppointment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions,
            this.rpgOptions});
            this.rpAppointment.Name = "rpAppointment";
            resources.ApplyResources(this.rpAppointment, "rpAppointment");
            // 
            // rpgActions
            // 
            this.rpgActions.ItemLinks.Add(this.btnSaveAndClose);
            this.rpgActions.ItemLinks.Add(this.btnDelete);
            this.rpgActions.Name = "rpgActions";
            this.rpgActions.ShowCaptionButton = false;
            resources.ApplyResources(this.rpgActions, "rpgActions");
            // 
            // rpgOptions
            // 
            this.rpgOptions.AllowTextClipping = false;
            this.rpgOptions.ItemLinks.Add(this.barLabel);
            this.rpgOptions.Name = "rpgOptions";
            this.rpgOptions.ShowCaptionButton = false;
            resources.ApplyResources(this.rpgOptions, "rpgOptions");
            // 
            // riAppointmentResource
            // 
            resources.ApplyResources(this.riAppointmentResource, "riAppointmentResource");
            this.riAppointmentResource.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("riAppointmentResource.Buttons"))))});
            this.riAppointmentResource.Name = "riAppointmentResource";
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Name = "lblStartTime";
            // 
            // edtStartDate
            // 
            resources.ApplyResources(this.edtStartDate, "edtStartDate");
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName");
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtStartDate.Properties.Buttons"))))});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // edtStartTime
            // 
            resources.ApplyResources(this.edtStartTime, "edtStartTime");
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName");
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Properties.Mask.EditMask = resources.GetString("edtStartTime.Properties.Mask.EditMask");
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
            // 
            // edtEndDate
            // 
            resources.ApplyResources(this.edtEndDate, "edtEndDate");
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName");
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtEndDate.Properties.Buttons"))))});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // edtEndTime
            // 
            resources.ApplyResources(this.edtEndTime, "edtEndTime");
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName");
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Properties.Mask.EditMask = resources.GetString("edtEndTime.Properties.Mask.EditMask");
            // 
            // tbSubject
            // 
            resources.ApplyResources(this.tbSubject, "tbSubject");
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName");
            // 
            // progressPanel
            // 
            resources.ApplyResources(this.progressPanel, "progressPanel");
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.TabStop = true;
            // 
            // lblSubject
            // 
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.Name = "lblSubject";
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName");
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            // 
            // panelDescription
            // 
            resources.ApplyResources(this.panelDescription, "panelDescription");
            this.panelDescription.Name = "panelDescription";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSubject);
            this.panel2.Controls.Add(this.tbSubject);
            this.panel2.Controls.Add(this.edtEndTime);
            this.panel2.Controls.Add(this.edtEndDate);
            this.panel2.Controls.Add(this.lblEndTime);
            this.panel2.Controls.Add(this.lblStartTime);
            this.panel2.Controls.Add(this.edtStartTime);
            this.panel2.Controls.Add(this.edtStartDate);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backstageViewControl1);
            this.panel3.Controls.Add(this.tbDescription);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // OutlookAppointmentForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "OutlookAppointmentForm";
            this.Ribbon = this.ribbonControl1;
            this.Activated += new System.EventHandler(this.OnAppointmentFormActivated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.bvPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAppointmentResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAppointment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOptions;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarEditItem barLabel;
        private RepositoryItemAppointmentLabel riAppointmentLabel;
        private RepositoryItemAppointmentResource riAppointmentResource;
        private DevExpress.XtraBars.BarEditItem barStatus;
        private RepositoryItemAppointmentStatus riAppointmentStatus;
        private DevExpress.XtraBars.BarEditItem barReminder;
        private RepositoryItemDuration riDuration;
        private DevExpress.XtraBars.BarButtonItem btnRecurrence;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected SchedulerTimeEdit edtStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected SchedulerTimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TextEdit tbSubject;
        protected System.Windows.Forms.Panel progressPanel;
        protected DevExpress.XtraEditors.LabelControl lblSubject;
        private System.Windows.Forms.Panel panelMain;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSave;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSaveAs;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbClose;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnTimeZones;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl bvPrint;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtPrint;
        private DevExpress.XtraPrinting.Preview.DocumentViewer dvInfo;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}