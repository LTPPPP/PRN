﻿#pragma checksum "..\..\..\BookingManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498A1C691F5F45BED9D2D096FD7176A48EBF1D00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using assignment01.ViewModels;


namespace assignment01 {
    
    
    /// <summary>
    /// BookingManagement
    /// </summary>
    public partial class BookingManagement : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingID_txtBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerID_txtBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomID_txtBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookingDate_txtBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CheckInDate_txtBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CheckOutDate_txtBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalPrice_txtBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\BookingManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView BookingListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/assignment01;component/bookingmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookingManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BookingID_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CustomerID_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RoomID_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BookingDate_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CheckInDate_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CheckOutDate_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TotalPrice_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BookingListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

