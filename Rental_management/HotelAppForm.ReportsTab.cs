﻿using Rental_management.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Rental_management
{
    partial class HotelAppForm
    {
        private RadToolbarFormControl radToolbarFormControl1;
        #region Initialization
        private void InitReportsPage()
        {
            this.reportsHeaderPanel.BackgroundImage = Properties.Resources.fasha_no_borders_fullsize;
            this.reportsHeaderPanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.reportsHeaderPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.reportsHeaderPanel.PanelElement.Visibility = ElementVisibility.Collapsed;

            this.ReportsPage.BackgroundImage = Properties.Resources.Background;
            this.ReportsPage.BackgroundImageLayout = ImageLayout.Stretch;
            this.ReportsPage.BackColor = Color.Transparent;
            this.reportsHeaderPanel.RootElement.EnableElementShadow = false;
            this.reportsStatusPanel.RootElement.EnableElementShadow = false;
            this.reportsTypePanel.RootElement.EnableElementShadow = false;
            this.reportsBookingsByTypeLabel.RootElement.EnableElementShadow = false;
            this.reportsCurrentStatusLabel.RootElement.EnableElementShadow = false;

            this.reportsStatusPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.reportsStatusPanel.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.reportsTypePanel.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.reportsTypePanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.reportsCurrentStatusLabel.LabelElement.CustomFont = Utils.MainFont;
            this.reportsCurrentStatusLabel.LabelElement.CustomFontSize = 15f;
            this.reportsCurrentStatusLabel.LabelElement.LabelText.Margin = new Padding(18, 0, 0, 0);
            this.reportsCurrentStatusLabel.TextAlignment = ContentAlignment.BottomLeft;
            this.reportsBookingsByTypeLabel.LabelElement.CustomFont = Utils.MainFont;
            this.reportsBookingsByTypeLabel.LabelElement.CustomFontSize = 15f;
            this.reportsBookingsByTypeLabel.LabelElement.LabelText.Margin = new Padding(18, 0, 0, 0);
            this.reportsBookingsByTypeLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.userControlCurrentStatus1.Padding = new Padding(20, 0, 20, 0);
            this.userControlBookingsByType1.Padding = new Padding(20, 0, 20, 20);

            this.reportsDaysToggleButton.ToggleStateChanged += reportsDaysToggleButton_ToggleStateChanged;
            this.reportsWeeklyToggleButton.ToggleStateChanged += reportsWeeklyToggleButton_ToggleStateChanged;
            this.reportsMonthlyToggleButton.ToggleStateChanged += reportsMonthlyToggleButton_ToggleStateChanged;

            this.reportsDateNavigator.DateTimePicker.ValueChanged += ReportsDateTimePicker_ValueChanged;
        }

        #endregion

        #region Events
        private void ReportsDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.userControlCurrentStatus1.Initialize(reportsInterval, this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
            this.userControlBookingsByType1.Initialize(reportsInterval, this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
        }

        private void reportsMonthlyToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                reportsInterval = "Monthly";
                this.reportsDaysToggleButton.ToggleState = ToggleState.Off;
                this.reportsWeeklyToggleButton.ToggleState = ToggleState.Off;
                this.userControlCurrentStatus1.Initialize("Monthly", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
                this.userControlBookingsByType1.Initialize("Monthly", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
            }
        }

        private void reportsWeeklyToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                reportsInterval = "Weekly";
                this.reportsDaysToggleButton.ToggleState = ToggleState.Off;
                this.reportsMonthlyToggleButton.ToggleState = ToggleState.Off;
                this.userControlCurrentStatus1.Initialize("Weekly", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
                this.userControlBookingsByType1.Initialize("Weekly", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
            }
        }

        private void reportsDaysToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                reportsInterval = "Days";
                this.reportsWeeklyToggleButton.ToggleState = ToggleState.Off;
                this.reportsMonthlyToggleButton.ToggleState = ToggleState.Off;
                this.userControlCurrentStatus1.Initialize("Days", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
                this.userControlBookingsByType1.Initialize("Days", this.Bookings, this.Rooms, this.reportsDateNavigator.CurrentDate);
            }
        }

        #endregion

        private void InitializeComponent()
        {
            this.radToolbarFormControl1 = new Telerik.WinControls.UI.RadToolbarFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.radToolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radToolbarFormControl1
            // 
            this.radToolbarFormControl1.AutoSize = true;
            this.radToolbarFormControl1.CausesValidation = false;
            this.radToolbarFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radToolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radToolbarFormControl1.Name = "radToolbarFormControl1";
            this.radToolbarFormControl1.Size = new System.Drawing.Size(292, 36);
            this.radToolbarFormControl1.TabIndex = 0;
            // 
            // HotelAppForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 295);
            this.Controls.Add(this.radToolbarFormControl1);
            this.Name = "HotelAppForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.radToolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
