﻿#pragma checksum "..\..\ModifyPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D99084407522D073A59115F6D37A5E543C71E6BBE5543F6E7D258918D2F7985"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Empolyee_System;
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


namespace Empolyee_System {
    
    
    /// <summary>
    /// ModifyPage
    /// </summary>
    public partial class ModifyPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ExpenseType;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Amount;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Department;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridForUpdate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_button;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update_button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ModifyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Empolyee_System;component/modifypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModifyPage.xaml"
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
            this.ExpenseType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Department = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DataGridForUpdate = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Add_button = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ModifyPage.xaml"
            this.Add_button.Click += new System.Windows.RoutedEventHandler(this.Add_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Delete_button = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ModifyPage.xaml"
            this.Delete_button.Click += new System.Windows.RoutedEventHandler(this.Delete_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Update_button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\ModifyPage.xaml"
            this.Update_button.Click += new System.Windows.RoutedEventHandler(this.Update_button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Refresh_button = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\ModifyPage.xaml"
            this.Refresh_button.Click += new System.Windows.RoutedEventHandler(this.Refresh_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
