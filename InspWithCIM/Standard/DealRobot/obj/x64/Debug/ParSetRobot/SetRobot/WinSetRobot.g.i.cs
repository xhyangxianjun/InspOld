﻿#pragma checksum "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC67680CFFCCB70D684144A6BE9DE39EED7DA8E9"
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
    /// WinSetRobot
    /// </summary>
    public partial class WinSetRobot : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdLayout;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander epdSetBase;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView tvSetRobot;
        
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
            System.Uri resourceLocater = new System.Uri("/DealRobot;component/parsetrobot/setrobot/winsetrobot.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
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
            
            #line 9 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
            ((DealRobot.WinSetRobot)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gdLayout = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.epdSetBase = ((System.Windows.Controls.Expander)(target));
            return;
            case 4:
            this.tvSetRobot = ((System.Windows.Controls.TreeView)(target));
            
            #line 47 "..\..\..\..\..\ParSetRobot\SetRobot\WinSetRobot.xaml"
            this.tvSetRobot.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.tvSetRobot_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

