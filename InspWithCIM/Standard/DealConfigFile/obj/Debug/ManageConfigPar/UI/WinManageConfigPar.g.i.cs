﻿#pragma checksum "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F71CF27E1D48AFF384BD0A8E7D39646022A8924D24991D1AE469EB7620E75A84"
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
using Common;
using ControlLib;
using DealConfigFile;
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
    /// WinManageConfigPar
    /// </summary>
    public partial class WinManageConfigPar : BasicClass.BaseWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgFileList;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtModel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdLayout;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnSaveNew;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnDelete;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnChangeModel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/DealConfigFile;component/manageconfigpar/ui/winmanageconfigpar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
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
            
            #line 8 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            ((DealConfigFile.WinManageConfigPar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BaseMetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgFileList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            this.dgFileList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgFileList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.gdLayout = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.btnSaveNew = ((ControlLib.ButtonColor)(target));
            
            #line 46 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            this.btnSaveNew.Click += new System.Windows.RoutedEventHandler(this.btnSaveNew_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((ControlLib.ButtonColor)(target));
            
            #line 47 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnChangeModel = ((ControlLib.ButtonColor)(target));
            
            #line 48 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            this.btnChangeModel.Click += new System.Windows.RoutedEventHandler(this.btnChangeModel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClose = ((ControlLib.ButtonColor)(target));
            
            #line 49 "..\..\..\..\ManageConfigPar\UI\WinManageConfigPar.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

