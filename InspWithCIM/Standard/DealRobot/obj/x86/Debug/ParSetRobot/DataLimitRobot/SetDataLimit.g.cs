﻿#pragma checksum "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7691E69FA74B98612C6517322833740E4F15162903321302F062A73A1F4A2EDA"
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
using DealRobot;
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


namespace DealRobot {
    
    
    /// <summary>
    /// UCSetDataLimit
    /// </summary>
    public partial class UCSetDataLimit : DealRobot.BaseUCRobot, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdButton1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRobotData;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.ButtonColor btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/DealRobot;component/parsetrobot/datalimitrobot/setdatalimit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml"
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
            this.gdButton1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dgRobotData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnSave = ((ControlLib.ButtonColor)(target));
            
            #line 46 "..\..\..\..\..\ParSetRobot\DataLimitRobot\SetDataLimit.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

