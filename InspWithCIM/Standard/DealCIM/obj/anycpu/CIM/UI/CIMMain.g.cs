﻿#pragma checksum "..\..\..\..\CIM\UI\CIMMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58F21A0E2296ABCDD66A805D01E5C9F47D54754343578ED97FA22144AE0E6910"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DealCIM;
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


namespace DealCIM {
    
    
    /// <summary>
    /// CIMMain
    /// </summary>
    public partial class CIMMain : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCIMStatus;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCodeStatus;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblArmChipID;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblForkChipID;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblChipIDResult;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLotResult;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTrackoutResult;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\CIM\UI\CIMMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLot;
        
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
            System.Uri resourceLocater = new System.Uri("/DealCIM;component/cim/ui/cimmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\CIM\UI\CIMMain.xaml"
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
            
            #line 8 "..\..\..\..\CIM\UI\CIMMain.xaml"
            ((DealCIM.CIMMain)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCIMStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblCodeStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblArmChipID = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblForkChipID = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblChipIDResult = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblLotResult = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblTrackoutResult = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblLot = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

