﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1B8A5E9FA7399C9F77C4E913EE44853C4D780562"
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
using WPF_Controls_Challenge;


namespace WPF_Controls_Challenge {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox menuItems;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Latte;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Frapuccino;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Mocha;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Machiato;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sizeSmall;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sizeMedium;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sizeLarge;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cream;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Sugar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock summaryText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF Controls Challenge;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.menuItems = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.Latte = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.Latte.Selected += new System.Windows.RoutedEventHandler(this.menuSelection);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Frapuccino = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.Frapuccino.Selected += new System.Windows.RoutedEventHandler(this.menuSelection);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Mocha = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.Mocha.Selected += new System.Windows.RoutedEventHandler(this.menuSelection);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Machiato = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.Machiato.Selected += new System.Windows.RoutedEventHandler(this.menuSelection);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sizeSmall = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.sizeSmall.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sizeMedium = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.sizeMedium.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sizeLarge = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.sizeLarge.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cream = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\MainWindow.xaml"
            this.Cream.Checked += new System.Windows.RoutedEventHandler(this.addExtras);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\MainWindow.xaml"
            this.Cream.Unchecked += new System.Windows.RoutedEventHandler(this.addExtras);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Sugar = ((System.Windows.Controls.CheckBox)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.Sugar.Checked += new System.Windows.RoutedEventHandler(this.addExtras);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.Sugar.Unchecked += new System.Windows.RoutedEventHandler(this.addExtras);
            
            #line default
            #line hidden
            return;
            case 11:
            this.summaryText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 52 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.submitOrder);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

