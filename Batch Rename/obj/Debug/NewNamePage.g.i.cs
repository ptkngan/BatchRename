﻿#pragma checksum "..\..\NewNamePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68132FCB11CF82B3BE15AFBB7AED567666DBC2692B5D835A27956A9DE8E8A199"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Batch_Rename;
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


namespace Batch_Rename {
    
    
    /// <summary>
    /// NewNamePage
    /// </summary>
    public partial class NewNamePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NewNamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GuidName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NewNamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IncNum;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\NewNamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IncLetter;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\NewNamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Normalize;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\NewNamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnOldName;
        
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
            System.Uri resourceLocater = new System.Uri("/Batch Rename;component/newnamepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewNamePage.xaml"
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
            this.GuidName = ((System.Windows.Controls.TextBlock)(target));
            
            #line 10 "..\..\NewNamePage.xaml"
            this.GuidName.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GuidName_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IncNum = ((System.Windows.Controls.TextBlock)(target));
            
            #line 25 "..\..\NewNamePage.xaml"
            this.IncNum.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.IncNum_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IncLetter = ((System.Windows.Controls.TextBlock)(target));
            
            #line 39 "..\..\NewNamePage.xaml"
            this.IncLetter.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.IncLetter_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Normalize = ((System.Windows.Controls.TextBlock)(target));
            
            #line 53 "..\..\NewNamePage.xaml"
            this.Normalize.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Normalize_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ReturnOldName = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\NewNamePage.xaml"
            this.ReturnOldName.Click += new System.Windows.RoutedEventHandler(this.ReturnOldName_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

