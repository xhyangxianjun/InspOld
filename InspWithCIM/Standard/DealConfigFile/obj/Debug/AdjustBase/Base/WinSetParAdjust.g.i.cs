﻿#pragma checksum "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51950B7C71F9AF14DA8D41431E53538CD49ADAA175B46C6E330D3BDF7F207995"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using BasicClass;
using ControlLib;
using DealConfigFile;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace DealConfigFile {
    
    
    /// <summary>
    /// WinSetParAdjust
    /// </summary>
    public partial class WinSetParAdjust : BasicClass.BaseMetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.NGroupBox gpbAdjust;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSetAdjust;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnSave;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnClose;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DealConfigFile;component/adjustbase/base/winsetparadjust.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gpbAdjust = ((ControlLib.NGroupBox)(target));
            return;
            case 2:
            this.dgSetAdjust = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnSave = ((ControlLib.ButtonColor)(target));
            
            #line 55 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose = ((ControlLib.ButtonColor)(target));
            
            #line 56 "..\..\..\..\AdjustBase\Base\WinSetParAdjust.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

