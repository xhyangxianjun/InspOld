﻿#pragma checksum "..\..\..\..\Manual\WinManualRobot.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BACDE5781F20B9BEF98396179B9BE861813497F70393D74871D688B7BD63A82C"
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


namespace DealRobot {
    
    
    /// <summary>
    /// WinManualRobot
    /// </summary>
    public partial class WinManualRobot : BasicClass.BaseMetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Manual\WinManualRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdLayout;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Manual\WinManualRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroTabControl robot;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Manual\WinManualRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DealRobot.UCRobotCtr uCRobotCtr1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Manual\WinManualRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DealRobot.UCTechRobot uCTeachRobot;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Manual\WinManualRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DealRobot.UCRobotIO uCRobotIO;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Manual\WinManualRobot.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DealRobot;component/manual/winmanualrobot.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Manual\WinManualRobot.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 8 "..\..\..\..\Manual\WinManualRobot.xaml"
            ((DealRobot.WinManualRobot)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BaseMetroWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Manual\WinManualRobot.xaml"
            ((DealRobot.WinManualRobot)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.BaseMetroWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gdLayout = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.robot = ((MahApps.Metro.Controls.MetroTabControl)(target));
            return;
            case 4:
            this.uCRobotCtr1 = ((DealRobot.UCRobotCtr)(target));
            return;
            case 5:
            this.uCTeachRobot = ((DealRobot.UCTechRobot)(target));
            return;
            case 6:
            this.uCRobotIO = ((DealRobot.UCRobotIO)(target));
            return;
            case 7:
            this.btnClose = ((ControlLib.ButtonColor)(target));
            
            #line 57 "..\..\..\..\Manual\WinManualRobot.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

