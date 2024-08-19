using CustomControls;
using Telerik.WinControls.UI;

namespace Rental_management
{
    partial class HotelAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.mainContainer = new Telerik.WinControls.UI.RadPageView();
            this.OverviewPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.overviewMainContainer = new Telerik.WinControls.UI.RadPanel();
            this.overviewRoomsView = new Telerik.WinControls.UI.RadListView();
            this.overviewLeftView = new Telerik.WinControls.UI.RadListView();
            this.navigationPanelOverview = new Telerik.WinControls.UI.RadPanel();
            this.searchContainerOverview = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBoxOverview = new Rental_management.SearchTextBox();
            this.radPanelEmptyOverview = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigatorOverview = new CustomControls.DateNavigator();
            this.BookingsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.bookingsMainContainer = new Telerik.WinControls.UI.RadPanel();
            this.bookingsGrid = new Telerik.WinControls.UI.RadGridView();
            this.labelBookings = new Telerik.WinControls.UI.RadLabel();
            this.bookingInfoRightPanel = new Telerik.WinControls.UI.RadPanel();
            this.editGuestInfo = new CustomControls.EditGuestInfo();
            this.bookingInfoUC = new CustomControls.BookingInfo();
            this.navigationPanelBookings = new Telerik.WinControls.UI.RadPanel();
            this.searchContainerBookings = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBoxBookings = new Rental_management.SearchTextBox();
            this.radPanelEmptyBooking = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigatorBookings = new CustomControls.DateNavigator();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.editGuestInfo1 = new CustomControls.EditGuestInfo();
            this.bookingInfo1 = new CustomControls.BookingInfo();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBox1 = new Rental_management.SearchTextBox();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigator1 = new CustomControls.DateNavigator();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPanel9 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel10 = new Telerik.WinControls.UI.RadPanel();
            this.editGuestInfo2 = new CustomControls.EditGuestInfo();
            this.bookingInfo2 = new CustomControls.BookingInfo();
            this.radPanel6 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel7 = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBox2 = new Rental_management.SearchTextBox();
            this.radPanel8 = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigator2 = new CustomControls.DateNavigator();
            this.ReportsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.reportsTypePanel = new Telerik.WinControls.UI.RadPanel();
            this.userControlBookingsByType1 = new Rental_management.UserControlBookingsByType();
            this.reportsBookingsByTypeLabel = new Telerik.WinControls.UI.RadLabel();
            this.reportsStatusPanel = new Telerik.WinControls.UI.RadPanel();
            this.userControlCurrentStatus1 = new Rental_management.UserControlCurrentStatus();
            this.reportsCurrentStatusLabel = new Telerik.WinControls.UI.RadLabel();
            this.reportsHeaderPanel = new Telerik.WinControls.UI.RadPanel();
            this.reportsWeeklyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsMonthlyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsDaysToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsDateNavigator = new CustomControls.DateNavigator();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.materialPinkTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.houseKeepingListView = new Telerik.WinControls.UI.RadListView();
            this.houseKeepingNavigationPanel = new Telerik.WinControls.UI.RadPanel();
            this.houseKeepingDateNavigator = new CustomControls.DateNavigator();
            this.houseKeepingDaysToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingMonthlyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingWeeklyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.notAssignedLabel = new Telerik.WinControls.UI.RadLabel();
            this.notAssignedGridView = new Telerik.WinControls.UI.RadGridView();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.houseKeepingSchedulerHeaderLabel = new Telerik.WinControls.UI.RadLabel();
            this.houseKeepingScheduler = new Telerik.WinControls.UI.RadScheduler();
            this.HouseKeepingPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.scheduleListView = new Telerik.WinControls.UI.RadListView();
            this.scheduleRadSchedulerHeader = new Telerik.WinControls.UI.RadPanel();
            this.ScheduleRadScheduler = new Telerik.WinControls.UI.RadScheduler();
            this.scheduleHeaderPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleDaysButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleMonthlyButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleWeeklyButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleDateNavigator = new CustomControls.DateNavigator();
            this.scheduleSearchPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleSearchDropDown = new Rental_management.SearchDropDownList();
            this.scheduleBookingPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleEditGuestInfo = new CustomControls.EditGuestInfo();
            this.scheduleBookingInfo = new CustomControls.BookingInfo();
            this.SchedulePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radToolbarFormControl2 = new Telerik.WinControls.UI.RadToolbarFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.OverviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewMainContainer)).BeginInit();
            this.overviewMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewRoomsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewLeftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelOverview)).BeginInit();
            this.navigationPanelOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerOverview)).BeginInit();
            this.searchContainerOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyOverview)).BeginInit();
            this.BookingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsMainContainer)).BeginInit();
            this.bookingsMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoRightPanel)).BeginInit();
            this.bookingInfoRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelBookings)).BeginInit();
            this.navigationPanelBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerBookings)).BeginInit();
            this.searchContainerBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyBooking)).BeginInit();
            this.radPageViewPage1.SuspendLayout();
            this.radPageViewPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            this.radPageViewPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel9)).BeginInit();
            this.radPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel10)).BeginInit();
            this.radPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).BeginInit();
            this.radPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel7)).BeginInit();
            this.radPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel8)).BeginInit();
            this.ReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsTypePanel)).BeginInit();
            this.reportsTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBookingsByTypeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsStatusPanel)).BeginInit();
            this.reportsStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsCurrentStatusLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsHeaderPanel)).BeginInit();
            this.reportsHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsWeeklyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsMonthlyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDaysToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingNavigationPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingDaysToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingMonthlyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingWeeklyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSchedulerHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingScheduler)).BeginInit();
            this.HouseKeepingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRadSchedulerHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleRadScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleHeaderPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDaysButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMonthlyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleWeeklyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookingPanel)).BeginInit();
            this.SchedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radToolbarFormControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.OverviewPage);
            this.mainContainer.Controls.Add(this.BookingsPage);
            this.mainContainer.Controls.Add(this.radPageViewPage1);
            this.mainContainer.Controls.Add(this.radPageViewPage2);
            this.mainContainer.Controls.Add(this.ReportsPage);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 47);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.SelectedPage = this.ReportsPage;
            this.mainContainer.Size = new System.Drawing.Size(938, 650);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.ThemeName = "Material";
            this.mainContainer.SelectedPageChanged += new System.EventHandler(this.mainContainer_SelectedPageChanged);
            // 
            // OverviewPage
            // 
            this.OverviewPage.Controls.Add(this.overviewMainContainer);
            this.OverviewPage.Controls.Add(this.navigationPanelOverview);
            this.OverviewPage.ItemSize = new System.Drawing.SizeF(70F, 49F);
            this.OverviewPage.Location = new System.Drawing.Point(6, 55);
            this.OverviewPage.Name = "OverviewPage";
            this.OverviewPage.Size = new System.Drawing.Size(926, 589);
            this.OverviewPage.Text = "الرئيسية";
            // 
            // overviewMainContainer
            // 
            this.overviewMainContainer.Controls.Add(this.overviewRoomsView);
            this.overviewMainContainer.Controls.Add(this.overviewLeftView);
            this.overviewMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewMainContainer.Location = new System.Drawing.Point(0, 60);
            this.overviewMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.overviewMainContainer.Name = "overviewMainContainer";
            this.overviewMainContainer.Size = new System.Drawing.Size(926, 529);
            this.overviewMainContainer.TabIndex = 3;
            // 
            // overviewRoomsView
            // 
            this.overviewRoomsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewRoomsView.Location = new System.Drawing.Point(0, 0);
            this.overviewRoomsView.Margin = new System.Windows.Forms.Padding(0);
            this.overviewRoomsView.Name = "overviewRoomsView";
            this.overviewRoomsView.Size = new System.Drawing.Size(657, 529);
            this.overviewRoomsView.TabIndex = 2;
            this.overviewRoomsView.SelectedItemChanged += new System.EventHandler(this.overviewRoomsView_SelectedItemChanged);
            // 
            // overviewLeftView
            // 
            this.overviewLeftView.Dock = System.Windows.Forms.DockStyle.Right;
            this.overviewLeftView.Location = new System.Drawing.Point(657, 0);
            this.overviewLeftView.Margin = new System.Windows.Forms.Padding(0);
            this.overviewLeftView.Name = "overviewLeftView";
            this.overviewLeftView.Size = new System.Drawing.Size(269, 529);
            this.overviewLeftView.TabIndex = 1;
            // 
            // navigationPanelOverview
            // 
            this.navigationPanelOverview.Controls.Add(this.searchContainerOverview);
            this.navigationPanelOverview.Controls.Add(this.dateNavigatorOverview);
            this.navigationPanelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanelOverview.Location = new System.Drawing.Point(0, 0);
            this.navigationPanelOverview.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanelOverview.Name = "navigationPanelOverview";
            this.navigationPanelOverview.Size = new System.Drawing.Size(926, 60);
            this.navigationPanelOverview.TabIndex = 0;
            // 
            // searchContainerOverview
            // 
            this.searchContainerOverview.Controls.Add(this.searchTextBoxOverview);
            this.searchContainerOverview.Controls.Add(this.radPanelEmptyOverview);
            this.searchContainerOverview.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContainerOverview.Location = new System.Drawing.Point(294, 0);
            this.searchContainerOverview.Name = "searchContainerOverview";
            this.searchContainerOverview.Size = new System.Drawing.Size(632, 60);
            this.searchContainerOverview.TabIndex = 1;
            // 
            // searchTextBoxOverview
            // 
            this.searchTextBoxOverview.AutoSize = false;
            this.searchTextBoxOverview.Location = new System.Drawing.Point(3, 10);
            this.searchTextBoxOverview.Name = "searchTextBoxOverview";
            this.searchTextBoxOverview.NullText = "ابحث عن سائق او سيارة";
            // 
            // 
            // 
            this.searchTextBoxOverview.RootElement.CustomFont = "Roboto";
            this.searchTextBoxOverview.RootElement.CustomFontSize = 8F;
            this.searchTextBoxOverview.Size = new System.Drawing.Size(590, 29);
            this.searchTextBoxOverview.TabIndex = 0;
            // 
            // radPanelEmptyOverview
            // 
            this.radPanelEmptyOverview.BackColor = System.Drawing.Color.Transparent;
            this.radPanelEmptyOverview.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanelEmptyOverview.Location = new System.Drawing.Point(592, 0);
            this.radPanelEmptyOverview.Name = "radPanelEmptyOverview";
            this.radPanelEmptyOverview.Size = new System.Drawing.Size(40, 60);
            this.radPanelEmptyOverview.TabIndex = 1;
            // 
            // dateNavigatorOverview
            // 
            this.dateNavigatorOverview.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigatorOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigatorOverview.Location = new System.Drawing.Point(0, 0);
            this.dateNavigatorOverview.Name = "dateNavigatorOverview";
            this.dateNavigatorOverview.Size = new System.Drawing.Size(270, 60);
            this.dateNavigatorOverview.TabIndex = 0;
            // 
            // BookingsPage
            // 
            this.BookingsPage.Controls.Add(this.bookingsMainContainer);
            this.BookingsPage.Controls.Add(this.navigationPanelBookings);
            this.BookingsPage.ItemSize = new System.Drawing.SizeF(73F, 49F);
            this.BookingsPage.Location = new System.Drawing.Point(6, 55);
            this.BookingsPage.Name = "BookingsPage";
            this.BookingsPage.Size = new System.Drawing.Size(926, 589);
            this.BookingsPage.Text = "الشركات";
            // 
            // bookingsMainContainer
            // 
            this.bookingsMainContainer.Controls.Add(this.bookingsGrid);
            this.bookingsMainContainer.Controls.Add(this.labelBookings);
            this.bookingsMainContainer.Controls.Add(this.bookingInfoRightPanel);
            this.bookingsMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsMainContainer.Location = new System.Drawing.Point(0, 60);
            this.bookingsMainContainer.Name = "bookingsMainContainer";
            this.bookingsMainContainer.Size = new System.Drawing.Size(926, 529);
            this.bookingsMainContainer.TabIndex = 3;
            // 
            // bookingsGrid
            // 
            this.bookingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsGrid.Location = new System.Drawing.Point(0, 50);
            this.bookingsGrid.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            // 
            // 
            // 
            this.bookingsGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.bookingsGrid.Name = "bookingsGrid";
            this.bookingsGrid.Size = new System.Drawing.Size(656, 479);
            this.bookingsGrid.TabIndex = 5;
            // 
            // labelBookings
            // 
            this.labelBookings.AutoSize = false;
            this.labelBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookings.Location = new System.Drawing.Point(0, 0);
            this.labelBookings.Name = "labelBookings";
            this.labelBookings.Size = new System.Drawing.Size(656, 50);
            this.labelBookings.TabIndex = 4;
            this.labelBookings.Text = "Occupied by";
            this.labelBookings.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // bookingInfoRightPanel
            // 
            this.bookingInfoRightPanel.Controls.Add(this.editGuestInfo);
            this.bookingInfoRightPanel.Controls.Add(this.bookingInfoUC);
            this.bookingInfoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookingInfoRightPanel.Location = new System.Drawing.Point(656, 0);
            this.bookingInfoRightPanel.Name = "bookingInfoRightPanel";
            this.bookingInfoRightPanel.Size = new System.Drawing.Size(270, 529);
            this.bookingInfoRightPanel.TabIndex = 1;
            // 
            // editGuestInfo
            // 
            this.editGuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo.Name = "editGuestInfo";
            this.editGuestInfo.Size = new System.Drawing.Size(270, 529);
            this.editGuestInfo.TabIndex = 1;
            // 
            // bookingInfoUC
            // 
            this.bookingInfoUC.Booking = null;
            this.bookingInfoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInfoUC.Location = new System.Drawing.Point(0, 0);
            this.bookingInfoUC.Name = "bookingInfoUC";
            this.bookingInfoUC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookingInfoUC.Room = null;
            this.bookingInfoUC.Size = new System.Drawing.Size(270, 529);
            this.bookingInfoUC.TabIndex = 0;
            // 
            // navigationPanelBookings
            // 
            this.navigationPanelBookings.Controls.Add(this.searchContainerBookings);
            this.navigationPanelBookings.Controls.Add(this.dateNavigatorBookings);
            this.navigationPanelBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanelBookings.Location = new System.Drawing.Point(0, 0);
            this.navigationPanelBookings.Name = "navigationPanelBookings";
            this.navigationPanelBookings.Size = new System.Drawing.Size(926, 60);
            this.navigationPanelBookings.TabIndex = 1;
            // 
            // searchContainerBookings
            // 
            this.searchContainerBookings.Controls.Add(this.searchTextBoxBookings);
            this.searchContainerBookings.Controls.Add(this.radPanelEmptyBooking);
            this.searchContainerBookings.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContainerBookings.Location = new System.Drawing.Point(294, 0);
            this.searchContainerBookings.Name = "searchContainerBookings";
            this.searchContainerBookings.Size = new System.Drawing.Size(632, 60);
            this.searchContainerBookings.TabIndex = 1;
            // 
            // searchTextBoxBookings
            // 
            this.searchTextBoxBookings.AutoSize = false;
            this.searchTextBoxBookings.Location = new System.Drawing.Point(3, 10);
            this.searchTextBoxBookings.Name = "searchTextBoxBookings";
            this.searchTextBoxBookings.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.searchTextBoxBookings.RootElement.CustomFont = "Roboto";
            this.searchTextBoxBookings.RootElement.CustomFontSize = 8F;
            this.searchTextBoxBookings.Size = new System.Drawing.Size(590, 29);
            this.searchTextBoxBookings.TabIndex = 0;
            // 
            // radPanelEmptyBooking
            // 
            this.radPanelEmptyBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanelEmptyBooking.Location = new System.Drawing.Point(592, 0);
            this.radPanelEmptyBooking.Name = "radPanelEmptyBooking";
            this.radPanelEmptyBooking.Size = new System.Drawing.Size(40, 60);
            this.radPanelEmptyBooking.TabIndex = 1;
            // 
            // dateNavigatorBookings
            // 
            this.dateNavigatorBookings.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigatorBookings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigatorBookings.Location = new System.Drawing.Point(0, 0);
            this.dateNavigatorBookings.Name = "dateNavigatorBookings";
            this.dateNavigatorBookings.Size = new System.Drawing.Size(270, 60);
            this.dateNavigatorBookings.TabIndex = 0;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radPageViewPage3);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(75F, 49F);
            this.radPageViewPage1.Location = new System.Drawing.Point(6, 55);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(926, 589);
            this.radPageViewPage1.Text = "السيارات";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Controls.Add(this.radPanel4);
            this.radPageViewPage3.Controls.Add(this.radPanel1);
            this.radPageViewPage3.Location = new System.Drawing.Point(8, 8);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(1280, 589);
            this.radPageViewPage3.Text = "الشركات";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radGridView1);
            this.radPanel4.Controls.Add(this.radLabel1);
            this.radPanel4.Controls.Add(this.radPanel5);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel4.Location = new System.Drawing.Point(0, 60);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(1280, 529);
            this.radPanel4.TabIndex = 3;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 50);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1010, 479);
            this.radGridView1.TabIndex = 5;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(1010, 50);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Occupied by";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.editGuestInfo1);
            this.radPanel5.Controls.Add(this.bookingInfo1);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel5.Location = new System.Drawing.Point(1010, 0);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(270, 529);
            this.radPanel5.TabIndex = 1;
            // 
            // editGuestInfo1
            // 
            this.editGuestInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo1.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo1.Name = "editGuestInfo1";
            this.editGuestInfo1.Size = new System.Drawing.Size(270, 529);
            this.editGuestInfo1.TabIndex = 1;
            // 
            // bookingInfo1
            // 
            this.bookingInfo1.Booking = null;
            this.bookingInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInfo1.Location = new System.Drawing.Point(0, 0);
            this.bookingInfo1.Name = "bookingInfo1";
            this.bookingInfo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookingInfo1.Room = null;
            this.bookingInfo1.Size = new System.Drawing.Size(270, 529);
            this.bookingInfo1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.dateNavigator1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1280, 60);
            this.radPanel1.TabIndex = 1;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.searchTextBox1);
            this.radPanel2.Controls.Add(this.radPanel3);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel2.Location = new System.Drawing.Point(648, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(632, 60);
            this.radPanel2.TabIndex = 1;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.AutoSize = false;
            this.searchTextBox1.Location = new System.Drawing.Point(3, 10);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.searchTextBox1.RootElement.CustomFont = "Roboto";
            this.searchTextBox1.RootElement.CustomFontSize = 8F;
            this.searchTextBox1.Size = new System.Drawing.Size(590, 29);
            this.searchTextBox1.TabIndex = 0;
            // 
            // radPanel3
            // 
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel3.Location = new System.Drawing.Point(592, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(40, 60);
            this.radPanel3.TabIndex = 1;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(270, 60);
            this.dateNavigator1.TabIndex = 0;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.radPageViewPage4);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(69F, 49F);
            this.radPageViewPage2.Location = new System.Drawing.Point(6, 55);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(926, 589);
            this.radPageViewPage2.Text = "السائقين";
            this.radPageViewPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.radPageViewPage2_Paint);
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.Controls.Add(this.radPanel9);
            this.radPageViewPage4.Controls.Add(this.radPanel6);
            this.radPageViewPage4.Location = new System.Drawing.Point(8, 8);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(1280, 589);
            this.radPageViewPage4.Text = "الشركات";
            this.radPageViewPage4.Paint += new System.Windows.Forms.PaintEventHandler(this.radPageViewPage4_Paint);
            // 
            // radPanel9
            // 
            this.radPanel9.Controls.Add(this.radGridView2);
            this.radPanel9.Controls.Add(this.radLabel2);
            this.radPanel9.Controls.Add(this.radPanel10);
            this.radPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel9.Location = new System.Drawing.Point(0, 60);
            this.radPanel9.Name = "radPanel9";
            this.radPanel9.Size = new System.Drawing.Size(1280, 529);
            this.radPanel9.TabIndex = 3;
            // 
            // radGridView2
            // 
            this.radGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView2.Location = new System.Drawing.Point(0, 50);
            this.radGridView2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.Size = new System.Drawing.Size(1010, 479);
            this.radGridView2.TabIndex = 5;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel2.Location = new System.Drawing.Point(0, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(1010, 50);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Occupied by";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radPanel10
            // 
            this.radPanel10.Controls.Add(this.editGuestInfo2);
            this.radPanel10.Controls.Add(this.bookingInfo2);
            this.radPanel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel10.Location = new System.Drawing.Point(1010, 0);
            this.radPanel10.Name = "radPanel10";
            this.radPanel10.Size = new System.Drawing.Size(270, 529);
            this.radPanel10.TabIndex = 1;
            // 
            // editGuestInfo2
            // 
            this.editGuestInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo2.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo2.Name = "editGuestInfo2";
            this.editGuestInfo2.Size = new System.Drawing.Size(270, 529);
            this.editGuestInfo2.TabIndex = 1;
            // 
            // bookingInfo2
            // 
            this.bookingInfo2.Booking = null;
            this.bookingInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInfo2.Location = new System.Drawing.Point(0, 0);
            this.bookingInfo2.Name = "bookingInfo2";
            this.bookingInfo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookingInfo2.Room = null;
            this.bookingInfo2.Size = new System.Drawing.Size(270, 529);
            this.bookingInfo2.TabIndex = 0;
            // 
            // radPanel6
            // 
            this.radPanel6.Controls.Add(this.radPanel7);
            this.radPanel6.Controls.Add(this.dateNavigator2);
            this.radPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel6.Location = new System.Drawing.Point(0, 0);
            this.radPanel6.Name = "radPanel6";
            this.radPanel6.Size = new System.Drawing.Size(1280, 60);
            this.radPanel6.TabIndex = 1;
            // 
            // radPanel7
            // 
            this.radPanel7.Controls.Add(this.searchTextBox2);
            this.radPanel7.Controls.Add(this.radPanel8);
            this.radPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel7.Location = new System.Drawing.Point(648, 0);
            this.radPanel7.Name = "radPanel7";
            this.radPanel7.Size = new System.Drawing.Size(632, 60);
            this.radPanel7.TabIndex = 1;
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.AutoSize = false;
            this.searchTextBox2.Location = new System.Drawing.Point(3, 10);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.searchTextBox2.RootElement.CustomFont = "Roboto";
            this.searchTextBox2.RootElement.CustomFontSize = 8F;
            this.searchTextBox2.Size = new System.Drawing.Size(590, 29);
            this.searchTextBox2.TabIndex = 0;
            // 
            // radPanel8
            // 
            this.radPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel8.Location = new System.Drawing.Point(592, 0);
            this.radPanel8.Name = "radPanel8";
            this.radPanel8.Size = new System.Drawing.Size(40, 60);
            this.radPanel8.TabIndex = 1;
            // 
            // dateNavigator2
            // 
            this.dateNavigator2.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator2.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator2.Name = "dateNavigator2";
            this.dateNavigator2.Size = new System.Drawing.Size(270, 60);
            this.dateNavigator2.TabIndex = 0;
            // 
            // ReportsPage
            // 
            this.ReportsPage.Controls.Add(this.reportsTypePanel);
            this.ReportsPage.Controls.Add(this.reportsStatusPanel);
            this.ReportsPage.Controls.Add(this.reportsHeaderPanel);
            this.ReportsPage.ItemSize = new System.Drawing.SizeF(66F, 49F);
            this.ReportsPage.Location = new System.Drawing.Point(6, 55);
            this.ReportsPage.Name = "ReportsPage";
            this.ReportsPage.Size = new System.Drawing.Size(926, 589);
            this.ReportsPage.Text = "التقارير";
            // 
            // reportsTypePanel
            // 
            this.reportsTypePanel.Controls.Add(this.userControlBookingsByType1);
            this.reportsTypePanel.Controls.Add(this.reportsBookingsByTypeLabel);
            this.reportsTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsTypePanel.Location = new System.Drawing.Point(0, 450);
            this.reportsTypePanel.Name = "reportsTypePanel";
            this.reportsTypePanel.Size = new System.Drawing.Size(926, 139);
            this.reportsTypePanel.TabIndex = 2;
            // 
            // userControlBookingsByType1
            // 
            this.userControlBookingsByType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBookingsByType1.Location = new System.Drawing.Point(0, 50);
            this.userControlBookingsByType1.Name = "userControlBookingsByType1";
            this.userControlBookingsByType1.Size = new System.Drawing.Size(926, 89);
            this.userControlBookingsByType1.TabIndex = 2;
            // 
            // reportsBookingsByTypeLabel
            // 
            this.reportsBookingsByTypeLabel.AutoSize = false;
            this.reportsBookingsByTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBookingsByTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.reportsBookingsByTypeLabel.Name = "reportsBookingsByTypeLabel";
            this.reportsBookingsByTypeLabel.Size = new System.Drawing.Size(926, 50);
            this.reportsBookingsByTypeLabel.TabIndex = 0;
            this.reportsBookingsByTypeLabel.Text = "Bookings by Type";
            this.reportsBookingsByTypeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // reportsStatusPanel
            // 
            this.reportsStatusPanel.Controls.Add(this.userControlCurrentStatus1);
            this.reportsStatusPanel.Controls.Add(this.reportsCurrentStatusLabel);
            this.reportsStatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsStatusPanel.Location = new System.Drawing.Point(0, 60);
            this.reportsStatusPanel.Name = "reportsStatusPanel";
            this.reportsStatusPanel.Size = new System.Drawing.Size(926, 390);
            this.reportsStatusPanel.TabIndex = 1;
            // 
            // userControlCurrentStatus1
            // 
            this.userControlCurrentStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCurrentStatus1.Location = new System.Drawing.Point(0, 50);
            this.userControlCurrentStatus1.Name = "userControlCurrentStatus1";
            this.userControlCurrentStatus1.Size = new System.Drawing.Size(926, 340);
            this.userControlCurrentStatus1.TabIndex = 1;
            // 
            // reportsCurrentStatusLabel
            // 
            this.reportsCurrentStatusLabel.AutoSize = false;
            this.reportsCurrentStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsCurrentStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.reportsCurrentStatusLabel.Name = "reportsCurrentStatusLabel";
            this.reportsCurrentStatusLabel.Size = new System.Drawing.Size(926, 50);
            this.reportsCurrentStatusLabel.TabIndex = 0;
            this.reportsCurrentStatusLabel.Text = "Current Status";
            this.reportsCurrentStatusLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // reportsHeaderPanel
            // 
            this.reportsHeaderPanel.Controls.Add(this.reportsWeeklyToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsMonthlyToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsDaysToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsDateNavigator);
            this.reportsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.reportsHeaderPanel.Name = "reportsHeaderPanel";
            this.reportsHeaderPanel.Size = new System.Drawing.Size(926, 60);
            this.reportsHeaderPanel.TabIndex = 0;
            // 
            // reportsWeeklyToggleButton
            // 
            this.reportsWeeklyToggleButton.Location = new System.Drawing.Point(392, 12);
            this.reportsWeeklyToggleButton.Name = "reportsWeeklyToggleButton";
            this.reportsWeeklyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsWeeklyToggleButton.TabIndex = 9;
            this.reportsWeeklyToggleButton.Text = "Weekly";
            // 
            // reportsMonthlyToggleButton
            // 
            this.reportsMonthlyToggleButton.Location = new System.Drawing.Point(494, 12);
            this.reportsMonthlyToggleButton.Name = "reportsMonthlyToggleButton";
            this.reportsMonthlyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsMonthlyToggleButton.TabIndex = 10;
            this.reportsMonthlyToggleButton.Text = "Monthly";
            // 
            // reportsDaysToggleButton
            // 
            this.reportsDaysToggleButton.Location = new System.Drawing.Point(290, 12);
            this.reportsDaysToggleButton.Name = "reportsDaysToggleButton";
            this.reportsDaysToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsDaysToggleButton.TabIndex = 8;
            this.reportsDaysToggleButton.Text = "3 Days";
            // 
            // reportsDateNavigator
            // 
            this.reportsDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.reportsDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportsDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportsDateNavigator.Name = "reportsDateNavigator";
            this.reportsDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.reportsDateNavigator.TabIndex = 2;
            // 
            // houseKeepingListView
            // 
            this.houseKeepingListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.houseKeepingListView.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingListView.Name = "houseKeepingListView";
            this.houseKeepingListView.Size = new System.Drawing.Size(269, 589);
            this.houseKeepingListView.TabIndex = 1;
            // 
            // houseKeepingNavigationPanel
            // 
            this.houseKeepingNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseKeepingNavigationPanel.Location = new System.Drawing.Point(269, 0);
            this.houseKeepingNavigationPanel.Name = "houseKeepingNavigationPanel";
            this.houseKeepingNavigationPanel.Size = new System.Drawing.Size(1011, 60);
            this.houseKeepingNavigationPanel.TabIndex = 0;
            // 
            // houseKeepingDateNavigator
            // 
            this.houseKeepingDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.houseKeepingDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.houseKeepingDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingDateNavigator.Name = "houseKeepingDateNavigator";
            this.houseKeepingDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.houseKeepingDateNavigator.TabIndex = 1;
            // 
            // houseKeepingDaysToggleButton
            // 
            this.houseKeepingDaysToggleButton.Location = new System.Drawing.Point(290, 12);
            this.houseKeepingDaysToggleButton.Name = "houseKeepingDaysToggleButton";
            this.houseKeepingDaysToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingDaysToggleButton.TabIndex = 5;
            this.houseKeepingDaysToggleButton.Text = "3 Days";
            // 
            // houseKeepingMonthlyToggleButton
            // 
            this.houseKeepingMonthlyToggleButton.Location = new System.Drawing.Point(494, 12);
            this.houseKeepingMonthlyToggleButton.Name = "houseKeepingMonthlyToggleButton";
            this.houseKeepingMonthlyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingMonthlyToggleButton.TabIndex = 7;
            this.houseKeepingMonthlyToggleButton.Text = "Monthly";
            // 
            // houseKeepingWeeklyToggleButton
            // 
            this.houseKeepingWeeklyToggleButton.Location = new System.Drawing.Point(392, 12);
            this.houseKeepingWeeklyToggleButton.Name = "houseKeepingWeeklyToggleButton";
            this.houseKeepingWeeklyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingWeeklyToggleButton.TabIndex = 6;
            this.houseKeepingWeeklyToggleButton.Text = "Weekly";
            // 
            // houseKeepingSplitContainer
            // 
            this.houseKeepingSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseKeepingSplitContainer.Location = new System.Drawing.Point(269, 60);
            this.houseKeepingSplitContainer.Name = "houseKeepingSplitContainer";
            this.houseKeepingSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.houseKeepingSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.houseKeepingSplitContainer.Size = new System.Drawing.Size(1011, 529);
            this.houseKeepingSplitContainer.TabIndex = 6;
            this.houseKeepingSplitContainer.TabStop = false;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Location = new System.Drawing.Point(0, 266);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1011, 263);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            // 
            // notAssignedLabel
            // 
            this.notAssignedLabel.AutoSize = false;
            this.notAssignedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notAssignedLabel.Location = new System.Drawing.Point(0, 0);
            this.notAssignedLabel.Name = "notAssignedLabel";
            this.notAssignedLabel.Size = new System.Drawing.Size(1062, 30);
            this.notAssignedLabel.TabIndex = 3;
            this.notAssignedLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // notAssignedGridView
            // 
            this.notAssignedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notAssignedGridView.Location = new System.Drawing.Point(0, 30);
            // 
            // 
            // 
            this.notAssignedGridView.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.notAssignedGridView.Name = "notAssignedGridView";
            this.notAssignedGridView.Size = new System.Drawing.Size(1062, 263);
            this.notAssignedGridView.TabIndex = 2;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1011, 262);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            // 
            // houseKeepingSchedulerHeaderLabel
            // 
            this.houseKeepingSchedulerHeaderLabel.AutoSize = false;
            this.houseKeepingSchedulerHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseKeepingSchedulerHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingSchedulerHeaderLabel.Name = "houseKeepingSchedulerHeaderLabel";
            this.houseKeepingSchedulerHeaderLabel.Size = new System.Drawing.Size(1011, 60);
            this.houseKeepingSchedulerHeaderLabel.TabIndex = 4;
            this.houseKeepingSchedulerHeaderLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // houseKeepingScheduler
            // 
            this.houseKeepingScheduler.Culture = new System.Globalization.CultureInfo("en-US");
            this.houseKeepingScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseKeepingScheduler.Location = new System.Drawing.Point(0, 60);
            this.houseKeepingScheduler.Name = "houseKeepingScheduler";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2017, 8, 6, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.houseKeepingScheduler.PrintStyle = schedulerDailyPrintStyle1;
            this.houseKeepingScheduler.Size = new System.Drawing.Size(1062, 232);
            this.houseKeepingScheduler.TabIndex = 5;
            // 
            // HouseKeepingPage
            // 
            this.HouseKeepingPage.Controls.Add(this.houseKeepingSplitContainer);
            this.HouseKeepingPage.Controls.Add(this.houseKeepingNavigationPanel);
            this.HouseKeepingPage.Controls.Add(this.houseKeepingListView);
            this.HouseKeepingPage.Location = new System.Drawing.Point(6, 55);
            this.HouseKeepingPage.Name = "HouseKeepingPage";
            this.HouseKeepingPage.Size = new System.Drawing.Size(1280, 589);
            this.HouseKeepingPage.Text = "السيارات";
            // 
            // scheduleListView
            // 
            this.scheduleListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleListView.Location = new System.Drawing.Point(0, 0);
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.Size = new System.Drawing.Size(269, 589);
            this.scheduleListView.TabIndex = 1;
            // 
            // scheduleRadSchedulerHeader
            // 
            this.scheduleRadSchedulerHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleRadSchedulerHeader.Location = new System.Drawing.Point(269, 0);
            this.scheduleRadSchedulerHeader.Name = "scheduleRadSchedulerHeader";
            this.scheduleRadSchedulerHeader.Size = new System.Drawing.Size(1011, 60);
            this.scheduleRadSchedulerHeader.TabIndex = 3;
            // 
            // ScheduleRadScheduler
            // 
            this.ScheduleRadScheduler.Culture = new System.Globalization.CultureInfo("en-US");
            this.ScheduleRadScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleRadScheduler.Location = new System.Drawing.Point(269, 60);
            this.ScheduleRadScheduler.Name = "ScheduleRadScheduler";
            schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2017, 7, 23, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.ScheduleRadScheduler.PrintStyle = schedulerDailyPrintStyle2;
            this.ScheduleRadScheduler.Size = new System.Drawing.Size(1011, 529);
            this.ScheduleRadScheduler.TabIndex = 4;
            // 
            // scheduleHeaderPanel
            // 
            this.scheduleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleHeaderPanel.Location = new System.Drawing.Point(269, 60);
            this.scheduleHeaderPanel.Name = "scheduleHeaderPanel";
            this.scheduleHeaderPanel.Size = new System.Drawing.Size(1011, 60);
            this.scheduleHeaderPanel.TabIndex = 0;
            // 
            // scheduleDaysButton
            // 
            this.scheduleDaysButton.Location = new System.Drawing.Point(290, 12);
            this.scheduleDaysButton.Name = "scheduleDaysButton";
            this.scheduleDaysButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleDaysButton.TabIndex = 2;
            this.scheduleDaysButton.Text = "3 Days";
            // 
            // scheduleMonthlyButton
            // 
            this.scheduleMonthlyButton.Location = new System.Drawing.Point(494, 12);
            this.scheduleMonthlyButton.Name = "scheduleMonthlyButton";
            this.scheduleMonthlyButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleMonthlyButton.TabIndex = 4;
            this.scheduleMonthlyButton.Text = "Monthly";
            // 
            // scheduleWeeklyButton
            // 
            this.scheduleWeeklyButton.Location = new System.Drawing.Point(392, 12);
            this.scheduleWeeklyButton.Name = "scheduleWeeklyButton";
            this.scheduleWeeklyButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleWeeklyButton.TabIndex = 3;
            this.scheduleWeeklyButton.Text = "Weekly";
            // 
            // scheduleDateNavigator
            // 
            this.scheduleDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.scheduleDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduleDateNavigator.Name = "scheduleDateNavigator";
            this.scheduleDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.scheduleDateNavigator.TabIndex = 0;
            // 
            // scheduleSearchPanel
            // 
            this.scheduleSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduleSearchPanel.Location = new System.Drawing.Point(361, 0);
            this.scheduleSearchPanel.Name = "scheduleSearchPanel";
            this.scheduleSearchPanel.Size = new System.Drawing.Size(650, 60);
            this.scheduleSearchPanel.TabIndex = 1;
            // 
            // scheduleSearchDropDown
            // 
            this.scheduleSearchDropDown.DropDownAnimationEnabled = true;
            this.scheduleSearchDropDown.Location = new System.Drawing.Point(21, 8);
            this.scheduleSearchDropDown.MaxLength = 65535;
            this.scheduleSearchDropDown.Name = "scheduleSearchDropDown";
            this.scheduleSearchDropDown.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.scheduleSearchDropDown.RootElement.EnableElementShadow = false;
            this.scheduleSearchDropDown.Size = new System.Drawing.Size(589, 25);
            this.scheduleSearchDropDown.TabIndex = 0;
            // 
            // scheduleBookingPanel
            // 
            this.scheduleBookingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduleBookingPanel.Location = new System.Drawing.Point(1010, 120);
            this.scheduleBookingPanel.Name = "scheduleBookingPanel";
            this.scheduleBookingPanel.Size = new System.Drawing.Size(270, 469);
            this.scheduleBookingPanel.TabIndex = 2;
            // 
            // scheduleEditGuestInfo
            // 
            this.scheduleEditGuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleEditGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.scheduleEditGuestInfo.Name = "scheduleEditGuestInfo";
            this.scheduleEditGuestInfo.Size = new System.Drawing.Size(270, 469);
            this.scheduleEditGuestInfo.TabIndex = 0;
            // 
            // scheduleBookingInfo
            // 
            this.scheduleBookingInfo.Booking = null;
            this.scheduleBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleBookingInfo.Location = new System.Drawing.Point(0, 0);
            this.scheduleBookingInfo.Name = "scheduleBookingInfo";
            this.scheduleBookingInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scheduleBookingInfo.Room = null;
            this.scheduleBookingInfo.Size = new System.Drawing.Size(270, 469);
            this.scheduleBookingInfo.TabIndex = 0;
            // 
            // SchedulePage
            // 
            this.SchedulePage.Controls.Add(this.scheduleBookingPanel);
            this.SchedulePage.Controls.Add(this.scheduleHeaderPanel);
            this.SchedulePage.Controls.Add(this.ScheduleRadScheduler);
            this.SchedulePage.Controls.Add(this.scheduleRadSchedulerHeader);
            this.SchedulePage.Controls.Add(this.scheduleListView);
            this.SchedulePage.Location = new System.Drawing.Point(6, 55);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Size = new System.Drawing.Size(1280, 589);
            this.SchedulePage.Text = "السائقين";
            // 
            // radToolbarFormControl2
            // 
            this.radToolbarFormControl2.AutoSize = true;
            this.radToolbarFormControl2.CausesValidation = false;
            this.radToolbarFormControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radToolbarFormControl2.Location = new System.Drawing.Point(0, 0);
            this.radToolbarFormControl2.Name = "radToolbarFormControl2";
            this.radToolbarFormControl2.Size = new System.Drawing.Size(938, 47);
            this.radToolbarFormControl2.TabIndex = 1;
            this.radToolbarFormControl2.ThemeName = "Material";
            // 
            // HotelAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 697);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.radToolbarFormControl2);
            this.Name = "HotelAppForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ThemeName = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HotelApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.OverviewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewMainContainer)).EndInit();
            this.overviewMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewRoomsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewLeftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelOverview)).EndInit();
            this.navigationPanelOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerOverview)).EndInit();
            this.searchContainerOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyOverview)).EndInit();
            this.BookingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsMainContainer)).EndInit();
            this.bookingsMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoRightPanel)).EndInit();
            this.bookingInfoRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelBookings)).EndInit();
            this.navigationPanelBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerBookings)).EndInit();
            this.searchContainerBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyBooking)).EndInit();
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            this.radPageViewPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel9)).EndInit();
            this.radPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel10)).EndInit();
            this.radPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).EndInit();
            this.radPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel7)).EndInit();
            this.radPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel8)).EndInit();
            this.ReportsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsTypePanel)).EndInit();
            this.reportsTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBookingsByTypeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsStatusPanel)).EndInit();
            this.reportsStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsCurrentStatusLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsHeaderPanel)).EndInit();
            this.reportsHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsWeeklyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsMonthlyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDaysToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingNavigationPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingDaysToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingMonthlyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingWeeklyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSplitContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSchedulerHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingScheduler)).EndInit();
            this.HouseKeepingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRadSchedulerHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleRadScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleHeaderPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDaysButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMonthlyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleWeeklyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookingPanel)).EndInit();
            this.SchedulePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radToolbarFormControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadPageView mainContainer;
        private Telerik.WinControls.UI.RadPageViewPage OverviewPage;
        private Telerik.WinControls.UI.RadPageViewPage BookingsPage;
        private Telerik.WinControls.UI.RadPanel navigationPanelOverview;
        private Telerik.WinControls.UI.RadListView overviewLeftView;
        private Telerik.WinControls.UI.RadListView overviewRoomsView;
        private DateNavigator dateNavigatorOverview;
        private Telerik.WinControls.UI.RadPanel searchContainerOverview;
        private SearchTextBox searchTextBoxOverview;
        private Telerik.WinControls.UI.RadPanel radPanelEmptyOverview;
        private Telerik.WinControls.UI.RadPanel navigationPanelBookings;
        private Telerik.WinControls.UI.RadPanel searchContainerBookings;
        private SearchTextBox searchTextBoxBookings;
        private Telerik.WinControls.UI.RadPanel radPanelEmptyBooking;
        private DateNavigator dateNavigatorBookings;
        private Telerik.WinControls.UI.RadPanel bookingsMainContainer;
        private Telerik.WinControls.UI.RadGridView bookingsGrid;
        private Telerik.WinControls.UI.RadLabel labelBookings;
        private Telerik.WinControls.UI.RadPanel overviewMainContainer;
        private Telerik.WinControls.UI.RadPageViewPage ReportsPage;
        private Telerik.WinControls.UI.RadPanel bookingInfoRightPanel;
        private BookingInfo bookingInfoUC;
        private EditGuestInfo editGuestInfo;
        private RadPanel reportsHeaderPanel;
        private RadPanel reportsTypePanel;
        private RadPanel reportsStatusPanel;
        private DateNavigator reportsDateNavigator;
        private RadToggleButton reportsWeeklyToggleButton;
        private RadToggleButton reportsMonthlyToggleButton;
        private RadToggleButton reportsDaysToggleButton;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialPinkTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private RadLabel reportsBookingsByTypeLabel;
        private UserControlCurrentStatus userControlCurrentStatus1;
        private RadLabel reportsCurrentStatusLabel;
        private UserControlBookingsByType userControlBookingsByType1;
        private RadToolbarFormControl radToolbarFormControl1;
        private RadListView houseKeepingListView;
        private RadPanel houseKeepingNavigationPanel;
        private DateNavigator houseKeepingDateNavigator;
        private RadToggleButton houseKeepingDaysToggleButton;
        private RadToggleButton houseKeepingMonthlyToggleButton;
        private RadToggleButton houseKeepingWeeklyToggleButton;
        private RadSplitContainer houseKeepingSplitContainer;
        private SplitPanel splitPanel2;
        private RadLabel notAssignedLabel;
        private RadGridView notAssignedGridView;
        private SplitPanel splitPanel1;
        private RadLabel houseKeepingSchedulerHeaderLabel;
        private RadScheduler houseKeepingScheduler;
        private RadPageViewPage HouseKeepingPage;
        private RadListView scheduleListView;
        private RadPanel scheduleRadSchedulerHeader;
        private RadScheduler ScheduleRadScheduler;
        private RadPanel scheduleHeaderPanel;
        private RadToggleButton scheduleDaysButton;
        private RadToggleButton scheduleMonthlyButton;
        private RadToggleButton scheduleWeeklyButton;
        private DateNavigator scheduleDateNavigator;
        private RadPanel scheduleSearchPanel;
        private SearchDropDownList scheduleSearchDropDown;
        private RadPanel scheduleBookingPanel;
        private EditGuestInfo scheduleEditGuestInfo;
        private BookingInfo scheduleBookingInfo;
        private RadPageViewPage SchedulePage;
        private RadPageViewPage radPageViewPage1;
        private RadPageViewPage radPageViewPage2;
        private RadPageViewPage radPageViewPage3;
        private RadPanel radPanel4;
        private RadGridView radGridView1;
        private RadLabel radLabel1;
        private RadPanel radPanel5;
        private EditGuestInfo editGuestInfo1;
        private BookingInfo bookingInfo1;
        private RadPanel radPanel1;
        private RadPanel radPanel2;
        private SearchTextBox searchTextBox1;
        private RadPanel radPanel3;
        private DateNavigator dateNavigator1;
        private RadPageViewPage radPageViewPage4;
        private RadPanel radPanel9;
        private RadGridView radGridView2;
        private RadLabel radLabel2;
        private RadPanel radPanel10;
        private EditGuestInfo editGuestInfo2;
        private BookingInfo bookingInfo2;
        private RadPanel radPanel6;
        private RadPanel radPanel7;
        private SearchTextBox searchTextBox2;
        private RadPanel radPanel8;
        private DateNavigator dateNavigator2;
        private RadToolbarFormControl radToolbarFormControl2;
    }
}