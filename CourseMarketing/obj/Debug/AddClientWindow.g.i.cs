﻿#pragma checksum "..\..\AddClientWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EAF31891ED059EC9A449FB2210ADB82E024E91FB4E96BE27A4C7E46455229604"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseMarketing;
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


namespace CourseMarketing {
    
    
    /// <summary>
    /// AddClientWindow
    /// </summary>
    public partial class AddClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddSurname;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddPatronymic;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddCompany;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddPhone;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxAddEmail;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseMarketing;component/addclientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddClientWindow.xaml"
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
            this.BoxAddSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BoxAddName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BoxAddPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BoxAddCompany = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BoxAddPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BoxAddEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddClientButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AddClientWindow.xaml"
            this.AddClientButton.Click += new System.Windows.RoutedEventHandler(this.AddClientButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

