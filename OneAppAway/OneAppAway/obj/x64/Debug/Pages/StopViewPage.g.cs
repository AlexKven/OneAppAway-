﻿#pragma checksum "C:\Users\Alexander\Documents\GitHub\OneAppAway-\OneAppAway\OneAppAway\Pages\StopViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03D2453E4C0A82A1907F6051C7959F6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneAppAway
{
    partial class StopViewPage : 
        global::OneAppAway.NavigationFriendlyPage, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 11 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.MainGrid).SizeChanged += this.MainGrid_SizeChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.MainAppBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 108 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.RefreshButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.ArrivalsToggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 109 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.ArrivalsToggle).Checked += this.AppBarToggleButton_CheckedChanged;
                    #line 109 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.ArrivalsToggle).Unchecked += this.AppBarToggleButton_CheckedChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.ScheduleToggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 114 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.ScheduleToggle).Checked += this.AppBarToggleButton_CheckedChanged;
                    #line 114 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.ScheduleToggle).Unchecked += this.AppBarToggleButton_CheckedChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.RoutesToggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 119 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.RoutesToggle).Checked += this.AppBarToggleButton_CheckedChanged;
                    #line 119 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.RoutesToggle).Unchecked += this.AppBarToggleButton_CheckedChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.InnerGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 17 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.InnerGrid).SizeChanged += this.InnerGrid_SizeChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.ArrivalsColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 9:
                {
                    this.ScheduleColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 10:
                {
                    this.RoutesColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 11:
                {
                    this.MainMap = (global::OneAppAway.BusMap)(target);
                }
                break;
            case 12:
                {
                    this.LastRefreshBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.ArrivalsProgressIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 14:
                {
                    this.MainScheduleBrowser = (global::OneAppAway.ScheduleBrowser)(target);
                }
                break;
            case 15:
                {
                    this.LoadSchedulesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoadSchedulesButton).Click += this.LoadSchedulesButton_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.ScheduleNotAvailableBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.DayScheduleSelector = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 18:
                {
                    this.ScheduleProgressIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 19:
                {
                    this.RoutesProgressIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 20:
                {
                    this.RoutesControl = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 21:
                {
                    global::Windows.UI.Xaml.Controls.Button element21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element21).Click += this.RouteButton_Click;
                    #line default
                }
                break;
            case 22:
                {
                    global::Windows.UI.Xaml.Controls.Button element22 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 78 "..\..\..\Pages\StopViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element22).Click += this.RouteButton_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.ArrivalsStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 24:
                {
                    this.DirectionImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 25:
                {
                    this.TitleBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

